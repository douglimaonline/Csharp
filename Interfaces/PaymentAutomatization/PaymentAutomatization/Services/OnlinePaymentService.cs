using PaymentAutomatization.Interfaces;

namespace PaymentAutomatization.Services
{
    internal class OnlinePaymentService : IOnlinePayment
    {
        public double PaypalService(double amount)
        {
            return amount * 0.02;
        }
        public double PixService(double amount)
        {
            return amount * 0.05;
        }
    }
}
