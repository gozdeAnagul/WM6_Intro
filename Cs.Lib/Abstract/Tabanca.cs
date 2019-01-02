using Cs.Lib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Lib
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        protected int _sarjorKapasitesi, _kalanFisek;
        public abstract int AtesEt();
        public int SarjorKapatisesi
        {
            get => _sarjorKapasitesi;
        }
        public int KalanFisek
        {
            get => _kalanFisek;
        }

        public int AtisKatsayisi => throw new NotImplementedException();

        public abstract int YenidenDoldur();
    }
}
