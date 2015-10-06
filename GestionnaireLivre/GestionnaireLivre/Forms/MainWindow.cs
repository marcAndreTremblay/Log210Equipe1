using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using GestionnaireLivre.Model.Services;
using MySql.Data.MySqlClient;

using GestionnaireLivre.Forms.MainUserControl;
using GestionnaireLivre.Forms.MainWindowUC;
using GestionnaireLivre.Model.DataObject;

namespace GestionnaireLivre
{
    public partial class MainWindow : Form
    {
        #region ViewVaraible
      
        private Point PanelFunctionLocation = new Point(10, 90);
        private Point MainUCLocation = new Point(180, 90);
        private Size MainUCSize = new Size(900, 600);

        private UserControl CurrentMainUC;
     
        #endregion
        #region ModelVaraible

        private DataBaseService DBService;
        private BookSeachService BookSServices;
        #endregion
        #region Constructors
        public MainWindow(DataBaseService _dbService,BookSeachService _bookSeachServices)
        {
            if (_dbService == null) throw new ArgumentNullException("DataBaseService");
            if (_bookSeachServices == null) throw new ArgumentNullException("BookSeachService");
            if (_dbService.loginID == -1) throw new Exception("Invalid login ID"); ;

            DBService = _dbService;
            BookSServices = _bookSeachServices;
            InitializeComponent();

            GlobalHomeUC control = new GlobalHomeUC(DBService);
            showUserControl(control);
        }
        #endregion
     
        public void showUserControl(UserControl costomUserControl)
        {
            //Set pref size for the user control to be shown
            costomUserControl.Location = MainUCLocation;
            costomUserControl.Size = MainUCSize;

            //Remove the current in use user control from the form
            this.Controls.Remove(CurrentMainUC);

            //Add the new user contro the list of controler
            this.Controls.Add(costomUserControl);

            //Re set the CurrentMain user control to the new one
            CurrentMainUC = null;
            CurrentMainUC = costomUserControl;
        }
      
        #region PanelClientFoncButtonEvent

        private void buttonHome_Click(object sender, EventArgs e)
        {
            GlobalHomeUC control = new GlobalHomeUC(DBService);
            showUserControl(control);
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBookUC control = new AddNewBookUC(DBService, BookSServices);
            showUserControl(control);
        }
        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            SearchBookUC control = new SearchBookUC(DBService);
            showUserControl(control);
        }

        private void buttonMyBook_Click(object sender, EventArgs e)
        {
            ClientHomeUC control = new ClientHomeUC(DBService);
            showUserControl(control);
        }

        #endregion
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            User userinfo = DBService.RetrieveUserInfo(DBService.loginID);
            labelWelcomeName.Text = "(" + userinfo .UserTypeName+ ")" + userinfo.Name;
            labelClientPhone.Text = userinfo.Phone;

            if(userinfo.UserTypeName == "Admin")
            {              
                panelAdminFunc.Location = PanelFunctionLocation;
                panelClientFunctionnality.Visible = false;
                panelAdminFunc.Visible = true;
            }
            if (userinfo.UserTypeName == "Client")
            {
                panelClientFunctionnality.Location = PanelFunctionLocation;
                panelAdminFunc.Visible = false;
                panelClientFunctionnality.Visible = true;
            }

        }






    }
}
