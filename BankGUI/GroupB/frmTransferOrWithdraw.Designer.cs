namespace BankGUI
{
    partial class frmTransferOrWithdraw
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTransferWithdraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(14, 49);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 33);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(95, 49);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 33);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTransferWithdraw
            // 
            this.lblTransferWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferWithdraw.Location = new System.Drawing.Point(13, 9);
            this.lblTransferWithdraw.Name = "lblTransferWithdraw";
            this.lblTransferWithdraw.Size = new System.Drawing.Size(238, 37);
            this.lblTransferWithdraw.TabIndex = 3;
            this.lblTransferWithdraw.Text = "Would you like to transfer or withdraw the remaining balance?";
            // 
            // frmTransferOrWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 94);
            this.Controls.Add(this.lblTransferWithdraw);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnTransfer);
            this.Name = "frmTransferOrWithdraw";
            this.Text = "Transfer or Withdraw?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTransferWithdraw;
    }
}