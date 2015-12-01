namespace GestionnaireLivre.Forms.MainWindowUC
{
    partial class BookReceptionUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.searchResultLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchTypeCB = new System.Windows.Forms.ComboBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBBookCondition = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSearchError = new System.Windows.Forms.Label();
            this.labelValidationError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Book Reception";
            // 
            // searchResultLV
            // 
            this.searchResultLV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchResultLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.searchResultLV.FullRowSelect = true;
            this.searchResultLV.GridLines = true;
            this.searchResultLV.Location = new System.Drawing.Point(15, 117);
            this.searchResultLV.Name = "searchResultLV";
            this.searchResultLV.Size = new System.Drawing.Size(868, 315);
            this.searchResultLV.TabIndex = 14;
            this.searchResultLV.UseCompatibleStateImageBehavior = false;
            this.searchResultLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 253;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ISBN";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Client name";
            this.columnHeader3.Width = 221;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Book condition";
            this.columnHeader4.Width = 129;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(482, 53);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(161, 31);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchTypeCB
            // 
            this.searchTypeCB.FormattingEnabled = true;
            this.searchTypeCB.Items.AddRange(new object[] {
            "Client name",
            "Title",
            "ISBN",
            "UPC"});
            this.searchTypeCB.Location = new System.Drawing.Point(94, 58);
            this.searchTypeCB.Name = "searchTypeCB";
            this.searchTypeCB.Size = new System.Drawing.Size(132, 21);
            this.searchTypeCB.TabIndex = 9;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(232, 59);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(244, 20);
            this.searchTB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Validate book condition:";
            // 
            // comboBBookCondition
            // 
            this.comboBBookCondition.FormattingEnabled = true;
            this.comboBBookCondition.Location = new System.Drawing.Point(177, 465);
            this.comboBBookCondition.Name = "comboBBookCondition";
            this.comboBBookCondition.Size = new System.Drawing.Size(132, 21);
            this.comboBBookCondition.TabIndex = 16;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(315, 459);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(161, 31);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Confirm reception";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(482, 459);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 31);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel reception";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(722, 552);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(161, 31);
            this.buttonFinish.TabIndex = 19;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 39;
            // 
            // labelSearchError
            // 
            this.labelSearchError.AutoSize = true;
            this.labelSearchError.BackColor = System.Drawing.Color.Snow;
            this.labelSearchError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSearchError.ForeColor = System.Drawing.Color.Red;
            this.labelSearchError.Location = new System.Drawing.Point(649, 59);
            this.labelSearchError.Name = "labelSearchError";
            this.labelSearchError.Size = new System.Drawing.Size(88, 17);
            this.labelSearchError.TabIndex = 21;
            this.labelSearchError.Text = "Search error";
            this.labelSearchError.Visible = false;
            // 
            // labelValidationError
            // 
            this.labelValidationError.AutoSize = true;
            this.labelValidationError.BackColor = System.Drawing.Color.Snow;
            this.labelValidationError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelValidationError.ForeColor = System.Drawing.Color.Red;
            this.labelValidationError.Location = new System.Drawing.Point(649, 465);
            this.labelValidationError.Name = "labelValidationError";
            this.labelValidationError.Size = new System.Drawing.Size(105, 17);
            this.labelValidationError.TabIndex = 22;
            this.labelValidationError.Text = "Validation error";
            this.labelValidationError.Visible = false;
            // 
            // BookReceptionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.labelValidationError);
            this.Controls.Add(this.labelSearchError);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBBookCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTypeCB);
            this.Controls.Add(this.searchResultLV);
            this.Controls.Add(this.label2);
            this.Name = "BookReceptionUC";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView searchResultLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox searchTypeCB;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBBookCondition;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelSearchError;
        private System.Windows.Forms.Label labelValidationError;
    }
}
