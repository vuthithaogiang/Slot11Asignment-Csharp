using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot11Asignment.BankAccount
{
    public delegate void BalanceChangedHandler(decimal newBalance);
    public class BankAccount
    {
        private decimal balance;

        public event BalanceChangedHandler BalanceChanged;

        public BankAccount()
        {
            BalanceChanged += SendSMSUpdateBallance;
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                BalanceChanged(amount);
                SendSMSUpdateBallance(amount);
                return true;
            }
            return false;
        }

        public bool WithDraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                BalanceChanged(amount);
                SendSMSUpdateBallance(amount);


                return true;
            }
            return false;
        }

        public void SendSMSUpdateBallance(decimal amount)
        {
            // send SMS
        }
    }
}
