using System;
using System.Collections.Generic;
namespace Entities
{
    internal class Contrato
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }

        public List<Parcela> parcelas { get; set; }

        public Contrato(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            parcelas = new List<Parcela>();
        }
        public void addParcelas(Parcela parcela)
        {
            parcelas.Add(parcela);
        }
    }
}
