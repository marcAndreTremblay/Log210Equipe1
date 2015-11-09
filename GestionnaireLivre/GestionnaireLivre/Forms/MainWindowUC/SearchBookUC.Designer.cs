namespace GestionnaireLivre.Forms.MainUserControl
{
    partial class SearchBookUC
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.FLPBookSearchResult = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSearchTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSearchISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSearchAuthor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(688, 20);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(161, 31);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FLPBookSearchResult
            // 
            this.FLPBookSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPBookSearchResult.Location = new System.Drawing.Point(18, 108);
            this.FLPBookSearchResult.Name = "FLPBookSearchResult";
            this.FLPBookSearchResult.Size = new System.Drawing.Size(869, 465);
            this.FLPBookSearchResult.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBSearchAuthor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBSearchISBN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBSearchTitle);
            this.panel1.Controls.Add(this.ButtonSearch);
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 83);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // TBSearchTitle
            // 
            this.TBSearchTitle.Location = new System.Drawing.Point(44, 10);
            this.TBSearchTitle.Name = "TBSearchTitle";
            this.TBSearchTitle.Size = new System.Drawing.Size(152, 20);
            this.TBSearchTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // TBSearchISBN
            // 
            this.TBSearchISBN.Location = new System.Drawing.Point(44, 35);
            this.TBSearchISBN.Name = "TBSearchISBN";
            this.TBSearchISBN.Size = new System.Drawing.Size(152, 20);
            this.TBSearchISBN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author";
            // 
            // TBSearchAuthor
            // 
            this.TBSearchAuthor.Location = new System.Drawing.Point(243, 10);
            this.TBSearchAuthor.Name = "TBSearchAuthor";
            this.TBSearchAuthor.Size = new System.Drawing.Size(152, 20);
            this.TBSearchAuthor.TabIndex = 5;
            // 
            // SearchBookUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLPBookSearchResult);
            this.Name = "SearchBookUC";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.FlowLayoutPanel FLPBookSearchResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSearchTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSearchAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSearchISBN;
    }
}
