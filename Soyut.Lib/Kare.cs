using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    //implement edilemez: abstract yaptığımız şekil class içindeki cevre hesaplama yı abstract yaparsak hata verir çünkü override etmeliyiz.
    //kare clasıı ya atbract (soyut) olmalıdır fakat kare soyut değil
    public class Kare:Sekil
    {
        public override double CevreHesapla()
        {
            return 4 * X;
        }
        public override double AlanHesapla()
        {
            return X * X;
        }
        public override double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }


    }
}
