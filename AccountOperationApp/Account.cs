using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    internal class Account
    {
        public string accountNbr;
        public string customerName;
        public double balance;
        

        public void Deposit(double tk)
        {

            balance += tk;
           
        }
        public double Withdraw(double tk)
        {
            double balanceAfterWithdraw = balance - tk;
            if (balanceAfterWithdraw>=0)
            {
                balance= balanceAfterWithdraw;
                return balance;
            }
            else
            {
                return balance;
            }
        }

    }
}