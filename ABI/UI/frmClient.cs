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
    public partial class frmClient : Form
    {
        private Client client;
        private DataTable table;
        private DataColumn column;
        private DataRow row;
        private Dictionary<Client, TabPage> tabPageDictionnary = new Dictionary<Client, TabPage>();
        private const String IDCLIENT = "id Client";
        private const String RAISONSOCIALE = "Raison Sociale";
        private const String TYPE = "Type";
        private const String ACTIVITE = "Activité";
        private const String NATURE = "Nature";
        private const String EFFECTIF = "Effectif";
        private const String CHIFFREAFFAIRES = "Chiffre d'affaires";
        private const String VILLE = "Ville";
        private const String TELEPHONE = "Téléphone";
        private const String COMMENTAIRE = "Commentaires";

        public frmClient()
        {
            InitializeComponent();
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, new Adresse("verdun", "83700", "st raph"), "oui mais non", "0645248403"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Made in Mode", "Prvié", "Agro", "Principale", 5, 1500, new Adresse("verdun", "83700", "st raph"), "alors bon", "5646897453"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Milk Import", "Public", "Industrie", "Secondaire", 3, 56800, new Adresse("verdun", "83700", "st raph"), "oki doki", "45678564"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "Agro SARL", "Privé", "Agro", "Ancienne", 3, 145870, new Adresse("verdun", "83700", "st raph"), "c parti", "21456731"));
            Donnees.listClient.Add(new Client(Donnees.clientNumber++, "CALM", "Public", "Industrie", "Secondaire", 3, 12365, new Adresse("verdun", "83700", "st raph"), "comment ca", "54564654"));
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
        }

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

        private void buildTableColumn()
        {
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = IDCLIENT;
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = RAISONSOCIALE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = TYPE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = ACTIVITE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = NATURE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = EFFECTIF;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Decimal);
            column.ColumnName = CHIFFREAFFAIRES;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = VILLE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = TELEPHONE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = COMMENTAIRE;
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);
        }

        private void addClientToTable(Client client)
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

        private void updateClientToTable(Client client)
        {
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.saveNewClient += new SaveNewClient(this.saveNewClient);
            DialogResult result = fnc.ShowDialog();
            if(result == DialogResult.OK || result == DialogResult.Yes)
            {
                //loadListClient();
                if(result == DialogResult.Yes)
                {
                    AddClientTab(client);
                }                
            }         
        }

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

        private void grdClient_MouseClick(object sender, MouseEventArgs e)
        {
    
        }

        private void grdClient_DoubleClick(object sender, EventArgs e)
        {
            if (client != null)
            {
                AddClientTab(client);
            }
        }

        private void removeTab()
        {
            TabPage tabPage = tabPageDictionnary[client];
            if (tabPage != null)
            {
                tabControlClientDetail.TabPages.Remove(tabPage);
                tabPageDictionnary.Remove(client);
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
                fdc.Show();
            }
        }

        private void updatedClient(Client client)
        {
            this.client = client;
            updateClientToTable(client);
        }

        private void displayForm_Closing(object sender, FormClosingEventArgs e)
        {
            frmDspClient f = sender as frmDspClient;
            if(f != null)
            {
                removeTab();
            }
        }

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
            TabPage tabPage = tabControlClientDetail.TabPages[tabControlClientDetail.SelectedIndex];
            foreach(KeyValuePair<Client, TabPage> kvp in tabPageDictionnary)
            {
                if(kvp.Value == tabPage)
                {
                    client = kvp.Key;
                }
            }
            
        }
    }
}
