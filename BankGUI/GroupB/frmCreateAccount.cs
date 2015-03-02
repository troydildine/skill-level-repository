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
    public partial class frmCreateAccount : Form
    {
        public int AccountNumber
        {
            get { return int.Parse(txtAccountNumber.Text); }
        }

        public string AccountName
        {
            get { return txtAccountName.Text; }
        }

        public double InitialBalance
        {
            get { return double.Parse(txtIntialBalance.Text); }
        }

        public double InterestRate
        {
            get { return double.Parse(txtInterestRate.Text) / 100; }
        }

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string errors = "";
            try
            {
                if (AccountNumber < 0 || AccountNumber > 99999)
                    errors += "ERROR! You must enter a 5-digit account number! \n";
            }
            catch
            {
                errors += "ERROR! You must enter a valid Account Number! \n";
            }
            if (AccountName == "")
                errors += "ERROR! You must enter an Account Name! \n";
            try
            {
                if (InitialBalance == 0) ;
            }
            catch
            {
                errors += "ERROR! You must enter a valid Initial Balance! \n";
            }
            try
            {
                if (InterestRate == 0) ;
            }
            catch
            {
                errors += "ERROR! You must enter a valid Interest Rate! \n";
            }
            if (errors != "")
                MessageBox.Show(errors);
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
