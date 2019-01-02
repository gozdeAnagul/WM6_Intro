using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            //Matematiksel Operatörler
            int sayi1 = 6;
            int sayi2 = 10;
            double sayi = 0;
            sayi = sayi2 / sayi1;

            //mod % 
            //sayi1 = sayi2 % 3;

            //mantıksal operatörler
            //< > <= >= == != & | && || ! true / false döndürür.

            bool dogruMu = sayi1 % 2 == 0;

            //if (sayi1 % 2 == 0)
            //    Console.WriteLine("çifttir");
            //else
            //    Console.WriteLine("tektir");

            Console.WriteLine("sayi1 " + (dogruMu ? "çifttir" : "tektir"));

            double ortalama = 55;

            if (ortalama < 50)
                Console.WriteLine("kaldınız");
            else if (ortalama < 90)
                Console.WriteLine("geçtiniz");
            else
                Console.WriteLine("üstün başarı");

            DayOfWeek bugun = DateTime.Now.DayOfWeek;

            switch (bugun)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("sunday");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("no no no");
                    break;
            }

            ////döngüler
            //while(true)
            //{
            //    Console.WriteLine(DateTime.Now);
            //    if (DateTime.Now.Second < 10 || DateTime.Now.Second > 50)
            //    break;
            //}


            do
            {
                Console.WriteLine(DateTime.Now);
                if (DateTime.Now.Second < 10 || DateTime.Now.Second > 50)
                    break;
            } while (true);

            for ( int i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine("i");
            }

        }
    }
}
