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

        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public double ConvertToUSD(double amount)
        {
            return amount / usd;
        }

        public double ConvertToEUR(double amount)
        {
            return amount / eur;
        }

        public double ConvertToPLN(double amount)
        {
            return amount / pln;
        }

        public double ConvertFromUSD(double amount)
        {
            return amount * usd;
        }

        public double ConvertFromEUR(double amount)
        {
            return amount * eur;
        }

        public double ConvertFromPLN(double amount)
        {
            return amount * pln;
        }
    }
}
