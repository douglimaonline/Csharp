using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAutomatization.Services
{
    internal class PixService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.05;
        }
    }
}
