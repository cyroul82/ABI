﻿using System;
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
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.ShowDialog();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            frmDspClient fdc = new frmDspClient();
            FormMain fm = this.MdiParent as FormMain;
            if(fm != null)
            {
                fdc.MdiParent = fm;
                fdc.Show();
            }
            
        }
    }
}
