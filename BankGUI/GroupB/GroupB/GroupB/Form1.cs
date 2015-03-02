using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAccount_Click(object sender, EventArgs e)
        {
            SelectAccountForm saf = new SelectAccountForm();
            saf.Show();
        }

        private void btnPayInterest_Click(object sender, EventArgs e)
        {
            PayInterestForm pif = new PayInterestForm();
            pif.Show();
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            BalanceInquiryForm bif = new BalanceInquiryForm();
            bif.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm caf = new CreateAccountForm();
            caf.Show();
        }

        private void btnQuickLoanTable_Click(object sender, EventArgs e)
        {
            QuickLoanTableForm qltf = new QuickLoanTableForm();
            qltf.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
