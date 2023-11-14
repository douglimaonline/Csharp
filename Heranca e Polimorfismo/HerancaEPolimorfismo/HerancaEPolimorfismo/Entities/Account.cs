using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEPolimorfismo
{
    internal class Account
    {
        public int number { get; private set; }
        public string holder { get; private set; }
        public double balance { get; private protected set; } // Modificador de acesso que permite ser utilizado numa subclasse.

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public void Withdraw(double value)
        {
            balance -= value;
        }

        public void Deposit(double value)
        {
            balance += value;
        }
    }
}