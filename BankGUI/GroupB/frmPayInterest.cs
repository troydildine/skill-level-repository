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
    //If an account is negative or has a 0% interest rate interest will not be paid
    //For now the interest paid is Balance x Interest Rate
    
    public partial class frmPayInterest : Form, IBankView
    {
        private BankController controller;

        public BankController Controller
        {
            set
            {
                this.controller = value;
            }
        }

        public frmPayInterest(BankController c)
        {
            InitializeComponent();
            this.controller = c;
            controller.View = this;
            controller.PayInterest();
        }

        private void grdTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string PersonName
        {
            set { }
        }

        public List<Account> AccountsList
        {
            set
            {                
                grdPayInterest.Items.Clear();
                foreach (Account a in value)
                {
                    ListViewItem parent = grdPayInterest.Items.Add(a.AccountNumber.ToString().PadLeft(5, '0'));
                    parent.SubItems.Add(a.AccountName);
                    if (a.Balance > 0 && a.InterestRate > 0)
                    {
                        //parent.SubItems.Add("");
                        parent.SubItems.Add((a.Balance - (a.Balance / (1+a.InterestRate))).ToString("C"));
                    }
                    else
                    {
                        //parent.SubItems.Add("00000");
                        parent.SubItems.Add(0.ToString("C"));
                        
                    }
                    parent.SubItems.Add(a.Balance.ToString("C"));
                }
            }
            
        }

        public List<Transaction> Transactions
        {            
            set { throw new NotImplementedException(); }
        }

        public int SelectedAccount
        {
            get { throw new NotImplementedException(); }
        }
    }
}
