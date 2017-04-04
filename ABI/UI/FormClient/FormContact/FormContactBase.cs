using ABI.ClasseMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public delegate void ContactHandler(Contact contact);
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void txtContactTelephone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        } 

        public Boolean isNameValid()
        {
            if (txtContactName.Text.Trim() != "") return true;
            else return false;
        }
    }
}
