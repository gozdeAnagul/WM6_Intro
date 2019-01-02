using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "istanbul", "ankara", "gaziantep", "zonguldak", "bursa" };
            Random rastgele = new Random();
            double puan = 1;

            do
            {

                string tutulan_Kelime = kelimeler[rastgele.Next(0, 5)];
                int khak = 6, kalan_hak;
                Console.WriteLine("Programin hafizasindaki isim {0} harfli\n", tutulan_Kelime.Length);
                string[] kelime = new string[tutulan_Kelime.Length];
                string harf = "";
                for (int k = 0; k < tutulan_Kelime.Length; k++)
                {
                    kelime[k] = "_".ToString();
                }

                Console.WriteLine();

                do
                {
                    try
                    {
                        harf = Convert.ToString(Console.ReadLine());
                        if (harf.Length < 1)
                            Console.WriteLine("lütfen istenilen girişi yapınız");
                   
                        if (harf.Length == 1)
                        {
                            for (int i = 1; i < 7; i++)
                            {
                                int adet = 0;
                                for (int z = 0; z < tutulan_Kelime.Length; z++)
                                {
                                    if (kelime[z] == "_")
                                    {
                                        adet++;
                                    }
                                }

                                for (int d = 0; d < tutulan_Kelime.Length; d++)
                                {
                                    if (tutulan_Kelime[d].ToString() == harf.ToString() || tutulan_Kelime[d].ToString() == harf.ToLower() || tutulan_Kelime[d].ToString() == harf.ToUpper())
                                    {
                                        kelime[d] = harf.ToString();
                                        --adet;
                                        
                                    }
                                }

                                for (int d = 0; d < tutulan_Kelime.Length; d++)
                                {
                                    Console.Write(" " + kelime[d].ToString());
                                }
                                if (adet != 0)
                                {
                                    kalan_hak = khak - i;
                                    

                                    Console.WriteLine("\n\nKalan sakli harf sayisi:{0}, Kalan Hakkiniz:{1} ", adet,kalan_hak);
                                    Console.Write("\nHarf Girin: ");
                                    harf = Convert.ToString(Console.ReadLine());
                                    kalan_hak--;
                                    puan = kelime.Length * 100 * 0.85;
                                    Console.WriteLine("puanınız: " + puan);
                                    

                                }
                                else if (adet == 0)
                                {
                                    //Console.Clear();
                                    Console.Write("Tebrik ederim basardin!.");

                                    Console.WriteLine("Puanınız: " +puan);

                                    return;
                                }
                                if (harf.Length > 1)
                                    break;
                            }

                        }
                        if (harf.Length > 1)
                        {
                            for (int d = 0; d < tutulan_Kelime.Length; d++)
                            {
                                if (tutulan_Kelime[d].ToString() == harf[d].ToString())
                                {
                                    kelime[d] = harf[d].ToString();


                                }
                                puan = kelime.Length * 100 * 0.85;
                            }
                           
                            for (int d = 0; d < tutulan_Kelime.Length; d++)
                            {
                                Console.Write(" " + kelime[d].ToString());
                               

                            }

                            Console.WriteLine("\npuan hesabı: " + puan);
                            break;

                        }


                    }
                    catch
                    {
                        Console.WriteLine("Lütfen harf girişi yapınız");
                    }
                } while (true);


                Console.WriteLine("tekrar oynamak için e ye basınız");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
