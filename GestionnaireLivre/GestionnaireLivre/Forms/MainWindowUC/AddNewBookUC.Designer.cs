namespace GestionnaireLivre.Forms.MainWindowUC
{
    partial class AddNewBookUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxCodeISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearchISBN = new System.Windows.Forms.Button();
            this.timerSearchBook = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBPriceTag = new System.Windows.Forms.TextBox();
            this.comboBBookCondition = new System.Windows.Forms.ComboBox();
            this.buttonFIFM = new System.Windows.Forms.Button();
            this.textBCategorie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelSellPrice = new System.Windows.Forms.Panel();
            this.buttonRegisterNow = new System.Windows.Forms.Button();
            this.comboBBookState = new System.Windows.Forms.ComboBox();
            this.labelErrorSearch = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCooperative = new System.Windows.Forms.ComboBox();
            this.panelSellPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register a new book into our system";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(98, 107);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(168, 20);
            this.textBoxBookName.TabIndex = 2;
            // 
            // textBoxCodeISBN
            // 
            this.textBoxCodeISBN.Location = new System.Drawing.Point(98, 81);
            this.textBoxCodeISBN.Name = "textBoxCodeISBN";
            this.textBoxCodeISBN.Size = new System.Drawing.Size(168, 20);
            this.textBoxCodeISBN.TabIndex = 4;
            this.textBoxCodeISBN.Text = "0071807993";
            this.textBoxCodeISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCodeISBN_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code ISBN";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(98, 133);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(168, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Publisher";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(98, 158);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(168, 20);
            this.textBoxPublisher.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "(10/13 digits )";
            // 
            // buttonSearchISBN
            // 
            this.buttonSearchISBN.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSearchISBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchISBN.Location = new System.Drawing.Point(342, 79);
            this.buttonSearchISBN.Name = "buttonSearchISBN";
            this.buttonSearchISBN.Size = new System.Drawing.Size(83, 25);
            this.buttonSearchISBN.TabIndex = 10;
            this.buttonSearchISBN.Text = "Search";
            this.buttonSearchISBN.UseVisualStyleBackColor = false;
            this.buttonSearchISBN.Click += new System.EventHandler(this.buttonSearchISBN_Click);
            // 
            // timerSearchBook
            // 
            this.timerSearchBook.Enabled = true;
            this.timerSearchBook.Interval = 1000;
            this.timerSearchBook.Tick += new System.EventHandler(this.timerSearchBook_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Language";
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(98, 185);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(168, 20);
            this.textBoxLanguage.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Book overall condition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sell price";
            // 
            // textBPriceTag
            // 
            this.textBPriceTag.Location = new System.Drawing.Point(145, 3);
            this.textBPriceTag.Name = "textBPriceTag";
            this.textBPriceTag.Size = new System.Drawing.Size(105, 20);
            this.textBPriceTag.TabIndex = 15;
            // 
            // comboBBookCondition
            // 
            this.comboBBookCondition.FormattingEnabled = true;
            this.comboBBookCondition.Location = new System.Drawing.Point(161, 266);
            this.comboBBookCondition.Name = "comboBBookCondition";
            this.comboBBookCondition.Size = new System.Drawing.Size(105, 21);
            this.comboBBookCondition.TabIndex = 16;
            // 
            // buttonFIFM
            // 
            this.buttonFIFM.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFIFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFIFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFIFM.Location = new System.Drawing.Point(582, 546);
            this.buttonFIFM.Name = "buttonFIFM";
            this.buttonFIFM.Size = new System.Drawing.Size(222, 30);
            this.buttonFIFM.TabIndex = 17;
            this.buttonFIFM.Text = "Fill information for me";
            this.buttonFIFM.UseVisualStyleBackColor = false;
            this.buttonFIFM.Click += new System.EventHandler(this.buttonFIFM_Click);
            // 
            // textBCategorie
            // 
            this.textBCategorie.Location = new System.Drawing.Point(98, 211);
            this.textBCategorie.Name = "textBCategorie";
            this.textBCategorie.Size = new System.Drawing.Size(168, 20);
            this.textBCategorie.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Categorie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Register book for ?";
            // 
            // panelSellPrice
            // 
            this.panelSellPrice.Controls.Add(this.label9);
            this.panelSellPrice.Controls.Add(this.textBPriceTag);
            this.panelSellPrice.Location = new System.Drawing.Point(16, 320);
            this.panelSellPrice.Name = "panelSellPrice";
            this.panelSellPrice.Size = new System.Drawing.Size(280, 27);
            this.panelSellPrice.TabIndex = 23;
            // 
            // buttonRegisterNow
            // 
            this.buttonRegisterNow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRegisterNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterNow.Location = new System.Drawing.Point(16, 420);
            this.buttonRegisterNow.Name = "buttonRegisterNow";
            this.buttonRegisterNow.Size = new System.Drawing.Size(225, 35);
            this.buttonRegisterNow.TabIndex = 24;
            this.buttonRegisterNow.Text = "Register book now";
            this.buttonRegisterNow.UseVisualStyleBackColor = false;
            this.buttonRegisterNow.Click += new System.EventHandler(this.buttonRegisterNow_Click);
            // 
            // comboBBookState
            // 
            this.comboBBookState.FormattingEnabled = true;
            this.comboBBookState.Location = new System.Drawing.Point(161, 293);
            this.comboBBookState.Name = "comboBBookState";
            this.comboBBookState.Size = new System.Drawing.Size(105, 21);
            this.comboBBookState.TabIndex = 25;
            // 
            // labelErrorSearch
            // 
            this.labelErrorSearch.AutoSize = true;
            this.labelErrorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorSearch.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSearch.Location = new System.Drawing.Point(431, 84);
            this.labelErrorSearch.Name = "labelErrorSearch";
            this.labelErrorSearch.Size = new System.Drawing.Size(139, 15);
            this.labelErrorSearch.TabIndex = 26;
            this.labelErrorSearch.Text = "(Could not find anything)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Witch cooperative are you going to deposite your book at?";
            // 
            // comboBoxCooperative
            // 
            this.comboBoxCooperative.FormattingEnabled = true;
            this.comboBoxCooperative.Location = new System.Drawing.Point(16, 374);
            this.comboBoxCooperative.Name = "comboBoxCooperative";
            this.comboBoxCooperative.Size = new System.Drawing.Size(345, 21);
            this.comboBoxCooperative.TabIndex = 28;
            // 
            // AddNewBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.comboBoxCooperative);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelErrorSearch);
            this.Controls.Add(this.comboBBookState);
            this.Controls.Add(this.buttonRegisterNow);
            this.Controls.Add(this.panelSellPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBCategorie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFIFM);
            this.Controls.Add(this.comboBBookCondition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSearchISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCodeISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewBookUC";
            this.Size = new System.Drawing.Size(900, 600);
            this.panelSellPrice.ResumeLayout(false);
            this.panelSellPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxCodeISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSearchISBN;
        private System.Windows.Forms.Timer timerSearchBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBPriceTag;
        private System.Windows.Forms.ComboBox comboBBookCondition;
        private System.Windows.Forms.Button buttonFIFM;
        private System.Windows.Forms.TextBox textBCategorie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelSellPrice;
        private System.Windows.Forms.Button buttonRegisterNow;
        private System.Windows.Forms.ComboBox comboBBookState;
        private System.Windows.Forms.Label labelErrorSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCooperative;
    }
}
