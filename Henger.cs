using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    public class Henger
    {
        double magassag;
        double sugar;
        static int szuletesSzamlalo = 0;

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo++;

        }

        public double GetMagassag { get => magassag;  }
        public double GetSugar { get => sugar; }
        public static int SzuletesSzamlalo { get => Henger.szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Pow(sugar,2) * Math.PI * magassag;
        }
        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(),2)}; sugár:{GetSugar}; magasság:{GetMagassag};";
        }
    }
}
