using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI.UI
{
    public class MyTabControl : TabControl
    {
        private Dictionary<Int32, MyTabPage> openedTabs = new Dictionary<Int32, MyTabPage>();
       
        /// <summary>
        /// Remove the tab from the tabControl 
        /// <para>Check whether the tab is already opened</para>
        /// </summary>
        public void removeTab(ClientDB client)
        {
            if (openedTabs.ContainsKey(client.idClient))
            {
                MyTabPage tabPage = (MyTabPage)openedTabs[client.idClient];
                if (tabPage != null)
                {
                    this.TabPages.Remove(tabPage);
                    openedTabs.Remove(client.idClient);
                }
            }
        }

        public void updateTab(ClientDB client)
        {
            if (openedTabs.ContainsKey(client.idClient))
            {
                MyTabPage tabPage = openedTabs[client.idClient];
                tabPage.Text = client.raisonSocial;
            }
        }

        public Boolean displayTab(ClientDB client)
        {
            Boolean tabExist = false;

            if (openedTabs.ContainsKey(client.idClient))
            {
                MyTabPage tabPage = (MyTabPage)openedTabs[client.idClient];
                this.SelectTab(tabPage);
                tabExist = true;
            }
            else tabExist = false;

            return tabExist;
        }

        /// <summary>
        /// Add a client to the TabControl, check whether the form display Client isn't already opened 
        /// </summary>
        /// <param name="client">Used to link the tab with the client</param>
        public void addTab(frmDspClient fdc)
        {
            MyTabPage tabPage = new MyTabPage(fdc);
            //Add the tab to the tab control
            this.Controls.Add(tabPage);
            //Set the actual display
            this.SelectTab(tabPage);
            openedTabs.Add(fdc.Client.idClient, tabPage);
        }

        public void closeTabs()
        {
            for (Int32 i = 0; i < openedTabs.Count; i++)
            {
                KeyValuePair<Int32, MyTabPage> kvp = openedTabs.ElementAt(i);
                this.TabPages.Remove(kvp.Value);
            }
            openedTabs.Clear();
        }
    }
}
