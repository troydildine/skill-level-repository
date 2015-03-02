namespace GroupB
{
    partial class SelectAccountForm
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
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboAccounts
            // 
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(12, 29);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(259, 21);
            this.cboAccounts.TabIndex = 0;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountInfo.Location = new System.Drawing.Point(12, 84);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(260, 169);
            this.lblAccountInfo.TabIndex = 1;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(251, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Select An Account To Display From The ComboBox";
            // 
            // cboOptions
            // 
            this.cboOptions.FormattingEnabled = true;
            this.cboOptions.Location = new System.Drawing.Point(12, 56);
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(259, 21);
            this.cboOptions.TabIndex = 3;
            // 
            // SelectAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cboOptions);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.cboAccounts);
            this.Name = "SelectAccountForm";
            this.Text = "SelectAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAccounts;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ComboBox cboOptions;

    }
}