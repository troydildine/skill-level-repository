namespace BankGUI
{
    partial class frmCreateAccount
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtIntialBalance = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 9);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(21, 36);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Account Name";
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(26, 63);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(73, 13);
            this.lblInitialBalance.TabIndex = 2;
            this.lblInitialBalance.Text = "Initial Balance";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(31, 90);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(107, 5);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 4;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(107, 32);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 20);
            this.txtAccountName.TabIndex = 5;
            // 
            // txtIntialBalance
            // 
            this.txtIntialBalance.Location = new System.Drawing.Point(107, 59);
            this.txtIntialBalance.Name = "txtIntialBalance";
            this.txtIntialBalance.Size = new System.Drawing.Size(100, 20);
            this.txtIntialBalance.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(107, 86);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(12, 117);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(114, 23);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(205, 90);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "%";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 146);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtIntialBalance);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblInitialBalance);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "frmCreateAccount";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtIntialBalance;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPercent;
    }
}