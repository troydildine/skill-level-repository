namespace BankGUI
{
    partial class frmQuickLoanTable
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
            this.grdQuickLoanTable = new System.Windows.Forms.ListView();
            this.clmMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInterest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrincipal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grdQuickLoanTable
            // 
            this.grdQuickLoanTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMonth,
            this.clmPayment,
            this.clmInterest,
            this.clmPrincipal,
            this.clmBalance});
            this.grdQuickLoanTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdQuickLoanTable.Location = new System.Drawing.Point(0, 135);
            this.grdQuickLoanTable.Name = "grdQuickLoanTable";
            this.grdQuickLoanTable.Size = new System.Drawing.Size(632, 252);
            this.grdQuickLoanTable.TabIndex = 0;
            this.grdQuickLoanTable.UseCompatibleStateImageBehavior = false;
            this.grdQuickLoanTable.View = System.Windows.Forms.View.Details;
            // 
            // clmMonth
            // 
            this.clmMonth.Text = "Month";
            this.clmMonth.Width = 100;
            // 
            // clmPayment
            // 
            this.clmPayment.Text = "Payment";
            this.clmPayment.Width = 120;
            // 
            // clmInterest
            // 
            this.clmInterest.Text = "Interest";
            this.clmInterest.Width = 120;
            // 
            // clmPrincipal
            // 
            this.clmPrincipal.Text = "Principle";
            this.clmPrincipal.Width = 120;
            // 
            // clmBalance
            // 
            this.clmBalance.Text = "Balance";
            this.clmBalance.Width = 120;
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(17, 16);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(91, 13);
            this.lblLoanAmount.TabIndex = 1;
            this.lblLoanAmount.Text = "Amount to Borrow";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(40, 58);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(124, 12);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(116, 20);
            this.txtLoanAmount.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(124, 54);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(116, 20);
            this.txtInterestRate.TabIndex = 5;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(124, 96);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(116, 20);
            this.txtPeriod.TabIndex = 6;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(14, 99);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(94, 13);
            this.lblPeriod.TabIndex = 3;
            this.lblPeriod.Text = "Repayment Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "months";
            // 
            // btnGenerateTable
            // 
            this.btnGenerateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTable.Location = new System.Drawing.Point(321, 12);
            this.btnGenerateTable.Name = "btnGenerateTable";
            this.btnGenerateTable.Size = new System.Drawing.Size(299, 104);
            this.btnGenerateTable.TabIndex = 9;
            this.btnGenerateTable.Text = "Generate Table";
            this.btnGenerateTable.UseVisualStyleBackColor = true;
            this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
            // 
            // frmQuickLoanTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 387);
            this.Controls.Add(this.btnGenerateTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.grdQuickLoanTable);
            this.Name = "frmQuickLoanTable";
            this.Text = "QuickLoanTableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView grdQuickLoanTable;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateTable;
        private System.Windows.Forms.ColumnHeader clmMonth;
        private System.Windows.Forms.ColumnHeader clmPayment;
        private System.Windows.Forms.ColumnHeader clmInterest;
        private System.Windows.Forms.ColumnHeader clmPrincipal;
        private System.Windows.Forms.ColumnHeader clmBalance;
    }
}