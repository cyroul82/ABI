using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private TabPage tabPage;
        private frmDspClient formClient;
        private DataTable table;
        private DataColumn column;
        private DataRow row;
        private String searchCriteria;
        //Variable used to control the click on the dataGridView, within itself = false, outside the dataGridView = true
        private Boolean isHitGridNoWhere = false;

        //Dictionnary to keep the reference of the TabPage opened associated with a client as Key
        private Dictionary<ClientDB, TabPage> tabPageDictionnary = new Dictionary<ClientDB, TabPage>();
        //Dictionnary to keep the reference of the frmDspClient created associated with a tabPage as Key
        private Dictionary<TabPage, frmDspClient> frmDspClientDictionnary = new Dictionary<TabPage, frmDspClient>();

        /// <summary>
        /// Constructor with no arguments
        /// </summary>
        public frmListClt()
        {
            InitializeComponent();
            txtSearchClient.Select();
        }

        /// <summary>
        /// Call to initialize the Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
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
        }
        /// <summary>
        /// Loads the list of client form Donnee.listClient and styles the dataGridView grdClient
        /// </summary>
        private void loadListClient()
        {
            table = new DataTable();
            
            buildTableColumn();

            for (Int32 i = 0; i < Data.db.ClientDB.ToList().Count; i++)
            {
                addClientDataTable(Data.db.ClientDB.ToList()[i]);
                
            }
            grdClient.DataSource = table.DefaultView;

            grdClient.Columns[Tools.IDCLIENT].Visible = false;

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
            grdClient.Columns[Tools.RAISONSOCIALE].DefaultCellStyle = raisonSocialStyle;

            DataGridViewCellStyle idClient = new DataGridViewCellStyle();
            idClient.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdClient.Columns[Tools.IDCLIENT].DefaultCellStyle = idClient;
        }

        /// <summary>
        /// Build the Table Column with DataColumn
        /// </summary>
        private void buildTableColumn()
        {
            //Column IDCLIENT Unique and ReadOnly
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.IDCLIENT;
            column.ReadOnly = true;
            column.Unique = true;
            column.AutoIncrement = true;
            table.Columns.Add(column);

            //Column RAISON SOCIALE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.RAISONSOCIALE;
            column.ReadOnly = false;
            column.Unique = true;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column FONCTION
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.TYPE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column EMAIL
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.ACTIVITE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.NATURE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column EFFECTIF
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = Tools.EFFECTIF;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column CHIFFRE AFFAIRES
            column = new DataColumn();
            column.DataType = typeof(System.Decimal);
            column.ColumnName = Tools.CHIFFREAFFAIRES;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column VILLE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.VILLE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.TELEPHONE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column COMMENTAIRES
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = Tools.COMMENTAIRE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);
        }

        /// <summary>
        /// Add a Client
        /// </summary>
        /// <param name="client"></param>
        private void addClientDataTable(ClientDB client)
        {
            this.client = client;
            try
            {
                row = table.NewRow();
                row[Tools.IDCLIENT] = client.idClient;
                row[Tools.RAISONSOCIALE] = client.raisonSocial;
                row[Tools.TYPE] = client.type;
                row[Tools.ACTIVITE] = client.activite;
                row[Tools.NATURE] = client.nature;
                row[Tools.EFFECTIF] = client.effectifs.ToString();
                row[Tools.CHIFFREAFFAIRES] = client.ca.ToString();
                row[Tools.VILLE] = client.ville;
                row[Tools.TELEPHONE] = client.telephone;
                row[Tools.COMMENTAIRE] = client.comment;
                table.Rows.Add(row);
                
            }
            catch (ConstraintException e)
            {
                MessageBox.Show("Impossible d'ajouter ce client : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Update a Client
        /// </summary>
        /// <param name="client"></param>
        private void updateClientDataTable(ClientDB client)
        {
            this.client = client;
            //Update tabPage.Text
            if (tabPageDictionnary.ContainsKey(client))
            {
                TabPage tabPage = tabPageDictionnary[client];
                tabPage.Text = client.raisonSocial;
            }

            //Update the listClient in DataView
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if (idClient == client.idClient)
                {
                    table.Rows[i][Tools.RAISONSOCIALE] = client.raisonSocial;
                    table.Rows[i][Tools.TYPE] = client.type;
                    table.Rows[i][Tools.ACTIVITE] = client.activite;
                    table.Rows[i][Tools.NATURE] = client.nature;
                    table.Rows[i][Tools.EFFECTIF] = client.effectifs.ToString();
                    table.Rows[i][Tools.CHIFFREAFFAIRES] = client.ca.ToString();
                    table.Rows[i][Tools.VILLE] = client.ville;
                    table.Rows[i][Tools.TELEPHONE] = client.telephone;
                    table.Rows[i][Tools.COMMENTAIRE] = client.comment;
                }
            }
        }

        private void deletingClient(ClientDB client)
        {
            removeTab();
            foreach (DataGridViewRow row in grdClient.SelectedRows)
            {
                Int32 id = (Int32)row.Cells[0].Value;

                foreach (ClientDB c in Data.db.ClientDB.ToList())
                {
                    if (c.idClient == id)
                    {
                        client = c;
                        if(client.ContactDB.Count > 0)
                        {
                            DialogResult result = MessageBox.Show("La suppression de " +client.raisonSocial + 
                                                                " entraîne la suppression de tous ses contacts \n" +
                                                                "voulez-vous continuer ?", "Supprimer Contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if(result == DialogResult.Yes)
                            {
                                for(Int32 j = 0; j<client.ContactDB.Count; j++)
                                {
                                    Data.db.ContactDB.Remove(client.ContactDB.ElementAt(j));
                                }
                                removeClientFromDbAndSaveChanges(client);
                            }
                        }
                        else
                        {
                            removeClientFromDbAndSaveChanges(client);
                        }
                        
                    }
                }
            }
        }

        private void removeClientFromDbAndSaveChanges(ClientDB client)
        {
            Data.db.ClientDB.Remove(client);
            Data.db.SaveChanges();

            //Remove the row 
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if (idClient == client.idClient)
                {
                    table.Rows[i].Delete();
                }
            }
            client = null;
        }


        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            if (grdClient.CurrentRow != null)
            {
                Int32 id = (Int32)grdClient.CurrentRow.Cells[0].Value;

                client = Data.db.ClientDB.Find(id);
            }
            else
            {
                client = null;
            }
        }

        /// <summary>
        /// Double click on the gridDataView
        /// <para>Check first that the client isn't null and isHitGridNoWhere isn't true</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            if (client != null && !isHitGridNoWhere)
            {
                addClientTab(client);
            }
        }

        /// <summary>
        /// Check whether a click is within the dataGridView or outside
        /// <para>If outside, the variable isHitGridNoWhere = true</para>
        /// <para>If inside, the variable isHitGridNoWhere = false</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdClient_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (grdClient.HitTest(e.X, e.Y) == HitTestInfo.Nowhere)
                {
                    isHitGridNoWhere = true;
                }
                else isHitGridNoWhere = false;
            }
        }


        ///////////////////////////////////////////////////TabControl
        /// <summary>
        /// Add a client to the TabControl, check whether the form display Client isn't already opened 
        /// </summary>
        /// <param name="client">Used to link the tab with the client</param>
        private void addClientTab(ClientDB client)
        {
            if (client != null)
            {
                this.client = client;
                //If the client already opened then display it in the TabControl
                if (tabPageDictionnary.ContainsKey(client))
                {
                    TabPage tabPage = tabPageDictionnary[client];
                    tabControlClients.SelectTab(tabPage);
                    
                }
                //If the client isn't open yet, create the form frmDspClient with the client and display the tab
                else
                {
                    frmDspClient fdc = new frmDspClient(client);
                    fdc.FormClosing += new FormClosingEventHandler(this.displayForm_Closing);
                    fdc.UpdatingClient += new ClientHandler(this.updateClientDataTable);
                    fdc.DeletingClient += new ClientHandler(this.deletingClient);
                    fdc.TopLevel = false;
                    fdc.Dock = DockStyle.Fill;

                    TabPage tabPage = new TabPage(client.raisonSocial);
                    tabPage.Controls.Add(fdc);
                    //Add the tab to the tab control
                    tabControlClients.Controls.Add(tabPage);
                    //Set the actual display
                    tabControlClients.SelectTab(tabPage);
                    //Add the tab to the dictionnary
                    tabPageDictionnary.Add(client, tabPage);
                    //Add the form to the dictionnary
                    frmDspClientDictionnary.Add(tabPage, fdc);
                    fdc.Show();
                }
            }
        }
        /// <summary>
        /// Remove the tab from the tabControl
        /// <para>Check whether the tab is already opened</para>
        /// </summary>
        private void removeTab()
        {
            if (tabPageDictionnary.ContainsKey(client))
            {
                TabPage tabPage = tabPageDictionnary[client];
                if (tabPage != null)
                {
                    //Remove the tab from the tab Control
                    tabControlClients.TabPages.Remove(tabPage);
                    //Remove the tab from the dictionnary
                    tabPageDictionnary.Remove(client);
                    //Remove the form from the dictionnary
                    frmDspClientDictionnary.Remove(tabPage);
                    //Display the ListClient tab (Main tab)
                    tabControlClients.SelectTab(0);
                }
            }
        }
        /// <summary>
        /// Called when the frmDspClient is closing and close the tab if opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayForm_Closing(object sender, FormClosingEventArgs e)
        {
            frmDspClient f = sender as frmDspClient;
            if (f != null)
            {
                removeTab();
            }
        }
        /// <summary>
        /// Everytime the tabControl index changes, the client gets a new value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlClientDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClients.TabCount > 0)
            {
                //if the ListClient tab is selected
                if (tabControlClients.SelectedIndex == 0)
                {
                    //The client takes the value of the datagridview selection
                    grdClient_SelectionChanged(sender, e);
                }
                else
                {
                    //Get the tabpage selected 
                    tabPage = tabControlClients.TabPages[tabControlClients.SelectedIndex];

                    //find the reference in the dictionnary to get the client
                    foreach (KeyValuePair<ClientDB, TabPage> kvp in tabPageDictionnary)
                    {
                        if (kvp.Value == tabPage)
                        {
                            client = kvp.Key;
                        }
                    }

                    //find the reference in dictionnary to get the frmDspClient
                    if (frmDspClientDictionnary.ContainsKey(tabPage))
                    {
                        formClient = frmDspClientDictionnary[tabPage];
                    }
                }
            }
        }
        ///////////////////////////////////////////////////End TabControl





        ///////////////////////////////////////////////////Button Click Left Panel

        /// <summary>
        /// Open a new frmNewClient Dialog and register an event when saving the client 
        /// <para>Add a tab with the new client upon creation</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.saveNewClient += new SaveNewClient(this.addClient);
            fnc.saveAndOpenClient += new SaveNewClient(this.addClientAndOpen);
            DialogResult result = fnc.ShowDialog();
            
        }

        private void addClientAndOpen(ClientDB client)
        {
            addClientTab(client);
            addClient(client);
            
        }
        private void addClient(ClientDB client)
        {
            addClientDataTable(client);
            grdClient.Rows[grdClient.Rows.Count-1].Selected = true;
            
        }
        /// <summary>
        /// Delete a client upon confirmation calls the method deletingClient(Client client)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                DialogResult result = MessageBox.Show("Voulez-vous supprimer le client " + client.raisonSocial, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    deletingClient(client);

                    if(grdClient.Rows.Count > 0){
                        grdClient.Rows[0].Selected = true;
                    }
                    else
                    {
                        client = null;
                    }
                }
            }
        }
        /// <summary>
        /// Add a client the tab, calls the method addClientTab(Client client)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                addClientTab(client);
            }
            
        }
        /// <summary>
        /// Allow to close all opened tabs and come back to the first tab ListClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermerOnglets_Click(object sender, EventArgs e)
        {
            for(Int32 i=0; i<tabPageDictionnary.Count; i++)
            {
                KeyValuePair<ClientDB ,TabPage> k = tabPageDictionnary.ElementAt(i);
                tabControlClients.TabPages.Remove(k.Value);

                frmDspClient f = frmDspClientDictionnary[k.Value] as frmDspClient;
                if (f != null)
                {
                    //if (f.IsModifed)
                    //{
                    //    tabControlClientDetail.SelectTab(k.Value);
                    //}
                }
            }
            frmDspClientDictionnary.Clear(); ;
            tabPageDictionnary.Clear();
        }
        /// <summary>
        /// Close the ListClient Tab of the application
        /// <para>clear all dictionnary, </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment fermer la partie Commerciale ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                btnFermerOnglets_Click(sender, e);
                frmDspClientDictionnary.Clear();
                tabControlClients.TabPages.Clear();
                tabPageDictionnary.Clear();

                Close();
            }
        }
        //////////////////////////////////////////////////End Button Click Left Panel




        //TODO to implement sometimes the right click on the tabs , not finished !  
        /////////////////////////////////////////////////Right Click Tab (Contextuel Menu)
        private void tabControlClientDetail_MouseUp(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Right)
            //{
            //    for (Int32 i = 0; i < tabControlClientDetail.TabCount; i++)
            //    {
            //        // get their rectangle area and check if it contains the mouse cursor
            //        Rectangle r = tabControlClientDetail.GetTabRect(i);

            //        if (r.Contains(e.Location))
            //        {
            //            // show the context menu here
            //            tabControlClientDetail.SelectTab(i);
            //            contextMenuStripTab.Show(Cursor.Position.X, Cursor.Position.Y);
            //        }
            //    }
            //}
        }
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.removeTab();
        }
        private void fermerTousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFermerOnglets_Click(sender, e);
        }
        ////////////////////////////////////////////////End Right Click Tab 






        ////////////////////////////////////////////////Search Panel Button & Textbox Click 

        /// <summary>
        /// Display the complete list clients upon the button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToutAfficher_Click(object sender, EventArgs e)
        {
            txtSearchClient.Text = null;
            ((DataView)grdClient.DataSource).RowFilter = null;
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
                    addClientTab(client);
                }
            }
            //if raisonsociale is selected, filter the list by raison sociale
            else if (txtSearchClient.Text != null && searchCriteria == Tools.RAISONSOCIALE)
            {
                ((DataView)grdClient.DataSource).RowFilter = "RaisonSociale like '%" + txtSearchClient.Text + "%'";
            }
            //if raisonsociale is selected, filter the list by ville
            else if (txtSearchClient.Text != null && searchCriteria == Tools.VILLE)
            {
                ((DataView)grdClient.DataSource).RowFilter = "Ville like '%" + txtSearchClient.Text + "%'";
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
                    ((DataView)grdClient.DataSource).RowFilter = Tools.CHIFFREAFFAIRES + " = " + Decimal.Parse(txtSearchClient.Text);
                }
                if (rbInfEgal.Checked)
                {
                    ((DataView)grdClient.DataSource).RowFilter = Tools.CHIFFREAFFAIRES + " <= " + Decimal.Parse(txtSearchClient.Text) ;
                }
                if (rbSupEgal.Checked)
                {
                    ((DataView)grdClient.DataSource).RowFilter = Tools.CHIFFREAFFAIRES + " >= " + Decimal.Parse(txtSearchClient.Text);
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

        ////////////////////////////////////////////////End Search Panel Button & Textbox Click
    }
}
