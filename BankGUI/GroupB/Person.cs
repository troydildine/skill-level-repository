using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUI
{
    [Serializable]
    public class Person
    {
        #region Fields

        //Fields
        private int id;
        private string first;
        private string last;
        private string password;
        private List<Account> accounts;
        
        #endregion

        #region Properties

        //Properties
        public int ID
        {
            get { return id; }
        }
        public String First
        {
            get { return first; }
        }
        public String Last
        {
            get { return last; }
        }

        #endregion

        #region Constructors

        //Constructors
        public Person(int passedId, String passedFirst, String passedLast, String passedPassword)
        {
            id = passedId;
            first = passedFirst;
            last = passedLast;
            password = passedPassword;
            accounts = new List<Account>();
        }

        #endregion

        #region Methods

        //Methods

        public bool AddAccount(Account a)
        {
            int index = accounts.BinarySearch(a);
            if (index < 0)
            {
                accounts.Insert(~index, a);
                return true;
            }
            return false;
        }

        public bool CloseAccount(Account a)
        {
            if(accounts.Contains(a))
            {
                accounts.Remove(a);
                return true;
            }
            return false;
        }

        public List<Account> Accounts()
        {
            return this.accounts.ToList();
        }

        #endregion
    }
}
