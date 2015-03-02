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
    public partial class frmViewTransactions : Form, IBankView
    {
        private BankController controller;

        public BankController Controller
        {
            set
            {
                this.controller = value;
            }
        }

        public string PersonName
        {
            set { throw new NotImplementedException(); }
        }

        public List<Account> AccountsList
        {
            set
            {
                lblAccount.Text = "Transactions for " + value[0].AccountName;
            }
        }

        public List<Transaction> Transactions
        {
            set
            {
                grdTransactions.Items.Clear();
                foreach (Transaction t in value)
                {
                    ListViewItem parent = grdTransactions.Items.Add(t.TransactionId.ToString().PadLeft(5,'0'));
                    parent.SubItems.Add(t.TransactionDate.ToString("d"));
                    parent.SubItems.Add(t.TransactionAmount.ToString("C"));
                    parent.SubItems.Add(t.TransactionMemo);
                }
            }
        }

        public int SelectedAccount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool SearchResults
        {
            set
            {
                if (value)
                {
                    lblAccount.Text = "Transactions Found";
                }
            }
        }

        public frmViewTransactions(BankController c)
        {
            InitializeComponent();
            this.controller = c;
            controller.View = this;
        }
    }
}
