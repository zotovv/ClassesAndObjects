using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Converter
    {
        double usd, eur, uah;

        public Converter(double usd, double eur, double uah)
        {
            this.usd = usd;
            this.eur = eur;
            this.uah = uah;
        }

        public void ToUsd(double rubSum)
        {
            Console.WriteLine(rubSum / usd);
        }

        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        public void ToEur(double rubSum)
        {
            Console.WriteLine(rubSum / eur);
        }

        public void FromEur(double eurSum)
        {
            Console.WriteLine(eurSum * eur);
        }

        public void ToUah(double rubSum)
        {
            Console.WriteLine(rubSum / uah);
        }

        public void FromUah(double uahSum)
        {
            Console.WriteLine(uahSum*uah);
        }
    }
}
