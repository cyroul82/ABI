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
    public partial class frmCommercial : Form
    {
        private Client client;
        private TabPage tabPage;
        private frmDspClient formClient;
        private DataTable table;
        private DataColumn column;
        private DataRow row;
        //Variable used to control the click on the dataGridView, within itself = false, outside the dataGridView = true
        private Boolean isHitGridNoWhere = false;

        //Dictionnary to keep a track of the TabPage opened associated with a client as Key
        private Dictionary<Client, TabPage> tabPageDictionnary = new Dictionary<Client, TabPage>();
        private Dictionary<TabPage, frmDspClient> frmDspClientDictionnary = new Dictionary<TabPage, frmDspClient>();

        /// <summary>
        /// Constructor with no argument
        /// </summary>
        public frmCommercial()
        {
            InitializeComponent();
            txtSearchClient.Select();
            Data.listClient.Add(new Client(++Data.clientNumber, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, new Adresse("verdun", "83700", "st raph"), "oui mais non", "0645248403"));
            Data.listClient.Add(new Client(++Data.clientNumber, "Made in Mode", "Privé", "Agro", "Principale", 5, 1500, new Adresse("verdun", "83700", "st raph"), "alors bon", "5646897453"));
            Data.listClient.Add(new Client(++Data.clientNumber, "Milk Import", "Public", "Industrie", "Secondaire", 3, 56800, new Adresse("verdun", "83700", "st raph"), "oki doki", "45678564"));
            Data.listClient.Add(new Client(++Data.clientNumber, "Agro SARL", "Privé", "Agro", "Ancienne", 3, 145870, new Adresse("verdun", "83700", "st raph"), "c parti", "21456731"));
            Data.listClient.Add(new Client(++Data.clientNumber, "CALM", "Public", "Industrie", "Secondaire", 3, 12365, new Adresse("verdun", "83700", "st raph"), "comment ca", "54564654"));
        }

        /// <summary>
        /// Call to initialize the Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
            //cbxSeach.Items.Add(Tools.)
        }
        /// <summary>
        /// Loads the list of client form Donnee.listClient and styles the dataGridView grdClient
        /// </summary>
        private void loadListClient()
        {
            table = new DataTable();
            column = new DataColumn();
            buildTableColumn();

            for (Int32 i = 0; i < Data.listClient.Count; i++)
            {
                addClientDataTable(Data.listClient[i]);
                
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
        private void addClientDataTable(Client client)
        {
            this.client = client;
            try
            {
                row = table.NewRow();
                row[Tools.IDCLIENT] = client.IdClient;
                row[Tools.RAISONSOCIALE] = client.RaisonSocial;
                row[Tools.TYPE] = client.TypeSociete;
                row[Tools.ACTIVITE] = client.Activite;
                row[Tools.NATURE] = client.Nature;
                row[Tools.EFFECTIF] = client.Effectifs.ToString();
                row[Tools.CHIFFREAFFAIRES] = client.ChiffreAffaires.ToString();
                row[Tools.VILLE] = client.Adresse.Ville;
                row[Tools.TELEPHONE] = client.Telephone;
                row[Tools.COMMENTAIRE] = client.Comment;
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
        private void updateClientDataTable(Client client)
        {
            this.client = client;
            //Update tabPage.Text
            if (tabPageDictionnary.ContainsKey(client))
            {
                TabPage tabPage = tabPageDictionnary[client];
                tabPage.Text = client.RaisonSocial;
            }

            //Update the listClient in DataView
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if (idClient == client.IdClient)
                {
                    table.Rows[i][Tools.RAISONSOCIALE] = client.RaisonSocial;
                    table.Rows[i][Tools.TYPE] = client.TypeSociete;
                    table.Rows[i][Tools.ACTIVITE] = client.Activite;
                    table.Rows[i][Tools.NATURE] = client.Nature;
                    table.Rows[i][Tools.EFFECTIF] = client.Effectifs.ToString();
                    table.Rows[i][Tools.CHIFFREAFFAIRES] = client.ChiffreAffaires.ToString();
                    table.Rows[i][Tools.VILLE] = client.Adresse.Ville;
                    table.Rows[i][Tools.TELEPHONE] = client.Telephone;
                    table.Rows[i][Tools.COMMENTAIRE] = client.Comment;
                }
            }
        }

        private void deletingClient(Client client)
        {
            removeTab();
            foreach (DataGridViewRow row in grdClient.SelectedRows)
            {
                Int32 id = (Int32)row.Cells[0].Value;

                foreach (Client c in Data.listClient)
                {
                    if (c.IdClient == id)
                    {
                        client = c;
                    }
                }
            }
            Data.listClient.Remove(client);
            deleteClientDataTable(client);
        }

        private void deleteClientDataTable(Client client)
        {
            for (Int32 i = 0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if (idClient == client.IdClient)
                {
                    table.Rows[i].Delete();
                }
            }
            client = null;
        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdClient.SelectedRows)
            {
                if (row != null)
                {
                    Int32 id = (Int32)row.Cells[0].Value;

                    foreach (Client c in Data.listClient)
                    {
                        if (c.IdClient == id)
                        {
                            client = c;
                            for (int i = 0; i < client.ListContacts.Count ; i++){
                                Console.WriteLine(client.ListContacts[i].ToString());
                            }
                        }
                    }
                }
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
                AddClientTab(client);
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
        private void AddClientTab(Client client)
        {
            if (client != null)
            {
                if (tabPageDictionnary.ContainsKey(client))
                {
                    TabPage tabPage = tabPageDictionnary[client];
                        tabControlClientDetail.SelectTab(tabPage);
                    
                }
                else
                {
                    frmDspClient fdc = new frmDspClient(client);
                    fdc.FormClosing += new FormClosingEventHandler(this.displayForm_Closing);
                    fdc.UpdatingClient += new ClientHandler(this.updateClientDataTable);
                    fdc.DeletingClient += new ClientHandler(this.deletingClient);
                    fdc.TopLevel = false;
                    fdc.Dock = DockStyle.Fill;

                    TabPage tabPage = new TabPage(client.RaisonSocial);
                    tabPage.Controls.Add(fdc);
                    tabControlClientDetail.Controls.Add(tabPage);
                    tabControlClientDetail.SelectTab(tabPage);
                    tabPageDictionnary.Add(client, tabPage);
                    frmDspClientDictionnary.Add(tabPage, fdc);
                    fdc.Show();
                }
            }
        }
        private void removeTab()
        {
            if (tabPageDictionnary.ContainsKey(client))
            {
                TabPage tabPage = tabPageDictionnary[client];
                if (tabPage != null)
                {
                    tabControlClientDetail.TabPages.Remove(tabPage);
                    tabPageDictionnary.Remove(client);
                    frmDspClientDictionnary.Remove(tabPage);
                    tabControlClientDetail.SelectTab(0);
                }
            }
        }
        private void displayForm_Closing(object sender, FormClosingEventArgs e)
        {
            frmDspClient f = sender as frmDspClient;
            if (f != null)
            {
                removeTab();
            }
        }
        private void tabControlClientDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClientDetail.TabCount > 0)
            {
                if (tabControlClientDetail.SelectedIndex == 0)
                {
                    grdClient_SelectionChanged(sender, e);
                }
                else
                {
                    tabPage = tabControlClientDetail.TabPages[tabControlClientDetail.SelectedIndex];

                    foreach (KeyValuePair<Client, TabPage> kvp in tabPageDictionnary)
                    {
                        if (kvp.Value == tabPage)
                        {
                            client = kvp.Key;
                        }
                    }

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
        /// Button Add Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.saveNewClient += new SaveNewClient(this.addClientDataTable);
            DialogResult result = fnc.ShowDialog();
            if (result == DialogResult.Yes)
            {
                AddClientTab(client);
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                DialogResult result = MessageBox.Show("Voulez-vous supprimer le client " + client.RaisonSocial, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    deletingClient(client);
                }
            }
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                AddClientTab(client);
            }
            
        }
        private void btnFermerOnglets_Click(object sender, EventArgs e)
        {
            for(Int32 i=0; i<tabPageDictionnary.Count; i++)
            {
                KeyValuePair<Client,TabPage> k = tabPageDictionnary.ElementAt(i);
                tabControlClientDetail.TabPages.Remove(k.Value);

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
        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment fermer la partie Commerciale ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                btnFermerOnglets_Click(sender, e);
                frmDspClientDictionnary.Clear();
                tabControlClientDetail.TabPages.Clear();
                tabPageDictionnary.Clear();
                Data.listClient.Clear();
                Close();
            }
        }
        //////////////////////////////////////////////////End Button Click Left Panel





        /////////////////////////////////////////////////Right Click Tab
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
        ////////////////////////////////////////////////End Right Click Tab (Contextuel Menu)






        ////////////////////////////////////////////////Search Panel Button & Textbox Click 
        private void btnSearchClient_Click(object sender, EventArgs e)
        {
           if(client != null)
            {
                AddClientTab(client);
            }
        }

        private void btnToutAfficher_Click(object sender, EventArgs e)
        {
            txtSearchClient.Text = null;
            ((DataView)grdClient.DataSource).RowFilter = null;
        }

        private void txtSearchClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearchClient.Text != String.Empty)
            {
                if (client != null)
                {
                    AddClientTab(client);
                }
            }
            else if (txtSearchClient.Text != null)
            {
                ((DataView)grdClient.DataSource).RowFilter = "RaisonSociale like '%" + txtSearchClient.Text + "%'";
            }
        }

        ////////////////////////////////////////////////End Search Panel Button & Textbox Click
    }
}
