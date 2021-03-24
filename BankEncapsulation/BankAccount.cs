using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double value)
        {
            _balance += value;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
