using System;
using System.Globalization;
namespace Entities
{
    internal class Parcela
    {
        public DateTime dvencDate { get; set; }
        public double valor { get; set; }

        public Parcela(DateTime dvencDate, double valor)
        {
            this.dvencDate = dvencDate;
            this.valor = valor;
        }

        public override string ToString()
        {
            return dvencDate.ToString("dd/MM/yyy")
                + " - " + valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
