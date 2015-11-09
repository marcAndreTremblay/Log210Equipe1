using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Model.DataObject;

namespace GestionnaireLivre
{
    public partial class LoginForm : Form
    {
        #region ViewVaraibles
        private Point panelRecommendedTopLeft = new Point(10, 10);
      
        private Size loginStatePrefSize = new Size(320, 300);
        private Size newUserStatePrefSize = new Size(320, 420);

        private FormWindowState currentState = FormWindowState.login;
        #endregion
        #region ModelVariable
        private DataBaseService DBService;
        #endregion
        #region Constructors
        public LoginForm(DataBaseService dbService)
        {
            DBService = dbService;
            InitializeComponent();


            List<UserType> userType = DBService.UserType;
            foreach (UserType ut in userType)
            {
                comboBUserType.Items.Add(ut);
            }
            

            ResetNewUserPanel();
            ResetLoginPanel();
        }
        #endregion

        #region SignInPanelButtonEvents
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //NOTE(marc): Maybe clean the login panel
            this.currentState = FormWindowState.newUser;
            this.Invalidate(true);
        }

        private void buttonSummit_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxPassword.Text.Length <= 3) { labelLoginError.Visible = true; return; }
            if (textBoxUsername.Text == "" || textBoxUsername.Text.Length <= 3) { labelLoginError.Visible = true; return; }

            int result = DBService.CheckLogInCredentials(textBoxUsername.Text, textBoxPassword.Text);
            if(result == -1)
            {
                labelLoginError.Visible = true;
            }
            else
            {
                DBService.loginID = result;
                this.Close();
            }
        }

        #endregion
        #region SignUpPanelButtonEvents
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //NOTE(marc): Maybe clean the new user panel
            this.currentState = FormWindowState.login;
            this.Invalidate(true);
        }
        
        private void buttonNewSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxNewName.Text == "" || textBoxNewName.Text.Length < 2){ labelError.Visible = true; return; }
            if (textBoxNewPassword.Text == "" || textBoxNewPassword.Text.Length < 4) { labelError.Visible = true; return; }
            if (textBoxNewPhone.Text == "" || textBoxNewPhone.Text.Length <= 10) {labelError.Visible = true; return;}
            if (textBoxNewUsername.Text == "" || textBoxNewUsername.Text.Length < 4){ labelError.Visible = true; return;}
            if (textBoxNewEmail.Text == "" || textBoxNewEmail.Text.Length <= 6){ labelError.Visible = true; return;}


            bool emailTestResult = StringValidatorService.IsValidEmailAdress(textBoxNewEmail.Text);
            if (emailTestResult == true)
            {
                NewUser newUser = new NewUser();
                newUser.Name = textBoxNewName.Text;
                newUser.Phone = textBoxNewPhone.Text;
                newUser.Password = textBoxNewPassword.Text;
                newUser.Username = textBoxNewUsername.Text;
                newUser.EmailAdress = textBoxNewEmail.Text;

                bool result = false;

                UserType usertypeSelected = (UserType)comboBUserType.SelectedItem;
                newUser.UserTypeID = usertypeSelected.id;

                if (usertypeSelected.name == "Admin")
                {
                    if (textBoxCoopName.Text == "" || textBoxCoopName.Text.Length < 3) { labelError.Visible = true; return; }
                    if (textBoxCoopAdresse.Text == "" || textBoxCoopAdresse.Text.Length < 3) { labelError.Visible = true; return; }
                    if (textBoxCoopContactInfo.Text == "" || textBoxCoopContactInfo.Text.Length < 3) { labelError.Visible = true; return; }

                    NewCooperative newCoop = new NewCooperative();
                    newCoop.Adress = textBoxCoopAdresse.Text;
                    newCoop.ContactInformation = textBoxCoopContactInfo.Text;
                    newCoop.Name = textBoxCoopName.Text;

                    result = DBService.RegisterAdminWithCoop(newUser, newCoop);
                }
                if (usertypeSelected.name == "Client")
                {
                    result = DBService.RegisterUser(newUser);
                }


                if (result == false)
                {
                    labelError.Visible = true;
                }
                else
                {
                    ResetLoginPanel();

                    textBoxUsername.Text = newUser.Username;

                    ResetNewUserPanel();

                    this.currentState = FormWindowState.login;
                    this.Invalidate(true);

                    textBoxPassword.Focus();
                }
            }


        }
        #endregion

        #region UtilityMethods
        private void ResetNewUserPanel()
        {
            textBoxNewName.Text = "";
            textBoxNewPhone.Text = "";
            textBoxNewUsername.Text = "";
            textBoxNewPassword.Text = "";
            textBoxNewEmail.Text = "";
            comboBUserType.SelectedIndex = 0;

            labelError.Visible = false;
        }

        private void ResetLoginPanel()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";

            labelLoginError.Visible = false;
        }

        private void ShowLoginPanel()
        {
            panelLogin.Visible = true;
            panelLogin.Location = panelRecommendedTopLeft;
            this.Size = loginStatePrefSize;
            textBoxUsername.Focus();
            panelNewUser.Visible = false;

        }

        private void ShowNewUserPanel()
        {
            panelNewUser.Visible = true;
            panelNewUser.Location = panelRecommendedTopLeft;
            this.Size = newUserStatePrefSize;
            textBoxNewName.Focus();
            panelLogin.Visible = false;

        }
        #endregion

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            if(currentState == FormWindowState.login)
            {
                ShowLoginPanel();
                
            }
            else
            {
                ShowNewUserPanel();
            }
        }


        private enum FormWindowState
        {
            login,
            newUser
        }

        private void comboBUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox newSender = (ComboBox)sender;
            UserType selectedType = (UserType)newSender.SelectedItem;

            if(selectedType.name == "Client")
            {
                panelNewCoop.Visible = false;
            }
            if (selectedType.name == "Admin")
            {
                panelNewCoop.Visible = true;
            }
        }
    }
}
