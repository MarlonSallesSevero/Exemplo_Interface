using System;
using System.Globalization;
using Entities;
using Services;
namespace ExProposto_Contratos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());  
            Console.Write("Date (dd/MM/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value:");
            double totalValue = double.Parse(Console.ReadLine());
            Contrato contrato = new Contrato(n, date, totalValue);
            Console.Write("Enter number of installments:");
            int meses = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContrato(contrato, meses);
            Console.WriteLine("Parcelas: ");
            foreach (var parcelas in contrato.parcelas)
            {
                Console.WriteLine(parcelas);
            }
            string a = Console.ReadLine();
        }
    }
}
