using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App_v0._1.Classes
{
    // Static class to manage bank-related operations
    public static class BankManager
    {
        // Private field to store the balance, initialized to 4000
        private static decimal _balance = 4000m;

        // Event to notify subscribers when the balance changes
        public static event EventHandler<decimal> BalanceChanged;

        // Property to get and set the balance
        public static decimal Balance
        {
            get { return _balance; }
            private set
            {
                _balance = value;
                // Invoke the BalanceChanged event when the balance is updated
                BalanceChanged?.Invoke(null, _balance);
            }
        }

        // Method to add money to the balance
        public static void AddMoney(decimal amount)
        {
            // Only add the amount if it's positive
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    }
}
