using PaymentAutomatization.Entities;
using PaymentAutomatization.Interfaces;


namespace PaymentAutomatization.Services
{
    internal class ContractService
    {
        public void ProcessContract(Contract contract, int mounths, IOnlinePayment onlinePaymentService)
        {
            double _startValue = contract.TotalValue / mounths;

            for (int i = 0; i < mounths; i++)
            {                
                double _interest = _startValue * (0.01 * (i+1));
                double _fee = onlinePaymentService.PixService(_startValue + _interest);

                double _installmentValue = _startValue + _interest + _fee;

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i+1), _installmentValue));
            }
        }
    }
}
