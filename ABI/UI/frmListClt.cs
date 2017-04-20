using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataGridView;

namespace ABI.UI
{
    public partial class frmListClt : Form
    {
        private ClientDB client;
        private String searchCriteria;
        //Variable used to control the click on the dataGridView, within itself = false, outside the dataGridView = true
        private Boolean isGridHitNoWhere = false;
        BindingList<ClientDB> listClients = Data.db.ClientDB.Local.ToBindingList();
                
        /// <summary>
        /// Constructor with no arguments
        /// </summary>
        public frmListClt()
        {
            InitializeComponent();
            cbxSearch.Items.Add(Tools.RAISONSOCIALE);
            cbxSearch.Items.Add(Tools.VILLE);
            cbxSearch.Items.Add(Tools.CHIFFREAFFAIRES);
            cbxSearch.Items.Add(Tools.EFFECTIF);
            cbxSearch.Items.Add(Tools.ACTIVITE);
            cbxSearch.Items.Add(Tools.NATURE);
            cbxSearch.Items.Add(Tools.TYPE);
            cbxSearch.SelectedItem = Tools.RAISONSOCIALE;
            cbxType.Items.Add(Tools.PUBLIC);
            cbxType.Items.Add(Tools.PRIVE);
            txtSearchClient.Select();
        }

        /// <summary>
        /// Call to initialize the Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClient_Load(object sender, EventArgs e)
        {

            Data.db.ClientDB.Load();
            clientDBBindingSource.DataSource = listClients;

            setVisualDataGridView();
        }

        private void setVisualDataGridView()
        {
            grdClient.Columns[0].Visible = false;

            grdClient.Columns[1].HeaderText = Tools.RAISONSOCIALE;
            grdClient.Columns[2].HeaderText = Tools.TYPE;
            grdClient.Columns[3].HeaderText = Tools.ACTIVITE;
            grdClient.Columns[4].HeaderText = Tools.NATURE;
            grdClient.Columns[5].HeaderText = Tools.EFFECTIF;
            grdClient.Columns[6].HeaderText = Tools.CHIFFREAFFAIRES;
            grdClient.Columns[7].HeaderText = Tools.COMMENTAIRE;
            grdClient.Columns[8].HeaderText = Tools.TELEPHONE;
            grdClient.Columns[9].HeaderText = Tools.ADRESSE;
            grdClient.Columns[10].HeaderText = Tools.CODE_POSTAL;
            grdClient.Columns[11].HeaderText = Tools.VILLE;

            // Set the row and column header styles.
            grdClient.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            grdClient.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            grdClient.RowsDefaultCellStyle.BackColor = Color.LightGray;
            grdClient.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdClient.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            DataGridViewCellStyle defaultStyle = new DataGridViewCellStyle();
            defaultStyle.SelectionBackColor = Color.White;
            defaultStyle.SelectionForeColor = Color.Black;
            grdClient.DefaultCellStyle = defaultStyle;

            DataGridViewCellStyle raisonSocialStyle = new DataGridViewCellStyle();
            raisonSocialStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            raisonSocialStyle.ForeColor = Color.DarkBlue;
            //grdClient.Columns[Tools.RAISONSOCIALE].DefaultCellStyle = raisonSocialStyle;

            DataGridViewCellStyle idClient = new DataGridViewCellStyle();
            idClient.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grdClient.Columns[Tools.IDCLIENT].DefaultCellStyle = idClient;
        }

        //---------Action NewClient, AddClient, detailClient, updateClient and deleteClient-------//
        /// <summary>
        /// Display the frmNewClt to create a new Client
        /// </summary>
        private void newClient()
        {
            frmNewClt fnc = new frmNewClt();
            fnc.newClient += new NewClientHandler(this.saveClient);
            fnc.ShowDialog();
        }
        /// <summary>
        /// Save the client to the DB 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="toShow">To display the client TRUE otherwise FALSE</param>
        private void saveClient(ClientDB client, Boolean toShow)
        {
            if (client != null)
            {
                if (toShow)
                {
                    if (!tabControlClients.displayTab(client))
                    {
                        tabControlClients.addTab(detailClient(client));
                    }
                }
                Data.db.ClientDB.Add(client);
                Data.db.SaveChanges();
            }
        }

        private frmDspClient detailClient(ClientDB client)
        {
            frmDspClient fdc = new frmDspClient(client);
            fdc.UpdatingClient += new ClientHandler(this.updateClient);
            fdc.DeletingClient += new ClientHandler(this.deleteClient);
            fdc.ClosingTab += new ClientHandler(this.closingTab);
            fdc.TopLevel = false;
            fdc.Dock = DockStyle.Fill;
            fdc.Show();
            return fdc;
        }

        private void closingTab(ClientDB client)
        {
            if (client != null)
            {
                tabControlClients.removeTab(client);
            }
        }

        /// <summary>
        /// Update a Client
        /// </summary>
        /// <param name="client"></param>
        private void updateClient(ClientDB client)
        {
            this.client = client;
            Data.db.SaveChanges();
            //Update tabPage
            tabControlClients.updateTab(client);
            
        }

        /// <summary>
        /// Delete a client from the Tab and from the DB, if the client has Contacts, removes all his contacts too.
        /// </summary>
        /// <param name="client">Take a client as Parameter</param>
        private void deleteClient(ClientDB client)
        {
            Boolean canRemove = true;
            //Remove the tab from the TabControl
            tabControlClients.removeTab(client);
            //get the row of the selection to retrieve the client selected
            foreach (DataGridViewRow row in grdClient.SelectedRows)
            {
                //Get the id from the DataGridView
                Int32 id = (Int32)row.Cells[0].Value;
                //Find the client with the id from the DataGridView
                ClientDB c = Data.db.ClientDB.Find(id);
                //if client found
                if (c != null)
                {
                    client = c;
                    //Check whether the client has contacts
                    if (client.ContactDB.Count > 0)
                    {
                        //confirmation to delete the client and all his contacts
                        DialogResult result = MessageBox.Show("La suppression de " + client.raisonSocial +
                                                            " entraîne la suppression de tous ses contacts \n" +
                                                            "voulez-vous continuer ?", "Supprimer Contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        //if confirmed
                        if (result == DialogResult.Yes)
                        {
                            //list all the contacts form the client
                            var L2EQuery = Data.db.ContactDB.Where(s => s.idClient == client.idClient);
                            List<ContactDB> listContact = L2EQuery.ToList<ContactDB>();
                            for (Int32 j = 0; j < listContact.Count; j++)
                            {
                                //Remove each contact from the DB
                                ContactDB contact = listContact[j];
                                Data.db.ContactDB.Remove(contact);
                            }
                        }
                        else
                        {
                            canRemove = false;
                        }
                    }
                    if (canRemove)
                    {
                        //Remove the client
                        Data.db.ClientDB.Remove(client);
                        //Save all changes
                        Data.db.SaveChanges();
                        //delete the reference of this client
                        client = null;
                    }
                }
            }
        }
       
        //-----------Buttons Left Panel ( Ajouter / Supprimer / Afficher / Fermer Tabs / Fermer App ----------------

        /// <summary>
        /// Open a new frmNewClt Dialog and register an event when saving the client 
        /// <para>Add a tab with the new client upon creation</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            newClient();
        }

        /// <summary>
        /// Delete a client upon confirmation calls the method deleteClient(Client client)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Check whether the client isn't null
            if (client != null)
            {
                //Show dialog to confirm before deleting
                DialogResult result = MessageBox.Show("Voulez-vous supprimer le client " + client.raisonSocial, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Deleting the client
                    deleteClient(client);
                    //check if the grdclient isn't empty
                    if (grdClient.Rows.Count > 0)
                    {
                        //set the selected row to the first one
                        grdClient.Rows[0].Selected = true;
                    }
                    else
                    {
                        //if no more row in the gridView then set the client to null after deleting the last client
                        client = null;
                    }
                }
            }
        }

        /// <summary>
        /// Add a client to the tab, calls the method addClientTab(Client client)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                if (!tabControlClients.displayTab(client))
                {
                    tabControlClients.addTab(detailClient(client));
                }
            }
        }

        /// <summary>
        /// Allow to close all opened tabs and come back to the first tab ListClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseAllTabs_Click(object sender, EventArgs e)
        {
            tabControlClients.closeTabs();
        }

        /// <summary>
        /// Close the ListClient Tab of the application
        /// <para>clear all dictionnary, </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseCommercial_Click(object sender, EventArgs e)
        {
            tabControlClients.closeTabs();
            Close();
        }

        //------------Events-----------------------------
        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            if (grdClient.CurrentRow != null)
            {
                client = Data.db.ClientDB.Find((Int32)grdClient.CurrentRow.Cells[0].Value);
            }
            else
            {
                client = null;
            }
        }

        /// <summary>
        /// Check whether a click is within the dataGridView or outside
        /// <para>If outside, the variable isGridHitNoWhere = true</para>
        /// <para>If inside, the variable isGridHitNoWhere = false</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (grdClient.HitTest(e.X, e.Y) == HitTestInfo.Nowhere)
                {
                    isGridHitNoWhere = true;
                }
                else isGridHitNoWhere = false;
            }
        }

        /// <summary>
        /// Display the complete list clients upon the button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReinitializeSearch_Click(object sender, EventArgs e)
        {
            txtSearchClient.Text = null;
            //((DataView)grdClient.DataSource).RowFilter = null;
            grdClient.DataSource = Data.db.ClientDB.ToList();

        }

        /// <summary>
        /// Called upon each key up on the search box
        /// <para>used when raisonsociale or ville is selected or when press enter with a seleted client</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearchClient_KeyUp(object sender, KeyEventArgs e)
        {
            //if the key is enter and text isn't null, then if the client isn't null open the client tab 
            if (e.KeyCode == Keys.Enter && txtSearchClient.Text != String.Empty)
            {
                if (client != null)
                {
                    //tabControlClients.addTab(this, client);
                }
            }
            //if raisonsociale is selected, filter the list by raison sociale
            else if (txtSearchClient.Text != null && searchCriteria == Tools.RAISONSOCIALE)
            {
                clientDBBindingSource.DataSource = listClients.Where(c => c.raisonSocial.ToLower().Contains(txtSearchClient.Text.ToLower())).ToList();
            }
            //if raisonsociale is selected, filter the list by ville
            else if (txtSearchClient.Text != null && searchCriteria == Tools.VILLE)
            {
                clientDBBindingSource.DataSource = listClients.Where(c => c.ville.ToLower().Contains(txtSearchClient.Text.ToLower())).ToList();
            }

        }

        /// <summary>
        /// Display or hide the appropriate controls upon the search criteria selection
        /// <para>sets up the variable searchCriteria with the selected item</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = cbxSearch.SelectedItem.ToString();
            if (searchCriteria == Tools.CHIFFREAFFAIRES || searchCriteria == Tools.EFFECTIF)
            {
                showControlChiffreAffairesAndEffectif();
                hideControlType();  
            }
            if(searchCriteria == Tools.RAISONSOCIALE)
            {
                hideControlChiffreAffairesAndEffectif();
                hideControlType();
            }
            if(searchCriteria == Tools.VILLE)
            {
                hideControlChiffreAffairesAndEffectif();
                hideControlType();
            }
            if(searchCriteria == Tools.EFFECTIF)
            {
                showControlChiffreAffairesAndEffectif();
                hideControlType();
            }
            if(searchCriteria == Tools.TYPE)
            {
                showControlType();
            }
        }

        /// <summary>
        /// Hide controls used for chiffreAffaire and Effectifs
        /// </summary>
        private void hideControlChiffreAffairesAndEffectif()
        {
            rbEgal.Visible = false;
            rbInfEgal.Visible = false;
            rbSupEgal.Visible = false;
            btnSearch.Visible = false;
        }

        /// <summary>
        /// Show controls used for chiffreAffaire and Effectifs
        /// </summary>
        private void showControlChiffreAffairesAndEffectif()
        {
            rbEgal.Visible = true;
            rbInfEgal.Visible = true;
            rbSupEgal.Visible = true;
            btnSearch.Visible = true;
        }

        /// <summary>
        /// Hide controls used for Type
        /// </summary>
        private void hideControlType()
        {
            cbxType.Visible = false;
        }

        /// <summary>
        /// Show controls used for Type
        /// </summary>
        private void showControlType()
        {
            cbxType.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchClient.Text != null && searchCriteria == Tools.CHIFFREAFFAIRES)
            {
                if (rbEgal.Checked)
                {
                    Decimal d;
                    if(Decimal.TryParse(txtSearchClient.Text, out d))
                    {
                        clientDBBindingSource.DataSource = listClients.Where(c => c.ca == d).ToList();
                    }
                }
                if (rbInfEgal.Checked)
                {
                    Decimal d;
                    if (Decimal.TryParse(txtSearchClient.Text, out d))
                    {
                        clientDBBindingSource.DataSource = listClients.Where(c => c.ca <= d).ToList();
                    }
                }
                if (rbSupEgal.Checked)
                {
                    Decimal d;
                    if (Decimal.TryParse(txtSearchClient.Text, out d))
                    {
                        clientDBBindingSource.DataSource = listClients.Where(c => c.ca >= d).ToList();
                    }
                }
            }

            if (txtSearchClient.Text != null && searchCriteria == Tools.EFFECTIF)
            {
                if (rbEgal.Checked)
                {
                    ((DataView)grdClient.DataSource).RowFilter = Tools.EFFECTIF + " = " + Decimal.Parse(txtSearchClient.Text);
                }
                if (rbInfEgal.Checked)
                {
                    ((DataView)grdClient.DataSource).RowFilter = Tools.EFFECTIF + " <= " + Decimal.Parse(txtSearchClient.Text);
                }
                if (rbSupEgal.Checked)
                {
                    ((DataView)grdClient.DataSource).RowFilter = Tools.EFFECTIF + " >= " + Decimal.Parse(txtSearchClient.Text);
                }
            }
        }

        /// <summary>
        /// Double click on the gridDataView
        /// <para>Check first that the client isn't null and isGridHitNoWhere isn't true</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_DoubleClick(object sender, MouseEventArgs e)
        {
            if (client != null && !isGridHitNoWhere)
            {
                if (!tabControlClients.displayTab(client))
                {
                    tabControlClients.addTab(detailClient(client));
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            newClient();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btnSupprimer_Click(sender, e);
        }

    }
}
