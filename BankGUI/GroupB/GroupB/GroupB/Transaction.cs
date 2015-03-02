using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupB
{
    class Transaction
    {
        #region Fields

        //Fields
        private string transactionName;
        private string transactionType;
        private string transactionAccount;
        private double transactionAmount;

        #endregion

        #region Properties

        //Properties
        public String TransactionName
        {
            get { return transactionName; }
        }

        public String TransactionType
        {
            get { return transactionType; }
        }

        public String TransactionAccount
        {
            get { return transactionAccount; }
        }

        public Double TransactionAmount
        {
            get { return transactionAmount; }
        }

        #endregion

        #region Constructors

        //Constructors

        #endregion

        #region Methods

        //Methods

        #endregion
    }
}
