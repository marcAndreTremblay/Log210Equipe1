namespace GestionnaireLivre
{
    partial class MainWindow
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
            this.panelClientFunctionnality = new System.Windows.Forms.Panel();
            this.buttonMyBook = new System.Windows.Forms.Button();
            this.buttonSeachBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWelcomeName = new System.Windows.Forms.Label();
            this.panelAdminFunc = new System.Windows.Forms.Panel();
            this.buttonBookReception = new System.Windows.Forms.Button();
            this.buttonHome2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.buttonBookDelivery = new System.Windows.Forms.Button();
            this.panelClientFunctionnality.SuspendLayout();
            this.panelAdminFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientFunctionnality
            // 
            this.panelClientFunctionnality.Controls.Add(this.buttonMyBook);
            this.panelClientFunctionnality.Controls.Add(this.buttonSeachBook);
            this.panelClientFunctionnality.Controls.Add(this.buttonAddBook);
            this.panelClientFunctionnality.Controls.Add(this.buttonHome);
            this.panelClientFunctionnality.Location = new System.Drawing.Point(15, 365);
            this.panelClientFunctionnality.Name = "panelClientFunctionnality";
            this.panelClientFunctionnality.Size = new System.Drawing.Size(130, 205);
            this.panelClientFunctionnality.TabIndex = 0;
            // 
            // buttonMyBook
            // 
            this.buttonMyBook.Location = new System.Drawing.Point(3, 150);
            this.buttonMyBook.Name = "buttonMyBook";
            this.buttonMyBook.Size = new System.Drawing.Size(119, 43);
            this.buttonMyBook.TabIndex = 3;
            this.buttonMyBook.Text = "My books";
            this.buttonMyBook.UseVisualStyleBackColor = true;
            this.buttonMyBook.Click += new System.EventHandler(this.buttonMyBook_Click);
            // 
            // buttonSeachBook
            // 
            this.buttonSeachBook.Location = new System.Drawing.Point(3, 101);
            this.buttonSeachBook.Name = "buttonSeachBook";
            this.buttonSeachBook.Size = new System.Drawing.Size(119, 43);
            this.buttonSeachBook.TabIndex = 2;
            this.buttonSeachBook.Text = "Find/Buy books";
            this.buttonSeachBook.UseVisualStyleBackColor = true;
            this.buttonSeachBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(3, 52);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(119, 43);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Register new  book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(119, 43);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome ";
            // 
            // labelWelcomeName
            // 
            this.labelWelcomeName.AutoSize = true;
            this.labelWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeName.Location = new System.Drawing.Point(108, 9);
            this.labelWelcomeName.Name = "labelWelcomeName";
            this.labelWelcomeName.Size = new System.Drawing.Size(109, 24);
            this.labelWelcomeName.TabIndex = 2;
            this.labelWelcomeName.Text = "-Username-";
            // 
            // panelAdminFunc
            // 
            this.panelAdminFunc.Controls.Add(this.buttonBookDelivery);
            this.panelAdminFunc.Controls.Add(this.buttonBookReception);
            this.panelAdminFunc.Controls.Add(this.buttonHome2);
            this.panelAdminFunc.Location = new System.Drawing.Point(10, 120);
            this.panelAdminFunc.Name = "panelAdminFunc";
            this.panelAdminFunc.Size = new System.Drawing.Size(130, 205);
            this.panelAdminFunc.TabIndex = 4;
            // 
            // buttonBookReception
            // 
            this.buttonBookReception.Location = new System.Drawing.Point(3, 52);
            this.buttonBookReception.Name = "buttonBookReception";
            this.buttonBookReception.Size = new System.Drawing.Size(119, 43);
            this.buttonBookReception.TabIndex = 7;
            this.buttonBookReception.Text = "Book Reception";
            this.buttonBookReception.UseVisualStyleBackColor = true;
            this.buttonBookReception.Click += new System.EventHandler(this.buttonBookReception_Click);
            // 
            // buttonHome2
            // 
            this.buttonHome2.Location = new System.Drawing.Point(3, 3);
            this.buttonHome2.Name = "buttonHome2";
            this.buttonHome2.Size = new System.Drawing.Size(119, 43);
            this.buttonHome2.TabIndex = 0;
            this.buttonHome2.Text = "Home";
            this.buttonHome2.UseVisualStyleBackColor = true;
            this.buttonHome2.Click += new System.EventHandler(this.buttonHome2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone number";
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientPhone.Location = new System.Drawing.Point(162, 33);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(132, 24);
            this.labelClientPhone.TabIndex = 6;
            this.labelClientPhone.Text = "-435 634 5343-";
            // 
            // buttonBookDelivery
            // 
            this.buttonBookDelivery.Location = new System.Drawing.Point(3, 101);
            this.buttonBookDelivery.Name = "buttonBookDelivery";
            this.buttonBookDelivery.Size = new System.Drawing.Size(119, 43);
            this.buttonBookDelivery.TabIndex = 8;
            this.buttonBookDelivery.Text = "Book Delivery";
            this.buttonBookDelivery.UseVisualStyleBackColor = true;
            this.buttonBookDelivery.Click += new System.EventHandler(this.buttonBookDelivery_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1087, 697);
            this.Controls.Add(this.labelClientPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAdminFunc);
            this.Controls.Add(this.labelWelcomeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelClientFunctionnality);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelClientFunctionnality.ResumeLayout(false);
            this.panelAdminFunc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClientFunctionnality;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWelcomeName;
        private System.Windows.Forms.Button buttonMyBook;
        private System.Windows.Forms.Panel panelAdminFunc;
        private System.Windows.Forms.Button buttonHome2;
        private System.Windows.Forms.Button buttonSeachBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.Button buttonBookReception;
        private System.Windows.Forms.Button buttonBookDelivery;
    }
}

