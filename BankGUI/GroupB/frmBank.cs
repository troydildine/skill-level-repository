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
    public partial class frmBank : Form, IBankView
    {
        //IMPORTANT
        //PLEASE NOTE
        //
        //In order for any of the form buttons to work properly, or look okay to the user, grdAccounts.Focus() MUST be included at the end of the
        //event for every button click, otherwise it will not show the selected Account.

        //The close account button allows a user to transfer or withdraw, this gives them the ability to transfer partial amounts.  We can easily change
        //this to merge instead.

        //Need to make sure the calculations for pay interest.  I also set the pay interest button to pay to all accounts (if eligible) so it may 
        //need to be changed to just pay to the selected account?

        private BankController controller;

        public BankController Controller
        {
            set
            {
                this.controller = value;
            }
        }

        public String PersonName
        {
            set
            {
                this.lblWelcome.Text = "Welcome, " + value;
            }
        }

        public List<Account> AccountsList
        {
            set
            {
                grdAccounts.Items.Clear();
                foreach (Account a in value)
                {
                    ListViewItem parent = grdAccounts.Items.Add(a.AccountNumber.ToString().PadLeft(5, '0'));
                    parent.SubItems.Add(a.AccountName);
                    parent.SubItems.Add(a.Balance.ToString("C"));
                    parent.SubItems.Add(a.InterestRate.ToString("P"));
                    parent.SubItems.Add(a.OpenDate.ToString("d"));
                }
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
                if (grdAccounts.SelectedItems.Count > 0)
                {
                    return int.Parse(grdAccounts.SelectedItems[0].Text);
                }
                else
                {
                    return -1;
                }
            }
        }

        public frmBank()
        {
            InitializeComponent();
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            this.controller = new BankController(this);
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
            }
            grdAccounts.Focus();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount create = new frmCreateAccount();
            DialogResult res = create.ShowDialog();
            if (res == DialogResult.OK)
            {
                Account a = new Account(create.AccountName, create.AccountNumber, create.InitialBalance, create.InterestRate, DateTime.Today);
                if (!controller.NewAccount(a))
                {
                    MessageBox.Show("ERROR! The account number you supplied is already in use!");
                }
            }
            grdAccounts.Focus();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (SelectedAccount == -1)
            {
                MessageBox.Show("ERROR! You must select an account to which you want to deposit money!");
            }
            else
            {
                frmNewTransaction deposit = new frmNewTransaction(this.controller, frmNewTransaction.TransactionType.Deposit);
                DialogResult res = deposit.ShowDialog();
                controller.View = this;
                if (res == DialogResult.OK)
                {
                    if (!controller.Deposit(SelectedAccount, deposit.Amount, deposit.Memo))
                        MessageBox.Show("ERROR! The deposit could not be added!");
                }
            }
            grdAccounts.Focus();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (SelectedAccount == -1)
            {
                MessageBox.Show("ERROR! You must select an account from which you want to withdraw money!");
            }
            else
            {
                frmNewTransaction withdraw = new frmNewTransaction(this.controller, frmNewTransaction.TransactionType.Withdraw);
                DialogResult res = withdraw.ShowDialog();
                controller.View = this;
                if (res == DialogResult.OK)
                {
                    if(!controller.Withdraw(SelectedAccount, withdraw.Amount, withdraw.Memo))
                        MessageBox.Show("ERROR! The withdraw could not be added!");
                }
            }
            grdAccounts.Focus();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (SelectedAccount == -1)
            {
                MessageBox.Show("ERROR! You must select an account.");
            }
            else
            {
                frmNewTransaction transfer = new frmNewTransaction(this.controller, frmNewTransaction.TransactionType.Transfer);
                DialogResult res = transfer.ShowDialog();
                controller.View = this;
                if (res == DialogResult.OK)
                {
                    if (!controller.Transfer(SelectedAccount, transfer.SelectedAccount, transfer.Amount, transfer.Memo))
                        MessageBox.Show("ERROR! The transfer transaction could not be added!");
                }
            }
            grdAccounts.Focus();
        }

        private void btnPayInterest_Click(object sender, EventArgs e)
        {
            frmPayInterest payInt = new frmPayInterest(this.controller);
            payInt.ShowDialog();
            controller.View = this;
            grdAccounts.Focus();
            controller.UpdateDisplay();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (SelectedAccount >= 0)
            {
                frmViewTransactions trans = new frmViewTransactions(this.controller);
                controller.ViewTransactions(this.SelectedAccount);
                trans.ShowDialog();
                controller.View = this;
                grdAccounts.Focus();
            }
            else
            {
                MessageBox.Show("ERROR! You must select an account!");
                grdAccounts.Focus();
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (SelectedAccount == -1)
            {
                MessageBox.Show("ERROR! You must select an account.");
            }
            else
            {
                frmNewTransaction transfer = new frmNewTransaction(this.controller, frmNewTransaction.TransactionType.Merge);
                DialogResult res = transfer.ShowDialog();
                controller.View = this;
                if (res == DialogResult.OK)
                {
                    if (!controller.Transfer(SelectedAccount, transfer.SelectedAccount, double.Parse(grdAccounts.SelectedItems[0].SubItems[2].Text.Substring(1))/*transfer.Amount*/, transfer.Memo))
                        MessageBox.Show("ERROR! The transfer transaction could not be added!");
                    this.grdAccounts.Items[0].Selected = true;
                    this.grdAccounts.Items[0].Focused = true;
                    controller.RemoveAccount(SelectedAccount);
                    controller.UpdateDisplay();
                }
            }
            grdAccounts.Focus();
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            if (SelectedAccount == -1)
            {
                MessageBox.Show("ERROR! You must select an account.");
            }
            else
            {
                frmTransferOrWithdraw whatToDo = new frmTransferOrWithdraw(this.controller);
                whatToDo.ShowDialog();
                controller.View = this;
                double balance = double.Parse(grdAccounts.SelectedItems[0].SubItems[2].Text.Substring(1));
                if (controller.tF == "transfer")
                {
                    while (balance != 0)
                    {
                        frmNewTransaction transfer = new frmNewTransaction(this.controller, frmNewTransaction.TransactionType.Transfer);
                        DialogResult res = transfer.ShowDialog();
                        controller.View = this;
                        if (res == DialogResult.OK)
                        {
                            if (!controller.Transfer(SelectedAccount, transfer.SelectedAccount, transfer.Amount, transfer.Memo))
                                MessageBox.Show("ERROR! The transfer transaction could not be added!");
                            this.grdAccounts.Items[0].Selected = true;
                            this.grdAccounts.Items[0].Focused = true;
                            balance = double.Parse(grdAccounts.SelectedItems[0].SubItems[2].Text.Substring(1));
                            if (balance != 0)
                            {
                                MessageBox.Show("There is still a remaining balance.", "Did not empty account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                this.grdAccounts.Items[0].Selected = true;
                                this.grdAccounts.Items[0].Focused = true;
                                controller.RemoveAccount(SelectedAccount);
                                controller.UpdateDisplay();
                            }
                        }
                        else
                            break;
                    }
                }
                else if (controller.tF == "withdraw")
                {
                    DialogResult res = MessageBox.Show("This change will be permanent.  Are you sure you would like to close the account?", "Permanent Change!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK)
                    {
                        controller.RemoveAccount(SelectedAccount); 
                    }                    
                }                  
                controller.UpdateDisplay();
            }
            grdAccounts.Focus();
        }

        private void btnQuickLoan_Click(object sender, EventArgs e)
        {
            frmQuickLoanTable qlt = new frmQuickLoanTable();
            DialogResult res = qlt.ShowDialog();
            grdAccounts.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (SelectedAccount >= 0)
            {
                frmSearchTransactions st = new frmSearchTransactions();
                DialogResult res = st.ShowDialog();
                frmViewTransactions trans = new frmViewTransactions(this.controller);
                trans.SearchResults = true;
                if (controller.SearchTransactions(SelectedAccount, st.Index, st.Search))
                    trans.ShowDialog();
                else
                    MessageBox.Show("No transactions were found!");
                controller.View = this;
                grdAccounts.Focus();
            }
            else
            {
                MessageBox.Show("ERROR! You must select an account!");
                grdAccounts.Focus();
            }
        }

        private void frmBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to save any unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                controller.SaveFile();
        }

    }
}
