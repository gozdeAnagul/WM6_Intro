using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Lib
{
    public class Dikdortgen:Sekil
    {
        public double Y { get; set; }
    
        /*
         * virtual keyword u oveeride edebilmemizi sağlamakta. Eğer override edilmezse base classda yazıldığı gibi çalışır. Override edildikten sonra,oveerride edilmşş class dan referans alınırsa kalıtım alan class oveeride edilmiş halini kalııtm alır. İsterse kendisi tekrar override eder. 
         */
        public override double AlanHesapla()
        {
            return X*Y;
        }
        public override double CevreHesapla()
        {
            return 2 * (X + Y);
        }
        public override double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y,2));
        }
  
    }
}
