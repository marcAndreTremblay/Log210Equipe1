namespace GestionnaireLivre.Forms.UtilityUC
{
    partial class BookInfoPanelUC
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LTitle = new System.Windows.Forms.Label();
            this.LAuthor = new System.Windows.Forms.Label();
            this.LCondition = new System.Windows.Forms.Label();
            this.LPrice = new System.Windows.Forms.Label();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.LCoopName = new System.Windows.Forms.Label();
            this.LLanguage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.Location = new System.Drawing.Point(56, 6);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(100, 18);
            this.LTitle.TabIndex = 1;
            this.LTitle.Text = "- book title -";
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAuthor.Location = new System.Drawing.Point(56, 33);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(79, 18);
            this.LAuthor.TabIndex = 2;
            this.LAuthor.Text = "- Author -";
            // 
            // LCondition
            // 
            this.LCondition.AutoSize = true;
            this.LCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCondition.Location = new System.Drawing.Point(575, 6);
            this.LCondition.Name = "LCondition";
            this.LCondition.Size = new System.Drawing.Size(99, 18);
            this.LCondition.TabIndex = 3;
            this.LCondition.Text = "- condition -";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrice.Location = new System.Drawing.Point(680, 6);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(69, 18);
            this.LPrice.TabIndex = 4;
            this.LPrice.Text = "- Price -";
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(771, 11);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(86, 37);
            this.ButtonReserve.TabIndex = 5;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = false;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // LCoopName
            // 
            this.LCoopName.AutoSize = true;
            this.LCoopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCoopName.Location = new System.Drawing.Point(575, 33);
            this.LCoopName.Name = "LCoopName";
            this.LCoopName.Size = new System.Drawing.Size(114, 18);
            this.LCoopName.TabIndex = 6;
            this.LCoopName.Text = "- coop name -";
            // 
            // LLanguage
            // 
            this.LLanguage.AutoSize = true;
            this.LLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLanguage.Location = new System.Drawing.Point(333, 6);
            this.LLanguage.Name = "LLanguage";
            this.LLanguage.Size = new System.Drawing.Size(97, 18);
            this.LLanguage.TabIndex = 7;
            this.LLanguage.Text = "- language -";
            // 
            // BookInfoPanelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LLanguage);
            this.Controls.Add(this.LCoopName);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.LCondition);
            this.Controls.Add(this.LAuthor);
            this.Controls.Add(this.LTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookInfoPanelUC";
            this.Size = new System.Drawing.Size(867, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LAuthor;
        private System.Windows.Forms.Label LCondition;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Label LCoopName;
        private System.Windows.Forms.Label LLanguage;
    }
}
