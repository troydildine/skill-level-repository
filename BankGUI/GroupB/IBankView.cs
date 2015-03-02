using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGUI
{
    public interface IBankView
    {
        BankController Controller { set; }
        string PersonName { set; }
        List<Account> AccountsList { set; }
        List<Transaction> Transactions { set; }
        int SelectedAccount { get; }
    }
}
