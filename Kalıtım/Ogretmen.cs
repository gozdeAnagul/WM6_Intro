using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
    public class Ogretmen:Kisi
    {
       
       //kalıtımla tüm nesneler aktarılır sadece private olanlar aktarılamaz.
       //protected sadece kalıtımla aktarılır. aile içi aktarılan ibilgiler korumalı olarak
        //outo property
        //get set yaz brak
        //tam full propery get set içini doldur.aşağıdaki outo property

            //hocanın örneğini incele
        public Branslar Brans{ get; set; }
        public decimal maas { get; set; }
    }
}
