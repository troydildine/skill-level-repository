using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUI
{
    [Serializable]
    public class Account : IComparable<Account>
    {
        #region Fields

        //Fields
        private int accountNumber;
        private double balance;
        private DateTime openDate;
        private double interestRate;
        List<Transaction> transactionList;

        #endregion

        #region Properties

        //Properties
        public String AccountName { get; set; }

        public int AccountNumber 
        { 
            get { return accountNumber; }
        }

        public Double InterestRate
        {
            get { return interestRate; }
        }

        public DateTime OpenDate
        {
            get { return openDate; }
        }

        public Double Balance
        {
            get { return balance; }
        }

        #endregion

        #region Constructors
        //Constructors
        public Account(int acctNbr)
        {
            this.accountNumber = acctNbr;
        }

        public Account(string passedAcctName, int passedAccntNbr, double passedInitBl, double passedIntRate, DateTime openDate)
        {
            AccountName = passedAcctName;
            accountNumber = passedAccntNbr;
            balance = passedInitBl;
            interestRate = passedIntRate;
            this.openDate = openDate;
            transactionList = new List<Transaction>();
            transactionList.Add(new Transaction(0, DateTime.Today, balance, "Initial Balance"));
        }

        #endregion
                
        #region Methods
        //Methods

        public int CompareTo(Account other)
        {
            return this.AccountNumber.CompareTo(other.AccountNumber);
        }

        public bool AddTransaction(Transaction t)
        {
            int index = transactionList.BinarySearch(t);
            if (index < 0)
            {
                transactionList.Insert(~index, t);
                this.balance += t.TransactionAmount;
                return true;
            }
            return false;
        }

        public List<Transaction> Transactions()
        {
            return this.transactionList.ToList();
        }

        public override string ToString()
        {
            return AccountName;
        }

        #endregion

    }
}
