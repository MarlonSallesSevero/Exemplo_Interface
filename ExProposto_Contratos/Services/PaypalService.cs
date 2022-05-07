namespace Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double TaxPerct = 0.02;
        private const double TaxParcela = 0.01;

        public double TaxMensal(double valor, int meses)
        {
            return valor * TaxParcela * meses;
        }

        public double TaxPay(double valor)
        {
            return valor * TaxPerct;
        }
    }
}
