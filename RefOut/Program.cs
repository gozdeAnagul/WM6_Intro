using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            a = b;
            b = 20;
            //Console.WriteLine(a);

            int[] dizi1 = new int[5];
            dizi1[0] = 5;

            int[] dizi2 = new int[6];
            dizi2[0] = 10;
            //eşitleme varsa birinde yapılan değişiklik ikisinide etkiler.
            //yani dizi1 de değişiklik yapsamda dizi 2 etkilenir.
            dizi1 = dizi2;
            dizi1[0] = 20;
            Console.WriteLine(dizi2[0]);

            //dizi2 nin boyutunu değiştirince içindeki bilgilerde silinmis oldu. yani value ları kaybetmiş olduk.
            //dizi2 = new int[10];

            int sayi = 5;
            RefTest(ref sayi);

            //ref attığın değerin method içinde işlem yapmasını sağlar ama adresle
            Console.WriteLine(sayi);

            Array.Resize(ref dizi1, 5);

            int girilen = 0;

            //yazığımız methodda yazılan değer int e çevriliyorsa işlem yapılır yapılamıyorsa hata mesajı çıkar ve sonlandırılır
            if (SayiMi(out girilen))
                Console.WriteLine(girilen * girilen);

            //out için yazılan hazır method aşağıda yazdığımız int methodu ile aynı işi yapar.dışarıda gireceğimiz değer strin olarak algılanır ama sonra int e çevrilir çevrilmiyorsa hata verir.

            if (int.TryParse(Console.ReadLine(), out girilen))
                Console.WriteLine(girilen * girilen);

        }
        static bool SayiMi(out int sayi)
        {
            try
            {
                sayi = int.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
              
            }
            sayi = 0;
            return false;
        }

        static void RefTest(ref int a)
        {
            a *= a;
        }
    }
}
