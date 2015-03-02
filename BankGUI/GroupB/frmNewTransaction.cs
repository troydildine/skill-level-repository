using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGUI
{
    public partial class frmNewTransaction : Form, IBankView
    {
        private BankController controller;

        public enum TransactionType
        {
            Deposit = 'D',
            Withdraw = 'W',
            Transfer = 'T',
            Merge = 'M'
        }

        public BankController Controller
        {
            set
            {
                this.controller = value;
            }
        }

        public string PersonName
        {
            set
            {
            }
        }

        public double Amount
        {
            get { return double.Parse(txtAmount.Text); }
        }

        public string Memo
        {
            get { return txtMemo.Text; }
        }

        public List<Account> AccountsList
        {
            set
            {
                cmbAccounts.Items.AddRange(value.ToArray());
            }
        }

        public List<Transaction> Transactions
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public int SelectedAccount
        {
            get
            {
                if (this.Text.Contains("Transfer") || this.Text.Contains("Merge"))
                {
                    Account a = (Account)cmbAccounts.SelectedItem;
                    return a.AccountNumber;
                }
                else
                    return -1;
            }
        }

        public frmNewTransaction(BankController controller, TransactionType transactionType)
        {
            InitializeComponent();
            this.controller = controller;
            controller.View = this;
            switch (transactionType)
            {
                case TransactionType.Deposit:
                    this.Text = "Deposit Funds";
                    lblTransfer.Visible = false;
                    cmbAccounts.Visible = false;
                    btnOK.Location = new Point(25, 65);
                    btnCancel.Location = new Point(105, 65);
                    this.Size = new Size(242, 132);
                    break;
                case TransactionType.Withdraw:
                    this.Text = "Withdraw Funds";
                    lblTransfer.Visible = false;
                    cmbAccounts.Visible = false;
                    btnOK.Location = new Point(25, 65);
                    btnCancel.Location = new Point(105, 65);
                    this.Size = new Size(242, 132);
                    break;
                case TransactionType.Transfer:
                    this.Text = "Transfer Funds";
                    lblTransfer.Visible = true;
                    cmbAccounts.Visible = true;
                    btnOK.Location = new Point(25, 95);
                    btnCancel.Location = new Point(105, 95);
                    this.Size = new Size(242, 160);
                    controller.UpdateDisplay();
                    break;
                case TransactionType.Merge:
                    this.Text = "Merge Funds";
                    lblTransfer.Visible = true;
                    cmbAccounts.Visible = true;
                    txtAmount.Enabled = false;
                    btnOK.Location = new Point(25, 95);
                    btnCancel.Location = new Point(105, 95);
                    this.Size = new Size(242, 160);
                    controller.UpdateDisplay();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String errors = "";
            if (!this.Text.Contains("Merge"))
            {
                try
                {
                    if (Amount == 3) ;
                }
                catch
                {
                    errors += "ERROR! You must enter a valid transaction amount! \n";
                }
            }
            if (txtMemo.Text == "")
                errors += "ERROR! You must enter a transaction memo! \n";
            if (lblTransfer.Visible && cmbAccounts.SelectedIndex < 0)
                errors += "ERROR! You must select an account to which you want to transfer funds! \n";
            if (errors != "")
            {
                MessageBox.Show(errors);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
