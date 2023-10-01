using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Converter
    {
        double uah;
        public void SetUah(double value)
        {
            uah = value;
        }
        public double GetUah()
        {
            return uah;
        }
        double usd;
        public double GetUsd()
        {
            return usd;
        }
        double eur;
        public double GetEur()
        {
            return eur;
        }
        double pln;
        public double GetPln()
        {
            return pln;
        }
        public double nUsd;
        public void SetNUsd(double value)
        {
            nUsd = value;
        }
        public double MethodUsd()
        {
            return nUsd;
        }
        static double MethodUsd(double usd, double uah, double nUsd)
        {
            nUsd = usd * uah;
            return nUsd;
        }
        public Converter(double usd, double eur, double pln, double uah)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
            Console.Write("Enter the emount (UAH):");
            this.uah = Convert.ToDouble(Console.ReadLine());
        }
    }
}
