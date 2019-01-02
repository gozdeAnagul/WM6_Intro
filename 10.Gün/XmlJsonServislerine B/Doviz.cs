using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerine_B
{
    public class Doviz
    {
        public string Kod{ get; set; }
        public string Ad { get; set; }
        public int Birim { get; set; }
        public decimal Alis { get; set; }
        public decimal  Satis{ get; set; }
        public override string ToString()
        {
            return $"{Birim} {Ad}" ;
}
    }
}
