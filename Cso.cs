using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    public class Cso : Henger
    {
        double falVastagsag;
        public Cso(double sugar, double magassag, double falVastagsag = 1) : base(sugar, magassag) {
            this.falVastagsag = falVastagsag;
        }
        public override double Terfogat()
        {
            return base.Terfogat() - (Math.Pow(base.GetSugar - this.falVastagsag, 2)*Math.PI*base.GetMagassag);
        }
        public override string ToString()
        {
            return base.ToString() + $" falvastagsága:{falVastagsag}";
        }
    }
}
