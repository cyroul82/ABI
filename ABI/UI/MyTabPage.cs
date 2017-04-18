using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI.UI
{
    public class MyTabPage : TabPage
    {
        private frmDspClient fdc;
        public MyTabPage(frmDspClient fdc): base(fdc.Client.raisonSocial.ToUpper().Trim())
        {
            this.fdc = fdc;
            this.Controls.Add(fdc);
        }

        public frmDspClient Fdc
        {
            get
            {
                return fdc;
            }

            set
            {
                fdc = value;
            }
        }
    }
}
