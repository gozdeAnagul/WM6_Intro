using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmacaOyunu_MesutHoca
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int hak = 6;
                int bilinen = 0;
                string[] sorular = { "zeytinburcu", "kahramanmaraş", "çanakkale", "hayrabolu" };
                Random rnd = new Random();
                string seciliSoru = sorular[rnd.Next(sorular.Length)];
                double puan = seciliSoru.Length * 100;
                char[] ekran = new char[seciliSoru.Length];
                for (int i = 0; i < seciliSoru.Length; i++)
                {
                    //cahar da tek tırnak.
                    ekran[i] = '_';
                }

                do
                {
                    foreach (var ee in ekran)
                        Console.Write(ee + " ");
                    //string format 1
                    //string a=string.Format("\n {0} harf. puan: {1} . kalan hak: {2}",seciliSoru.Length,puan,hak);
                    //string format 3
                    string ozet = $"\n---->{seciliSoru.Length} harf. puan: {puan} . kalan hak: {hak}";
                    //Console.WriteLine("\n" + seciliSoru.Length + "harf. puan: " + puan + ". kalan hak: " + hak);
                    Console.WriteLine(ozet);
                    string tahmin = Console.ReadLine().ToLower();

                    if (tahmin.Length == 1)
                    {
                        bool bildiMi = false;
                        bool girildiMi = false;
                        for (int i = 0; i < ekran.Length; i++)
                        {
                            if (ekran[i] == tahmin[0])
                            {
                                girildiMi = true;

                                break;

                            }
                        }
                        //if altında parantez kullanmadan for kullanabiliyoruz
                        if (!girildiMi)
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                //convert to char ta char[0] aynı değeri verir çünkü tek karakterli.
                                if (seciliSoru[i] == tahmin[0])
                                {
                                    bildiMi = true;
                                    ekran[i] = tahmin[0];
                                    bilinen++;
                                }
                            }
                        if (!bildiMi) //bildimi false ise
                        {
                            hak--;
                            puan *= 0.85;
                        }
                    }
                    else
                    {
                        if (tahmin == seciliSoru)
                            break;
                        hak--;
                        puan *= 0.85;
                    }


                    //bilinen seçili sorunun boyununa eşit değilse dönmesi için değilse yani eşitse çıkması için.
                } while (hak > 0 && bilinen != seciliSoru.Length);

                
                    Console.WriteLine(hak > 0 ? "Tebrikleeerrrr" : "Bilemediniz!!!!");
                

                Console.WriteLine("tekrar oynamak için e ye basınız");
                if (Console.ReadLine().ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
