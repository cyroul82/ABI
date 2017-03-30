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
        public frmClient()
        {
            InitializeComponent();
            Client c = new Client("agmelec", "sarl", "elec", "ar", 3, 1000, new Adresse("rue", "83700", "Saint Raphael"), "comments");
            Donnees.listClient.Add(c);
            loadListClient();
        }

        private void loadListClient()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("id Client", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison Social", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Activite", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("CA", typeof(System.Decimal)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(Adresse)));
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
                dr[7] = Donnees.listClient[i].Adresse;
                dr[8] = Donnees.listClient[i].Comment;
                dt.Rows.Add(dr);
            }
            grdClient.DataSource = dt;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.ShowDialog();
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
    }
}
