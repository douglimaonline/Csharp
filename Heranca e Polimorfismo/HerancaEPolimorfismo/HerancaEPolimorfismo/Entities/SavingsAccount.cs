using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEPolimorfismo.Entities
{
    internal sealed class SavingsAccount : Account
    {
        public double interestRate { get; private set; }
        public SavingsAccount() : base()
        {
        }

        public SavingsAccount(double interestRate, int number, string holder, double balance) : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }
        public void updateBalance()
        {
            balance = balance + (balance * (interestRate / 100));
        }
    }
}
