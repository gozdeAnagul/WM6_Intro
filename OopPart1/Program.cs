using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Insan a = new Insan(5); //instance- nesne atama.
            //a.yas = 5;


           // constructer nesne oluşturulurken atamalarının da yapılması için kullanılıyor.
            Insan b = new Insan(10);
            //b.yas = 10;

            a = b;
            //a.yas = 20;
            //b.yas=20 yaparsak yine ikisi de 20 olur yani hangisini değişirse ötekide değişir.
            try
            {
                a.Yas = 20;
                a.DogumTarihi = new DateTime(2000, 1, 1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //nesne üstüne gel kalp varsa instance kilit varsa private dır.

            Console.WriteLine(b.yas);

            //constructer
            /*
             * insan b=new insan(); //constructer 
             * field e ihtiyacm var
             */

        }
    }
}
