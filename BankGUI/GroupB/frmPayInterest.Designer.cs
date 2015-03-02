namespace BankGUI
{
    partial class frmPayInterest
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
            this.grdPayInterest = new System.Windows.Forms.ListView();
            this.clmAccountId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterestPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNewBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInterestPaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grdPayInterest
            // 
            this.grdPayInterest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAccountId,
            this.clmAccountName,
            this.clmInterestPaid,
            this.clmNewBalance});
            this.grdPayInterest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPayInterest.LabelWrap = false;
            this.grdPayInterest.Location = new System.Drawing.Point(0, 32);
            this.grdPayInterest.MinimumSize = new System.Drawing.Size(50, 4);
            this.grdPayInterest.Name = "grdPayInterest";
            this.grdPayInterest.Size = new System.Drawing.Size(627, 250);
            this.grdPayInterest.TabIndex = 3;
            this.grdPayInterest.UseCompatibleStateImageBehavior = false;
            this.grdPayInterest.View = System.Windows.Forms.View.Details;
            this.grdPayInterest.SelectedIndexChanged += new System.EventHandler(this.grdTransactions_SelectedIndexChanged);
            // 
            // clmAccountId
            // 
            this.clmAccountId.Text = "Account ID";
            this.clmAccountId.Width = 110;
            // 
            // clmAccountName
            // 
            this.clmAccountName.Text = "Account Name";
            this.clmAccountName.Width = 135;
            // 
            // clmInterestPaid
            // 
            this.clmInterestPaid.Text = "Interest Paid";
            this.clmInterestPaid.Width = 135;
            // 
            // clmNewBalance
            // 
            this.clmNewBalance.Text = "New Balance";
            this.clmNewBalance.Width = 135;
            // 
            // lblInterestPaid
            // 
            this.lblInterestPaid.AutoSize = true;
            this.lblInterestPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestPaid.Location = new System.Drawing.Point(12, 9);
            this.lblInterestPaid.Name = "lblInterestPaid";
            this.lblInterestPaid.Size = new System.Drawing.Size(193, 20);
            this.lblInterestPaid.TabIndex = 2;
            this.lblInterestPaid.Text = "Interest Paid for Accounts";
            // 
            // frmPayInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 282);
            this.Controls.Add(this.grdPayInterest);
            this.Controls.Add(this.lblInterestPaid);
            this.Name = "frmPayInterest";
            this.Text = "frmPayInterest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView grdPayInterest;
        private System.Windows.Forms.ColumnHeader clmAccountId;
        private System.Windows.Forms.ColumnHeader clmAccountName;
        private System.Windows.Forms.ColumnHeader clmInterestPaid;
        private System.Windows.Forms.Label lblInterestPaid;
        private System.Windows.Forms.ColumnHeader clmNewBalance;
    }
}