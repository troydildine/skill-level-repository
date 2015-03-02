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
    public partial class frmQuickLoanTable : Form
    {
        public frmQuickLoanTable()
        {
            InitializeComponent();
        }

        private void btnGenerateTable_Click(object sender, EventArgs e)
        {
            grdQuickLoanTable.Items.Clear();
            double loanAmount, interestRate, period, payment;
            string errors = "";
            if(!double.TryParse(txtLoanAmount.Text, out loanAmount))
                errors += "ERROR! You must enter a valid loan amount! \n";
            if(!double.TryParse(txtInterestRate.Text, out interestRate))
                errors += "ERROR! You must enter a valid interest rate! \n";
            if(!double.TryParse(txtPeriod.Text, out period))
                errors += "ERROR! You must enter a valid loan repayment period! \n";
            if (errors.Equals(""))
            {
                interestRate = interestRate / 100 / 12;
                payment = (interestRate + interestRate / (Math.Pow(1 + interestRate, period) - 1)) * loanAmount;
                for (int i = 0; i < period; i++)
                {
                    double interestPart = interestRate * loanAmount;
                    double principalPart = payment - interestPart;
                    loanAmount = loanAmount - principalPart;
                    grdQuickLoanTable.Items.Add((i+1).ToString());
                    grdQuickLoanTable.Items[i].SubItems.Add(payment.ToString("C"));
                    grdQuickLoanTable.Items[i].SubItems.Add(interestPart.ToString("C"));
                    grdQuickLoanTable.Items[i].SubItems.Add(principalPart.ToString("C"));
                    grdQuickLoanTable.Items[i].SubItems.Add(loanAmount.ToString("C"));
                }
            }
            else
                MessageBox.Show(errors);
        }
    }
}
