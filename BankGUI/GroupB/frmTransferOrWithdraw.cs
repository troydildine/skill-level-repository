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
    public partial class frmTransferOrWithdraw : Form, IBankView
    {
        private BankController controller;

        //public Boolean TrueOrFalse { get; set; }

        public BankController Controller
        {
            set
            {
                this.controller = value;
            }
        }
        public frmTransferOrWithdraw(BankController c)
        {
            InitializeComponent();
            this.controller = c;
            controller.View = this;
            //controller.PayInterest();

        }

        #region IBankView Implementation
        public string PersonName
        {
            set { throw new NotImplementedException(); }
        }

        public List<Account> AccountsList
        {
            set { throw new NotImplementedException(); }
        }

        public List<Transaction> Transactions
        {
            set { throw new NotImplementedException(); }
        }

        public int SelectedAccount
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

        public void btnTransfer_Click(object sender, EventArgs e)
        {
            controller.TransferOrWithdraw("transfer");
            this.Close();
        }

        public void btnWithdraw_Click(object sender, EventArgs e)
        {
            controller.TransferOrWithdraw("withdraw");
            this.Close();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            controller.TransferOrWithdraw("cancel");
            this.Close();
        }
    }
}
