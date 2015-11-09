namespace GestionnaireLivre.Forms.MainUserControl
{
    partial class ClientHomeUC
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
            this.FLPOnSale = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPWaitPickup = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FLPWaitDeposit = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FLPOnSale
            // 
            this.FLPOnSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPOnSale.Location = new System.Drawing.Point(12, 293);
            this.FLPOnSale.Name = "FLPOnSale";
            this.FLPOnSale.Size = new System.Drawing.Size(872, 109);
            this.FLPOnSale.TabIndex = 0;
            // 
            // FLPWaitPickup
            // 
            this.FLPWaitPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPWaitPickup.Location = new System.Drawing.Point(12, 434);
            this.FLPWaitPickup.Name = "FLPWaitPickup";
            this.FLPWaitPickup.Size = new System.Drawing.Size(872, 109);
            this.FLPWaitPickup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "On sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waiting on pickup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Waiting on deposit";
            // 
            // FLPWaitDeposit
            // 
            this.FLPWaitDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPWaitDeposit.Location = new System.Drawing.Point(12, 158);
            this.FLPWaitDeposit.Name = "FLPWaitDeposit";
            this.FLPWaitDeposit.Size = new System.Drawing.Size(872, 109);
            this.FLPWaitDeposit.TabIndex = 4;
            // 
            // ClientHomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FLPWaitDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLPWaitPickup);
            this.Controls.Add(this.FLPOnSale);
            this.Name = "ClientHomeUC";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPOnSale;
        private System.Windows.Forms.FlowLayoutPanel FLPWaitPickup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FLPWaitDeposit;
    }
}
