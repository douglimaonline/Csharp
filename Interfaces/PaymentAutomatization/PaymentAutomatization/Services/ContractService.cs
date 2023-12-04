using PaymentAutomatization.Entities;

namespace PaymentAutomatization.Services
{
    internal class ContractService
    {
        public void ProcessContract(Contract contract, int mounths, IOnlinePaymentService onlinePaymentService)
        {
            double _startValue = contract.TotalValue / mounths;

            for (int i = 0; i < mounths; i++)
            {                
                double _interest = _startValue * (0.01 * (i+1));
                double _fee = onlinePaymentService.PaymentFee(_startValue + _interest);

                double _installmentValue = _startValue + _interest + _fee;

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i+1), _installmentValue));
            }
        }
    }
}
