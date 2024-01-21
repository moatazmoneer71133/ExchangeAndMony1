using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using ExchangeAndMony.pages.accountsInterface.accountsInitializatuionInterface;


namespace ExchangeAndMony
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new ReceiptVoucherClients());
           //Application.Run(new Form1());
            
            Application.Run(new AccountsGuide());
        }
    }
}
