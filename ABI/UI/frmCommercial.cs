using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Dictionnary to keep a track of the TabPage opened associated with a client as Key
        private Dictionary<Client, TabPage> tabPageDictionnary = new Dictionary<Client, TabPage>();
        private Dictionary<TabPage, frmDspClient> frmDspClientDictionnary = new Dictionary<TabPage, frmDspClient>();

        //Declare all the constants for the columns (gridDataView)
        private const String IDCLIENT = "idClient";
        private const String RAISONSOCIALE = "RaisonSociale";
        private const String RAISONSOCIALE_CAPTION = "Raison Sociale";
        private const String TYPE = "Type";
        private const String ACTIVITE = "Activite";
        private const String NATURE = "Nature";
        private const String EFFECTIF = "Effectif";
        private const String CHIFFREAFFAIRES = "ChiffreAffaires";
        private const String VILLE = "Ville";
        private const String TELEPHONE = "Telephone";
        private const String TELEPHONE_CAPTION = "Téléphone";
        private const String COMMENTAIRE = "Commentaires";

        /// <summary>
        /// Constructor with no argument
        /// </summary>
        public frmCommercial()
        {
            InitializeComponent();
            txtSearchClient.Select();
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, new Adresse("verdun", "83700", "st raph"), "oui mais non", "0645248403"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Made in Mode", "Privé", "Agro", "Principale", 5, 1500, new Adresse("verdun", "83700", "st raph"), "alors bon", "5646897453"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Milk Import", "Public", "Industrie", "Secondaire", 3, 56800, new Adresse("verdun", "83700", "st raph"), "oki doki", "45678564"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Agro SARL", "Privé", "Agro", "Ancienne", 3, 145870, new Adresse("verdun", "83700", "st raph"), "c parti", "21456731"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "CALM", "Public", "Industrie", "Secondaire", 3, 12365, new Adresse("verdun", "83700", "st raph"), "comment ca", "54564654"));
        }

        /// <summary>
        /// Call to initialize the Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
        }
        /// <summary>
        /// Loads the list of client form Donnee.listClient and styles the dataGridView grdClient
        /// </summary>
        private void loadListClient()
        {
            table = new DataTable();
            column = new DataColumn();
            buildTableColumn();

            for (Int32 i = 0; i < Donnees.listClient.Count; i++)
            {
                addClientToTable(Donnees.listClient[i]);
                
            }
            grdClient.DataSource = table.DefaultView;

            grdClient.Columns[IDCLIENT].Visible = false;

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
            grdClient.Columns[RAISONSOCIALE].DefaultCellStyle = raisonSocialStyle;

            DataGridViewCellStyle idClient = new DataGridViewCellStyle();
            idClient.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdClient.Columns[IDCLIENT].DefaultCellStyle = idClient;
        }

        /// <summary>
        /// Build the Table Column with DataColumn
        /// </summary>
        private void buildTableColumn()
        {
            //Column IDCLIENT Unique and ReadOnly
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = IDCLIENT;
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            //Column RAISON SOCIALE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = RAISONSOCIALE;
            column.Caption = RAISONSOCIALE_CAPTION;
            column.ReadOnly = false;
            column.Unique = true;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column FONCTION
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = TYPE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column EMAIL
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = ACTIVITE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = NATURE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column EFFECTIF
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = EFFECTIF;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column CHIFFRE AFFAIRES
            column = new DataColumn();
            column.DataType = typeof(System.Decimal);
            column.ColumnName = CHIFFREAFFAIRES;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column VILLE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = VILLE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column TELEPHONE
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = TELEPHONE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            //Column COMMENTAIRES
            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = COMMENTAIRE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);
        }

        /// <summary>
        /// Add a Client
        /// </summary>
        /// <param name="client"></param>
        private void addClientToTable(Client client)
        {
            try
            {
                row = table.NewRow();
                row[IDCLIENT] = client.IdClient;
                row[RAISONSOCIALE] = client.RaisonSocial;
                row[TYPE] = client.TypeSociete;
                row[ACTIVITE] = client.Activite;
                row[NATURE] = client.Nature;
                row[EFFECTIF] = client.Effectifs.ToString();
                row[CHIFFREAFFAIRES] = client.ChiffreAffaires.ToString();
                row[VILLE] = client.Adresse.Ville;
                row[TELEPHONE] = client.Telephone;
                row[COMMENTAIRE] = client.Comment;
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
        private void updateClientToTable(Client client)
        {
            //Update tabPage.Text
            foreach(KeyValuePair<Client, TabPage> kvp in tabPageDictionnary)
            {
                if(kvp.Key == client)
                {
                    TabPage tabPage = kvp.Value;
                    tabPage.Text = client.RaisonSocial;
                }
            }
            //Update the listClient in Donnees
            for(Int32 i=0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if(idClient == client.IdClient)
                { 
                    table.Rows[i][RAISONSOCIALE] = client.RaisonSocial;
                    table.Rows[i][TYPE] = client.TypeSociete;
                    table.Rows[i][ACTIVITE] = client.Activite;
                    table.Rows[i][NATURE] = client.Nature;
                    table.Rows[i][EFFECTIF] = client.Effectifs.ToString();
                    table.Rows[i][CHIFFREAFFAIRES] = client.ChiffreAffaires.ToString();
                    table.Rows[i][VILLE] = client.Adresse.Ville;
                    table.Rows[i][TELEPHONE] = client.Telephone;
                    table.Rows[i][COMMENTAIRE] = client.Comment;
                }
            }
        }

        /// <summary>
        /// Button Add Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.saveNewClient += new SaveNewClient(this.saveNewClient);
            DialogResult result = fnc.ShowDialog();
            if (result == DialogResult.Yes)
            {
                AddClientTab(client);
            }
        }

        /// <summary>
        /// Save a new Client
        /// </summary>
        /// <param name="client"></param>
        private void saveNewClient(Client client)
        {
            this.client = client;
            addClientToTable(client);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                AddClientTab(client);
            }
            
        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            setClientFromDataGridView();
        }

        private void setClientFromDataGridView()
        {
            foreach (DataGridViewRow row in grdClient.SelectedRows)
            {
                if (row != null)
                {
                    Int32 id = (Int32)row.Cells[0].Value;

                    foreach (Client c in Donnees.listClient)
                    {
                        if (c.IdClient == id)
                        {
                            client = c;
                        }
                    }
                }
            }
        }

        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            if (client != null)
            {
                AddClientTab(client);
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

        private void AddClientTab(Client client)
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
                fdc.Updated += new UpdatedClientHandler(this.updatedClient);
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

        private void updatedClient(Client client)
        {
            this.client = client;
            updateClientToTable(client);
        }

        /// <summary>
        /// Upon supprimer_click show a dialog to confirm and delete the client from the list, the dataGridView and the tabControl if open 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous supprimer le client " + client.RaisonSocial, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                removeTab();
                foreach (DataGridViewRow row in grdClient.SelectedRows)
                {
                    Int32 id = (Int32)row.Cells[0].Value;

                    foreach (Client c in Donnees.listClient)
                    {
                        if (c.IdClient == id)
                        {
                            client = c;
                        }
                    }
                }
                Donnees.listClient.Remove(client);
                client = null;
                loadListClient();
            }
        }

        private void tabControlClientDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClientDetail.TabCount > 0)
            {
                if (tabControlClientDetail.SelectedIndex == 0)
                {
                    setClientFromDataGridView();
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

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment fermer la partie Commerciale ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                btnFermerOnglets_Click(sender, e);
                frmDspClientDictionnary.Clear();
                tabControlClientDetail.TabPages.Clear();
                tabPageDictionnary.Clear();
                Donnees.listClient.Clear();
                Close();
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

    }
}
