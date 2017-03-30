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
            Donnees.listClient.Add(new Client(256, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "comment", "0645248403"));
            Donnees.listClient.Add(new Client(256, "Made in Mode", "Public", "Agro", "Principale", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "comment", "0645248403"));
            Donnees.listClient.Add(new Client(256, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "comment", "0645248403"));
            Donnees.listClient.Add(new Client(256, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "comment", "0645248403"));
            Donnees.listClient.Add(new Client(256, "AGM", "Public", "Industrie", "Secondaire", 3, 1000, /*new Adresse("verdun", "83700", "st raph"),*/ "comment", "0645248403"));
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
            if(fnc.ShowDialog() == DialogResult.OK)
            {
                loadListClient();
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                frmDspClient fdc = new frmDspClient();
                fdc.Dock = DockStyle.Fill;
                fdc.TopLevel = false;
                TabPage tp = new TabPage(client.RaisonSocial);
                tp.Controls.Add(fdc);
                tabControlClientDetail.Controls.Add(tp);
                fdc.Show();
            }
            else
            {
                MessageBox.Show("Selectionner un client", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            //Int32 index = grdClient.CurrentRow.Index;
            //if(index != -1)
            //{
            //    DataGridViewRow row = grdClient.SelectedRows[index-1];
            //    Client c = row.DataBoundItem as Client;
            //    if (c != null)
            //    {
            //        c = client;
            //    }
            //}
        }

        private void grdClient_MouseClick(object sender, MouseEventArgs e)
        {
    
        }

        private void grdClient_DoubleClick(object sender, EventArgs e)
        {


            Int32 index = grdClient.CurrentRow.Index;
            if (index != -1)
            {

                Int32 id = (Int32)dt.Rows[index].Field<Int32>("id Client");
                foreach(Client c in Donnees.listClient)
                {
                    if (c.IdClient == id)
                    {
                        client = c;
                    }
                }

                if (client != null)
                {
                    TabPage tabPage1 = new TabPage(client.RaisonSocial);
                    tabControlClientDetail.Controls.Add(tabPage1);
                    client = null;
                }
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            loadListClient();
        }
    }
}
