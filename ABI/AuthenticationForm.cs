using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ABIDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from AbiUser where username='" + txtLogin.Text + "', and password = '" + txtPassword.Text + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            Int32 count = 0;
            while (dr.Read())
            {
                count += 1;
            }

            if(count == 1)
            {
                MessageBox.Show("OK");
                frmMdiParent f = new frmMdiParent();
                f.Show();
            }
            else if(count > 0)
            {
                MessageBox.Show("Duplicate username and password ");
            }
            else
            {
                MessageBox.Show("username or password wrong");
            }
        }
    }
}
