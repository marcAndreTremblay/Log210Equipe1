namespace GestionnaireLivre.Forms.UtilityUC
{
    partial class BookClientInfoUC
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
            this.LTitle = new System.Windows.Forms.Label();
            this.LAuthor = new System.Windows.Forms.Label();
            this.LCondition = new System.Windows.Forms.Label();
            this.LPrice = new System.Windows.Forms.Label();
            this.labelCoopName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.AutoSize = true;
            this.LTitle.Location = new System.Drawing.Point(3, 3);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(35, 13);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "- title -";
            // 
            // LAuthor
            // 
            this.LAuthor.AutoSize = true;
            this.LAuthor.Location = new System.Drawing.Point(160, 3);
            this.LAuthor.Name = "LAuthor";
            this.LAuthor.Size = new System.Drawing.Size(49, 13);
            this.LAuthor.TabIndex = 1;
            this.LAuthor.Text = "- author -";
            // 
            // LCondition
            // 
            this.LCondition.AutoSize = true;
            this.LCondition.Location = new System.Drawing.Point(267, 3);
            this.LCondition.Name = "LCondition";
            this.LCondition.Size = new System.Drawing.Size(62, 13);
            this.LCondition.TabIndex = 2;
            this.LCondition.Text = "- condition -";
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Location = new System.Drawing.Point(490, 3);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(42, 13);
            this.LPrice.TabIndex = 4;
            this.LPrice.Text = "- price -";
            // 
            // labelCoopName
            // 
            this.labelCoopName.AutoSize = true;
            this.labelCoopName.Location = new System.Drawing.Point(335, 3);
            this.labelCoopName.Name = "labelCoopName";
            this.labelCoopName.Size = new System.Drawing.Size(46, 13);
            this.labelCoopName.TabIndex = 5;
            this.labelCoopName.Text = "- coop  -";
            // 
            // BookClientInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelCoopName);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.LCondition);
            this.Controls.Add(this.LAuthor);
            this.Controls.Add(this.LTitle);
            this.Name = "BookClientInfoUC";
            this.Size = new System.Drawing.Size(731, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LAuthor;
        private System.Windows.Forms.Label LCondition;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.Label labelCoopName;
    }
}
