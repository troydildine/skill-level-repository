using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BankGUI
{
    public class BankController
    {
        private IBankView view;
        private Person activePerson;
        private int nextTransactionId;
        public string tF;

        public IBankView View
        {
            set
            {
                this.view = value;
            }
        }

        public BankController(frmBank view)
        {
            this.view = view;
            if (File.Exists("bank.bnk"))
            {
                ImportOldFiles();
            }
            else
            {
                BinaryFormatter reader = new BinaryFormatter();
                FileStream infile = null;
                infile = new FileStream("bank.db", FileMode.Open, FileAccess.Read);
                Person p = (Person)reader.Deserialize(infile);
                nextTransactionId = (int)reader.Deserialize(infile);
                infile.Close();
                activePerson = p;
            }
            UpdateDisplay();
        }

        public bool SaveFile()
        {
            BinaryFormatter output = new BinaryFormatter();
            FileStream outfile = new FileStream("bank.db", FileMode.Create, FileAccess.Write);
            try
            {
                output.Serialize(outfile, activePerson);
                output.Serialize(outfile, nextTransactionId);
                outfile.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Transaction ParseTransaction(String line)
        {
            try
            {
                int transactionId = int.Parse(line.Substring(0, 5));
                String date = line.Substring(6, 10);
                DateTime dt = new DateTime(int.Parse(date.Substring(6)), int.Parse(date.Substring(0, 2)), int.Parse(date.Substring(3, 2)));
                String action = line.Substring(17, 1);
                int accountId = int.Parse(line.Substring(18, 5));
                double amount = double.Parse(line.Substring(24, 15).Trim().Substring(1), System.Globalization.NumberStyles.Currency);
                double balance = double.Parse(line.Substring(39, 15).Trim(), System.Globalization.NumberStyles.Currency);
                String memo = line.Substring(54).Trim();
                if (action == "W" || action == "-" || action == "F")
                    amount = -amount;
                Transaction transaction = new Transaction(this.nextTransactionId, dt, amount, memo);
                return transaction;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void ImportOldFiles()
        {
            activePerson = new Person(1, "Joe", "Smith", "SuperSecretPassword");
            nextTransactionId = 1;
            StreamReader infile = new StreamReader("bank.bnk");
            string lines = infile.ReadToEnd();
            infile.Close();
            String[] splits = { "\r\n" };
            String[] afterSplit = lines.Split(splits, StringSplitOptions.None);
            for (int i = 0; i < afterSplit.Length; i++)
            {
                String acctLine = afterSplit[i];
                int accountNumber = int.Parse(acctLine.Substring(0, 5));
                string accountName = acctLine.Substring(25);
                double interestRate = double.Parse(acctLine.Substring(15, 10));
                String filename = acctLine.Substring(0, 5) + ".bnk";
                StreamReader inTrans = new StreamReader(filename);
                string firstLine = inTrans.ReadLine();
                String date = firstLine.Substring(6, 10);
                DateTime dt = new DateTime(int.Parse(date.Substring(6)), int.Parse(date.Substring(0, 2)), int.Parse(date.Substring(3, 2)));
                String action = firstLine.Substring(17, 1);
                double amount = double.Parse(firstLine.Substring(24, 15).Trim().Substring(1), System.Globalization.NumberStyles.Currency);
                double balance = double.Parse(firstLine.Substring(39, 15).Trim(), System.Globalization.NumberStyles.Currency);
                if (action == "W" || action == "-" || action == "F")
                    amount = -amount;
                double initialBalance = balance - amount;
                inTrans.Close();
                Account a = new Account(accountName, accountNumber, initialBalance, interestRate, dt);
                activePerson.AddAccount(a);
                inTrans = new StreamReader(filename);
                while (!inTrans.EndOfStream)
                {
                    String line = inTrans.ReadLine();
                    Transaction t = ParseTransaction(line);
                    nextTransactionId++;
                    a.AddTransaction(t);
                }
                inTrans.Close();
                System.IO.File.Move(filename, filename + ".old");
            }
            System.IO.File.Move("bank.bnk", "bank.bnk.old");
            SaveFile();
        }

        public bool NewAccount(Account a)
        {
            if (activePerson.AddAccount(a))
            {
                UpdateDisplay();
                return true;
            }
            return false;
        }

        public void UpdateDisplay()
        {
            view.PersonName = activePerson.First;
            view.AccountsList = activePerson.Accounts();
        }

        public bool Deposit(int accountNumber, double deposit, string memo)
        {
            List<Account> accounts = activePerson.Accounts();
            Account a = accounts[accounts.BinarySearch(new Account(accountNumber))];
            if (a.AddTransaction(new Transaction(nextTransactionId, DateTime.Today, Math.Abs(deposit), memo)))
            {
                nextTransactionId++;
                UpdateDisplay();
                return true;
            }
            return false;
        }

        public bool Withdraw(int accountNumber, double withdrawal, string memo)
        {
            List<Account> accounts = activePerson.Accounts();
            Account a = accounts[accounts.BinarySearch(new Account(accountNumber))];
            if (a.AddTransaction(new Transaction(nextTransactionId, DateTime.Today, -Math.Abs(withdrawal), memo)))
            {
                nextTransactionId++;
                UpdateDisplay();
                return true;
            }
            return false;
        }

        public bool Transfer(int accountNumber, int accountNumberToTransfer, double amount, string memo)
        {
            List<Account> accounts = activePerson.Accounts();
            Account a = accounts[accounts.BinarySearch(new Account(accountNumber))];
            Account b = accounts[accounts.BinarySearch(new Account(accountNumberToTransfer))];
            if (a.AddTransaction(new Transaction(nextTransactionId, DateTime.Today, -Math.Abs(amount), memo)) && b.AddTransaction(new Transaction(nextTransactionId, DateTime.Today, Math.Abs(amount), memo)))
            {
                nextTransactionId++;
                UpdateDisplay();
                return true;
            }
            return false;
        }

        public bool ViewTransactions(int accountNumber)
        {
            List<Account> accounts = activePerson.Accounts();
            Account a = accounts[accounts.BinarySearch(new Account(accountNumber))];
            view.Transactions = a.Transactions();
            return true;
        }

        public void PayInterest()
        {            
            List<Account> accounts = activePerson.Accounts();            
            foreach (Account a in accounts)
            {
                if (a.Balance > 0 && a.InterestRate > 0)
                {
                    a.AddTransaction(new Transaction(nextTransactionId, DateTime.Today, a.Balance * a.InterestRate, "Interest Paid"));
                    Deposit(a.AccountNumber, a.Balance * a.InterestRate, "Interest Paid");
                    nextTransactionId++;
                    UpdateDisplay();
                }                
            }
            view.AccountsList = accounts;
        }

        public string TransferOrWithdraw(string tOrF)
        {
            if (tOrF == "transfer")
                tF = "transfer";
            else if (tOrF == "withdraw")
                tF = "withdraw";
            else
                tF = "cancel";
            return tF;
        }

        public void CloseAccount()
        {
            List<Account> accounts = activePerson.Accounts();
            view.AccountsList = accounts;
        }

        public void RemoveAccount(int account)
        {
            List<Account> accounts = activePerson.Accounts();            
            Account a = accounts[accounts.BinarySearch(new Account(account))];
            activePerson.CloseAccount(a);
            view.AccountsList = accounts;
        }

        public bool SearchTransactions(int accountNumber, int index, string search)
        {
            List<Account> accounts = activePerson.Accounts();
            Account a = accounts[accounts.BinarySearch(new Account(accountNumber))];
            IEnumerable<Transaction> transactions;
            switch(index)
            {
                case 0:
                    //Transaction ID
                    transactions =
                        from t in a.Transactions()
                        where t.TransactionId == int.Parse(search)
                        orderby t.TransactionId
                        select t;
                    break;
                case 1:
                    //Date
                    transactions =
                        from t in a.Transactions()
                        where t.TransactionDate == DateTime.Parse(search)
                        orderby t.TransactionId
                        select t;
                    break;

                    //Amount
                case 2:
                    transactions =
                        from t in a.Transactions()
                        where t.TransactionAmount.ToString().Contains(search)
                        orderby t.TransactionId
                        select t;
                    break;
                    //Memo
                default:
                    transactions =
                        from t in a.Transactions()
                        where t.TransactionMemo.Contains(search)
                        orderby t.TransactionId
                        select t;
                    break;
            }
            if (transactions.ToList().Count == 0)
                return false;
            view.Transactions = transactions.ToList();
            return true;
        }
    }
}
