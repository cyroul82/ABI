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
        private DataTable dt;
        public frmClient()
        {
            InitializeComponent();
            Donnees.listClient.Add(new Client(256, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "oui mais non", "0645248403"));
            Donnees.listClient.Add(new Client(145, "Made in Mode", "Prvié", "Agro", "Principale", 5, 1500, /*new Adresse("verdun", "83700", "st raph"),*/ "alors bon", "5646897453"));
            Donnees.listClient.Add(new Client(659, "Milk Import", "Public", "Industrie", "Secondaire", 3, 56800, /*new Adresse("verdun", "83700", "st raph"),*/ "oki doki", "45678564"));
            Donnees.listClient.Add(new Client(859, "Agro SARL", "Privé", "Agro", "Ancienne", 3, 145870, /*new Adresse("verdun", "83700", "st raph"),*/ "c parti", "21456731"));
            Donnees.listClient.Add(new Client(487, "CALM", "Public", "Industrie", "Secondaire", 3, 12365, /*new Adresse("verdun", "83700", "st raph"),*/ "comment ca", "54564654"));
        }


        private void loadListClient()
        {
            dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("id Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison Social", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Activite", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("CA", typeof(System.Decimal)));
            //dt.Columns.Add(new DataColumn("Adresse", typeof(Adresse)));
            dt.Columns.Add(new DataColumn("Téléphone", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Commentaire", typeof(System.String)));


            for (Int32 i = 0; i < Donnees.listClient.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = Donnees.listClient[i].IdClient;
                dr[1] = Donnees.listClient[i].RaisonSocial;
                dr[2] = Donnees.listClient[i].TypeSociete;
                dr[3] = Donnees.listClient[i].Activite;
                dr[4] = Donnees.listClient[i].Nature;
                dr[5] = Donnees.listClient[i].Effectifs;
                dr[6] = Donnees.listClient[i].ChiffreAffaires;
                //dr[7] = Donnees.listClient[i].Adresse;
                dr[7] = Donnees.listClient[i].Telephone;
                dr[8] = Donnees.listClient[i].Comment;
                dt.Rows.Add(dr);
                
            }
            grdClient.DataSource = dt.DefaultView;

            grdClient.Columns[0].Visible = false;
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            DialogResult result = fnc.ShowDialog();
            if(result == DialogResult.OK)
            {
                loadListClient();
            }
            if(result == DialogResult.Yes)
            {
                loadListClient();
                client = fnc.ClientCreated;
                displayClientTab();
            }
            
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                displayClientTab();
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
                displayClientTab();
            }
        }

        private Boolean isTabOpen()
        {
            Boolean isOpen = false;
            for (Int32 i = 0; i < tabControlClientDetail.TabCount; i++)
            {
                if (tabControlClientDetail.TabPages[i].Text == client.RaisonSocial)
                {
                    isOpen = true;
                }

            }

            return isOpen;
        }

        private void removeTab(TabPage tabPage)
        {
            tabControlClientDetail.TabPages.Remove(tabPage);
        }

        private TabPage findTab()
        {
            TabPage tabPage = null;
            for (Int32 i = 0; i < tabControlClientDetail.TabCount; i++)
            {
                
                if (tabControlClientDetail.TabPages[i].Text == client.RaisonSocial)
                {
                    tabPage = tabControlClientDetail.TabPages[i];
                }

            }
            return tabPage;
        }

        private void displayClientTab()
        {
            bool b = true;
            for(Int32 i=0; i <tabControlClientDetail.TabCount; i++)
            {
                TabPage t = tabControlClientDetail.TabPages[i];
                if(t.Text == client.RaisonSocial)
                {
                    tabControlClientDetail.SelectTab(t);
                    b = false;
                }
                
            }

            if (b)
            {
                frmDspClient fdc = new frmDspClient(client);
                fdc.FormClosing += new FormClosingEventHandler(this.displayForm_Closing);
                fdc.TopLevel = false;
                fdc.Dock = DockStyle.Fill;


                TabPage tabPage1 = new TabPage(client.RaisonSocial);
                tabPage1.Controls.Add(fdc);
                tabControlClientDetail.Controls.Add(tabPage1);
                tabControlClientDetail.SelectTab(tabPage1);
                fdc.Show();
            }
        }

        private void displayForm_Closing(object sender, FormClosingEventArgs e)
        {
            frmDspClient f = sender as frmDspClient;
            if(f != null)
            {
                TabPage tabPage = findTab();
                if (tabPage != null)
                {
                    removeTab(tabPage);
                }
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous supprimer le client " + client.RaisonSocial, "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TabPage tabPage = findTab();
                if(tabPage != null)
                {
                    removeTab(tabPage);
                }
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
    }
}
