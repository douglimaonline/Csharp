using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEPolimorfismo.Entities
{
    internal class BussinesAccount : Account
    {
        public double loanLimit { get; set; }

        public BussinesAccount(): base()
        {
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base( number, holder, balance)
        {
            this.loanLimit = loanLimit;
        }

        public void loan(double amount)
        {
            if (amount <= loanLimit)
            {
                balance += amount;
            }
        }
    }
}
