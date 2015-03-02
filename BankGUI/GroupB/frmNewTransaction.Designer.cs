namespace BankGUI
{
    partial class frmNewTransaction
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(22, 16);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(71, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(29, 42);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(36, 13);
            this.lblMemo.TabIndex = 2;
            this.lblMemo.Text = "Memo";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(71, 38);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(133, 20);
            this.txtMemo.TabIndex = 3;
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(71, 65);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(133, 21);
            this.cmbAccounts.TabIndex = 4;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(3, 69);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(62, 13);
            this.lblTransfer.TabIndex = 5;
            this.lblTransfer.Text = "Transfer To";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 92);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 21);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 21);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 122);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "frmNewTransaction";
            this.Text = "frmNewTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}