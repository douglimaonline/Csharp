namespace PaymentAutomatization.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
    }
}
