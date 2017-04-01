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

            grdClient.Columns["id Client"].Visible = false;

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
            grdClient.Columns["Raison Social"].DefaultCellStyle = raisonSocialStyle;

            DataGridViewCellStyle idClient = new DataGridViewCellStyle();
            idClient.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdClient.Columns["id Client"].DefaultCellStyle = idClient;
        }

        private void buildTableColumn()
        {
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = "id Client";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Raison Social";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Type";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Activite";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Nature";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = "Effectif";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Decimal);
            column.ColumnName = "CA";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Ville";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Téléphone";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Commentaire";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);
        }

        private void addClientToTable(Client client)
        {
            row = table.NewRow();
            row["id Client"] = client.IdClient;
            row["Raison social"] = client.RaisonSocial;
            row["Type"] = client.TypeSociete;
            row["Activite"] = client.Activite;
            row["Nature"] = client.Nature;
            row["Effectif"] = client.Effectifs.ToString();
            row["CA"] = client.ChiffreAffaires.ToString();
            row["Ville"] = client.Adresse.Ville;
            row["Commentaire"] = client.Comment;
            row["Téléphone"] = client.Telephone;
            table.Rows.Add(row);
        }

        private void updateClientToTable(Client client)
        {
            for(Int32 i=0; i < table.Rows.Count; i++)
            {
                Int32 idClient = (Int32)table.Rows[i][0];
                if(idClient == client.IdClient)
                {

                    table.Rows[i][1] = client.RaisonSocial;
                    table.Rows[i][2] = client.TypeSociete;
                    table.Rows[i][3] = client.Activite;
                    table.Rows[i][4] = client.Nature;
                    table.Rows[i][5] = client.Effectifs.ToString();
                    table.Rows[i][6] = client.ChiffreAffaires.ToString();
                    table.Rows[i][7] = client.Adresse.Ville;
                    table.Rows[i][8] = client.Comment;
                    table.Rows[i][9] = client.Telephone;
                    
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
