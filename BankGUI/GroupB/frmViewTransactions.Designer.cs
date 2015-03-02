namespace BankGUI
{
    partial class frmViewTransactions
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.grdTransactions = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMemo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(12, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(186, 20);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Transactions for Account";
            // 
            // grdTransactions
            // 
            this.grdTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmDate,
            this.clmAmount,
            this.clmMemo});
            this.grdTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTransactions.Location = new System.Drawing.Point(0, 39);
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(603, 242);
            this.grdTransactions.TabIndex = 1;
            this.grdTransactions.UseCompatibleStateImageBehavior = false;
            this.grdTransactions.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "Transaction ID";
            this.clmId.Width = 100;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 75;
            // 
            // clmAmount
            // 
            this.clmAmount.Text = "Amount";
            this.clmAmount.Width = 75;
            // 
            // clmMemo
            // 
            this.clmMemo.Text = "Memo";
            this.clmMemo.Width = 300;
            // 
            // frmViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 281);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.lblAccount);
            this.Name = "frmViewTransactions";
            this.Text = "Transactions List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ListView grdTransactions;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmAmount;
        private System.Windows.Forms.ColumnHeader clmMemo;
    }
}