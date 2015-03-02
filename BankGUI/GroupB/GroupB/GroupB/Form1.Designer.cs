namespace GroupB
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuickLoanTable = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.btnPayInterest = new System.Windows.Forms.Button();
            this.btnSelectAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnQuickLoanTable);
            this.groupBox1.Controls.Add(this.btnCreateAccount);
            this.groupBox1.Controls.Add(this.btnBalanceInquiry);
            this.groupBox1.Controls.Add(this.btnPayInterest);
            this.groupBox1.Controls.Add(this.btnSelectAccount);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banking System";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(246, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuickLoanTable
            // 
            this.btnQuickLoanTable.Location = new System.Drawing.Point(6, 137);
            this.btnQuickLoanTable.Name = "btnQuickLoanTable";
            this.btnQuickLoanTable.Size = new System.Drawing.Size(246, 23);
            this.btnQuickLoanTable.TabIndex = 4;
            this.btnQuickLoanTable.Text = "Quick Loan Table";
            this.btnQuickLoanTable.UseVisualStyleBackColor = true;
            this.btnQuickLoanTable.Click += new System.EventHandler(this.btnQuickLoanTable_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(6, 108);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(246, 23);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnBalanceInquiry
            // 
            this.btnBalanceInquiry.Location = new System.Drawing.Point(6, 79);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(246, 23);
            this.btnBalanceInquiry.TabIndex = 2;
            this.btnBalanceInquiry.Text = "Balance Inquiry";
            this.btnBalanceInquiry.UseVisualStyleBackColor = true;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);
            // 
            // btnPayInterest
            // 
            this.btnPayInterest.Location = new System.Drawing.Point(6, 50);
            this.btnPayInterest.Name = "btnPayInterest";
            this.btnPayInterest.Size = new System.Drawing.Size(246, 23);
            this.btnPayInterest.TabIndex = 1;
            this.btnPayInterest.Text = "Pay Interest";
            this.btnPayInterest.UseVisualStyleBackColor = true;
            this.btnPayInterest.Click += new System.EventHandler(this.btnPayInterest_Click);
            // 
            // btnSelectAccount
            // 
            this.btnSelectAccount.Location = new System.Drawing.Point(6, 21);
            this.btnSelectAccount.Name = "btnSelectAccount";
            this.btnSelectAccount.Size = new System.Drawing.Size(246, 23);
            this.btnSelectAccount.TabIndex = 0;
            this.btnSelectAccount.Text = "Select Account";
            this.btnSelectAccount.UseVisualStyleBackColor = true;
            this.btnSelectAccount.Click += new System.EventHandler(this.btnSelectAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(18, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(164, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(18, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(246, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aquinas College Bank";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuickLoanTable;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnBalanceInquiry;
        private System.Windows.Forms.Button btnPayInterest;
        private System.Windows.Forms.Button btnSelectAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

