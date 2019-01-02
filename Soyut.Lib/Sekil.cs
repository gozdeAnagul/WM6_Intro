using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut.Lib
{
    public abstract class Sekil
    {
        //bastract  nesnelerin örneği alınamaz
        //içerisinde abstract olmayan nesler doğrudan aktarılır
        public double X { get; set; }
        public abstract double CevreHesapla();


        public abstract double AlanHesapla();

        public abstract double KosegenHesapla();
       
    }
}
