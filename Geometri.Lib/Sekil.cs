using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    //Şekil clasıını public yap ki mantık hatası olmasın. çnkü internal
    public abstract class Sekil
        //şeilin instance alınmaması için yani şekilden örnek almak saçma olur.
    {
        public double X { get; set; }

        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public virtual double AlanHesapla()
        {
            return (Math.Pow(X, 2));
        }
        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
