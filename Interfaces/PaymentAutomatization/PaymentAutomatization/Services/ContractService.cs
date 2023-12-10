using PaymentAutomatization.Entities;
using PaymentAutomatization.Interfaces;


namespace PaymentAutomatization.Services
{
    internal class ContractService
    {
        public void ProcessContract(Contract contract, int mounths, IOnlinePayment onlinePaymentService, string PaymentFormat)
        {
            double _startValue = contract.TotalValue / mounths;
            double _fee = 0;

            for (int i = 0; i < mounths; i++)
            {
                double _interest = _startValue * (0.01 * (i + 1));

                if (PaymentFormat == "Pix")
                {
                    _fee = onlinePaymentService.PixService(_startValue + _interest);
                } else
                {
                    _fee = onlinePaymentService.PaypalService(_startValue + _interest);
                }
                double _installmentValue = _startValue + _interest + _fee;

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i + 1), _installmentValue));
            }
        }
    }
}
