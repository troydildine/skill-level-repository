using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupB
{
    class Account
    {
        #region Fields

        //Fields
        private int accountNumber;
        private double initialBalance;
        private double interestRate;
        List<Transaction> transactionList = new List<Transaction>();

        #endregion

        #region Properties

        //Properties
        public String AcountName { get; set; }
        public Double AccountNumber 
        { 
            get { return accountNumber; }
        }
        public Double InterestRate
        {
            get { return interestRate; }
        }

        #endregion

        #region Constructors
        //Constructors
        public Account(string passedAcctName, int passedAccntNbr, double passedInitBl, double passedIntRate)
        {
            AcountName = passedAcctName;
            accountNumber = passedAccntNbr;
            initialBalance = passedInitBl;
            interestRate = passedIntRate;
        }

        #endregion
                
        #region Methods
        //Methods

        #endregion
    }
}
