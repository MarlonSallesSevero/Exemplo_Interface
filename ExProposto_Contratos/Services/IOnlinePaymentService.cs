namespace Services
{
    interface IOnlinePaymentService
    {
        double TaxPay(double amount);   
        double TaxMensal(double amount, int meses);
    }
}
