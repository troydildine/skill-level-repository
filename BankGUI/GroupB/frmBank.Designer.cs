namespace BankGUI
{
    partial class frmBank
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
            this.grdAccounts = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOpeningDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnPayInterest = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.btnQuickLoan = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grdAccounts
            // 
            this.grdAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmName,
            this.clmBalance,
            this.clmInterest,
            this.clmOpeningDate});
            this.grdAccounts.FullRowSelect = true;
            this.grdAccounts.GridLines = true;
            this.grdAccounts.Location = new System.Drawing.Point(17, 36);
            this.grdAccounts.MultiSelect = false;
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.Size = new System.Drawing.Size(656, 189);
            this.grdAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdAccounts.TabIndex = 41;
            this.grdAccounts.UseCompatibleStateImageBehavior = false;
            this.grdAccounts.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "Account ID";
            this.clmId.Width = 100;
            // 
            // clmName
            // 
            this.clmName.Text = "Account Name";
            this.clmName.Width = 150;
            // 
            // clmBalance
            // 
            this.clmBalance.Text = "Current Balance";
            this.clmBalance.Width = 150;
            // 
            // clmInterest
            // 
            this.clmInterest.Text = "Interest Rate";
            this.clmInterest.Width = 100;
            // 
            // clmOpeningDate
            // 
            this.clmOpeningDate.Text = "Account Opening Date";
            this.clmOpeningDate.Width = 150;
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(18, 232);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(75, 34);
            this.btnNewAccount.TabIndex = 42;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(100, 232);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 34);
            this.btnDeposit.TabIndex = 43;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(125, 20);
            this.lblWelcome.TabIndex = 44;
            this.lblWelcome.Text = "Welcome, Name";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(182, 232);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 34);
            this.btnWithdraw.TabIndex = 45;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(264, 232);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 34);
            this.btnTransfer.TabIndex = 46;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnPayInterest
            // 
            this.btnPayInterest.Location = new System.Drawing.Point(346, 232);
            this.btnPayInterest.Name = "btnPayInterest";
            this.btnPayInterest.Size = new System.Drawing.Size(75, 34);
            this.btnPayInterest.TabIndex = 47;
            this.btnPayInterest.Text = "Pay Interest";
            this.btnPayInterest.UseVisualStyleBackColor = true;
            this.btnPayInterest.Click += new System.EventHandler(this.btnPayInterest_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(428, 232);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(85, 34);
            this.btnTransactions.TabIndex = 48;
            this.btnTransactions.Text = "List Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(519, 232);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 34);
            this.btnMerge.TabIndex = 49;
            this.btnMerge.Text = "Merge Accounts";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Location = new System.Drawing.Point(598, 232);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(75, 34);
            this.btnCloseAccount.TabIndex = 50;
            this.btnCloseAccount.Text = "Close Account";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // btnQuickLoan
            // 
            this.btnQuickLoan.Location = new System.Drawing.Point(571, 7);
            this.btnQuickLoan.Name = "btnQuickLoan";
            this.btnQuickLoan.Size = new System.Drawing.Size(103, 23);
            this.btnQuickLoan.TabIndex = 51;
            this.btnQuickLoan.Text = "Quick Loan Table";
            this.btnQuickLoan.UseVisualStyleBackColor = true;
            this.btnQuickLoan.Click += new System.EventHandler(this.btnQuickLoan_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search for Trans.";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 275);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnQuickLoan);
            this.Controls.Add(this.btnCloseAccount);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnPayInterest);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.grdAccounts);
            this.Name = "frmBank";
            this.Text = "Aquinas College Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBank_FormClosing);
            this.Load += new System.EventHandler(this.frmBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView grdAccounts;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmBalance;
        private System.Windows.Forms.ColumnHeader clmInterest;
        private System.Windows.Forms.ColumnHeader clmOpeningDate;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnPayInterest;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.Button btnQuickLoan;
        private System.Windows.Forms.Button btnSearch;



    }
}