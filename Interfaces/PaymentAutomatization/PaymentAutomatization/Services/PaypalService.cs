namespace PaymentAutomatization.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
