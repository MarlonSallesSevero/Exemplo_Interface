using Entities;
using System;
namespace Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService _onlinePaymentService)
        {
            this._onlinePaymentService = _onlinePaymentService;
        }

        public void ProcessContrato(Contrato contrato, int meses)
        {
            double parcelaBase = contrato.totalValue / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime date = contrato.date.AddMonths(i);
                double parcelaAtt = parcelaBase + _onlinePaymentService.TaxMensal(parcelaBase, i);
                double parcelaFull = parcelaAtt + _onlinePaymentService.TaxPay(parcelaAtt);


                contrato.addParcelas(new Parcela(date, parcelaFull));
            }
        }
    }
}
