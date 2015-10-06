using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Model;
using GestionnaireLivre.Model.DataObject;

namespace GestionnaireLivre
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


            BookSeachService BookSService = new BookSeachService("gestionnaireBD", "AIzaSyAKEJaaZvVIMzPCOxqScfyP5UKcrtpjS4c");
            DataBaseService DBService = new DataBaseService();
           
            
            // DBService.loginID = DBService.CheckLogInCredentials("test", "test");

            Application.Run(new LoginForm(DBService));

         
            if(DBService.loginID != -1)
            {
                Application.Run(new MainWindow(DBService,BookSService));
            }         
        }



    }
}
