using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUI
{
    [Serializable]
    public class Transaction : IComparable<Transaction>
    {
        #region Fields

        //Fields
        private int transactionId;
        private DateTime transactionDate;
        private double transactionAmount;

        #endregion

        #region Properties

        //Properties
        public int TransactionId
        {
            get { return transactionId; }
        }

        public DateTime TransactionDate
        {
            get { return transactionDate; }
        }

        public Double TransactionAmount
        {
            get { return transactionAmount; }
        }

        public String TransactionMemo
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        //Constructors

        public Transaction(int id)
        {
            this.transactionId = id;
            this.transactionDate = DateTime.Now;
            this.transactionAmount = 0;
            this.TransactionMemo = "";
        }

        public Transaction(int id, DateTime date, double amount, string memo)
        {
            this.transactionId = id;
            this.transactionDate = date;
            this.transactionAmount = amount;
            this.TransactionMemo = memo;
        }

        #endregion

        #region Methods

        //Methods

        public int CompareTo(Transaction other)
        {
            return this.TransactionId.CompareTo(other.TransactionId);
        }

        #endregion

    }
}
