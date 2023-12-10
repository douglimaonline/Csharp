namespace PaymentAutomatization.Interfaces
{
    internal interface IOnlinePayment
    {
        double PaypalService(double amount);
        double PixService (double amount);
    }
}
