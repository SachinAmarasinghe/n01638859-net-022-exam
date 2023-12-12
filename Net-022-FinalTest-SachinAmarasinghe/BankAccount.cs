using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_022_FinalTest_SachinAmarasinghe
{
    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal NewBalance { get; }

        public BalanceChangedEventArgs(decimal newBalance)
        {
            NewBalance = newBalance;
        }
    }

    public delegate void BalanceChangedEventHandler(object sender, BalanceChangedEventArgs e);

    public class BankAccount
    {
        private decimal _balance;

        public event BalanceChangedEventHandler BalanceChanged;

        public void OnBalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Bank Account: Balance changed to ${e.NewBalance}");
        }

        public void UpdateBalance(decimal newBalance)
        {
            _balance = newBalance;
            OnBalanceChanged(this, new BalanceChangedEventArgs(_balance));
        }
    }
}
