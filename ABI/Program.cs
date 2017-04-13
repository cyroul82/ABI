using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            //ClientDB client = Data.db.ClientDB.Include("ContactDB").First(c => c.idClient == 7);
            //client.raisonSocial = "TOTO";
            Data.db.SaveChanges();
            //Console.WriteLine("Client 7 : " + client.raisonSocial) ;
            
        }
    }
}
