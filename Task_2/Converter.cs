using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double pln;
        public double AmountInUAH { get; set; }

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public double ConvertToUSD(double uah)
        {
            return uah / usd;
        }

        public double ConvertToEUR(double uah)
        {
            return uah / eur;
        }

        public double ConvertToPLN(double uah)
        {
            return uah / pln;
        }
    }
}
