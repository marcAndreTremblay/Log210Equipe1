namespace GestionnaireLivre
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.buttonSummit = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelNewUser = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBUserType = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonNewSignUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNewEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPhone = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNewUserControler = new System.Windows.Forms.Panel();
            this.panelNewCoop = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCoopName = new System.Windows.Forms.TextBox();
            this.textBoxCoopAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCoopContactInfo = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panelNewUser.SuspendLayout();
            this.panelNewUserControler.SuspendLayout();
            this.panelNewCoop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(226, 250);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(71, 27);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLogin.Controls.Add(this.labelLoginError);
            this.panelLogin.Controls.Add(this.buttonSummit);
            this.panelLogin.Controls.Add(this.buttonSignUp);
            this.panelLogin.Controls.Add(this.buttonQuit);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Location = new System.Drawing.Point(9, 421);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 280);
            this.panelLogin.TabIndex = 8;
            // 
            // labelLoginError
            // 
            this.labelLoginError.AutoSize = true;
            this.labelLoginError.BackColor = System.Drawing.SystemColors.Control;
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(114, 202);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(82, 13);
            this.labelLoginError.TabIndex = 27;
            this.labelLoginError.Text = "A error as occur";
            // 
            // buttonSummit
            // 
            this.buttonSummit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummit.Location = new System.Drawing.Point(228, 170);
            this.buttonSummit.Name = "buttonSummit";
            this.buttonSummit.Size = new System.Drawing.Size(50, 20);
            this.buttonSummit.TabIndex = 12;
            this.buttonSummit.Text = "Summit";
            this.buttonSummit.UseVisualStyleBackColor = true;
            this.buttonSummit.Click += new System.EventHandler(this.buttonSummit_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(3, 250);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(134, 27);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(88, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(88, 112);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(134, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // panelNewUser
            // 
            this.panelNewUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelNewUser.Controls.Add(this.panelNewCoop);
            this.panelNewUser.Controls.Add(this.panelNewUserControler);
            this.panelNewUser.Controls.Add(this.label10);
            this.panelNewUser.Controls.Add(this.comboBUserType);
            this.panelNewUser.Controls.Add(this.label9);
            this.panelNewUser.Controls.Add(this.textBoxNewEmail);
            this.panelNewUser.Controls.Add(this.label8);
            this.panelNewUser.Controls.Add(this.label7);
            this.panelNewUser.Controls.Add(this.label6);
            this.panelNewUser.Controls.Add(this.label5);
            this.panelNewUser.Controls.Add(this.textBoxNewPassword);
            this.panelNewUser.Controls.Add(this.textBoxNewUsername);
            this.panelNewUser.Controls.Add(this.textBoxNewPhone);
            this.panelNewUser.Controls.Add(this.textBoxNewName);
            this.panelNewUser.Controls.Add(this.label3);
            this.panelNewUser.Location = new System.Drawing.Point(9, 15);
            this.panelNewUser.Name = "panelNewUser";
            this.panelNewUser.Size = new System.Drawing.Size(300, 400);
            this.panelNewUser.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Type of user";
            // 
            // comboBUserType
            // 
            this.comboBUserType.FormattingEnabled = true;
            this.comboBUserType.Location = new System.Drawing.Point(127, 189);
            this.comboBUserType.Name = "comboBUserType";
            this.comboBUserType.Size = new System.Drawing.Size(114, 21);
            this.comboBUserType.TabIndex = 25;
            this.comboBUserType.SelectedIndexChanged += new System.EventHandler(this.comboBUserType_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.SystemColors.Control;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(113, 1);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(82, 13);
            this.labelError.TabIndex = 24;
            this.labelError.Text = "A error as occur";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.Location = new System.Drawing.Point(199, 53);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(80, 25);
            this.buttonRetour.TabIndex = 23;
            this.buttonRetour.Text = "Return";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonNewSignUp
            // 
            this.buttonNewSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSignUp.Location = new System.Drawing.Point(91, 20);
            this.buttonNewSignUp.Name = "buttonNewSignUp";
            this.buttonNewSignUp.Size = new System.Drawing.Size(134, 27);
            this.buttonNewSignUp.TabIndex = 13;
            this.buttonNewSignUp.Text = "Sign up";
            this.buttonNewSignUp.UseVisualStyleBackColor = true;
            this.buttonNewSignUp.Click += new System.EventHandler(this.buttonNewSignUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email";
            // 
            // textBoxNewEmail
            // 
            this.textBoxNewEmail.Location = new System.Drawing.Point(117, 163);
            this.textBoxNewEmail.Name = "textBoxNewEmail";
            this.textBoxNewEmail.Size = new System.Drawing.Size(124, 20);
            this.textBoxNewEmail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(117, 137);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(124, 20);
            this.textBoxNewPassword.TabIndex = 4;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Location = new System.Drawing.Point(117, 111);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(124, 20);
            this.textBoxNewUsername.TabIndex = 3;
            // 
            // textBoxNewPhone
            // 
            this.textBoxNewPhone.Location = new System.Drawing.Point(117, 85);
            this.textBoxNewPhone.Name = "textBoxNewPhone";
            this.textBoxNewPhone.Size = new System.Drawing.Size(124, 20);
            this.textBoxNewPhone.TabIndex = 2;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(117, 59);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(124, 20);
            this.textBoxNewName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "New user";
            // 
            // panelNewUserControler
            // 
            this.panelNewUserControler.Controls.Add(this.buttonNewSignUp);
            this.panelNewUserControler.Controls.Add(this.buttonRetour);
            this.panelNewUserControler.Controls.Add(this.labelError);
            this.panelNewUserControler.Location = new System.Drawing.Point(8, 313);
            this.panelNewUserControler.Name = "panelNewUserControler";
            this.panelNewUserControler.Size = new System.Drawing.Size(283, 79);
            this.panelNewUserControler.TabIndex = 27;
            // 
            // panelNewCoop
            // 
            this.panelNewCoop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNewCoop.Controls.Add(this.textBoxCoopContactInfo);
            this.panelNewCoop.Controls.Add(this.textBoxCoopAdresse);
            this.panelNewCoop.Controls.Add(this.textBoxCoopName);
            this.panelNewCoop.Controls.Add(this.label14);
            this.panelNewCoop.Controls.Add(this.label13);
            this.panelNewCoop.Controls.Add(this.label12);
            this.panelNewCoop.Controls.Add(this.label11);
            this.panelNewCoop.Location = new System.Drawing.Point(8, 220);
            this.panelNewCoop.Name = "panelNewCoop";
            this.panelNewCoop.Size = new System.Drawing.Size(288, 90);
            this.panelNewCoop.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Cooperative :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Adresse :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 16);
            this.label14.TabIndex = 32;
            this.label14.Text = "Contact information :";
            // 
            // textBoxCoopName
            // 
            this.textBoxCoopName.Location = new System.Drawing.Point(154, 13);
            this.textBoxCoopName.Name = "textBoxCoopName";
            this.textBoxCoopName.Size = new System.Drawing.Size(124, 20);
            this.textBoxCoopName.TabIndex = 29;
            // 
            // textBoxCoopAdresse
            // 
            this.textBoxCoopAdresse.Location = new System.Drawing.Point(154, 33);
            this.textBoxCoopAdresse.Name = "textBoxCoopAdresse";
            this.textBoxCoopAdresse.Size = new System.Drawing.Size(124, 20);
            this.textBoxCoopAdresse.TabIndex = 33;
            // 
            // textBoxCoopContactInfo
            // 
            this.textBoxCoopContactInfo.Location = new System.Drawing.Point(154, 53);
            this.textBoxCoopContactInfo.Name = "textBoxCoopContactInfo";
            this.textBoxCoopContactInfo.Size = new System.Drawing.Size(124, 20);
            this.textBoxCoopContactInfo.TabIndex = 34;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(326, 710);
            this.Controls.Add(this.panelNewUser);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelNewUser.ResumeLayout(false);
            this.panelNewUser.PerformLayout();
            this.panelNewUserControler.ResumeLayout(false);
            this.panelNewUserControler.PerformLayout();
            this.panelNewCoop.ResumeLayout(false);
            this.panelNewCoop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonSummit;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panelNewUser;
        private System.Windows.Forms.Button buttonNewSignUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNewEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPhone;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelLoginError;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBUserType;
        private System.Windows.Forms.Panel panelNewCoop;
        private System.Windows.Forms.Panel panelNewUserControler;
        private System.Windows.Forms.TextBox textBoxCoopContactInfo;
        private System.Windows.Forms.TextBox textBoxCoopAdresse;
        private System.Windows.Forms.TextBox textBoxCoopName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}