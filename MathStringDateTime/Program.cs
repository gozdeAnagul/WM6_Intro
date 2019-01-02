using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStringDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //matematikm fonksiyonları
            //celing yuları yuvarlama
            //floor aşağı yukarlama
            //round içinde (x,y) x tam sayı y virgulden sonra kaç hane kullanacağın
            Console.WriteLine(Math.Sin(Math.PI / 2));
            Console.WriteLine(Math.Round(7.456, 2));
            //kuvvet alma
            Console.WriteLine(Math.Pow(7, 2));
            //karekök alma
            Console.WriteLine(Math.Sqrt(Math.Pow(3, 2)+ Math.Pow(4, 2)));

            //Tarih fonksiyonlar
            DateTime tarih = DateTime.Now;

            DateTime sonkaki=tarih.AddDays(95);
            sonkaki = tarih.AddHours(3);
            sonkaki = tarih.AddMinutes(3);
            Console.WriteLine(tarih.AddDays(95));
            TimeSpan fark = sonkaki - tarih;
            Console.WriteLine($"toplam = { fark.TotalMinutes}");

            //metinsel fonksiyonlar
            //string kelime = "vldfbhjkpğslk";
            //kelime = null;//referans tip


            //referasn tip mi yoksa değer tip mi hemen öğrenmiş oluruz.
            string a = "5";
            string b = "6";
            a = b; //string ifadeler için imnutable ifadesi kullanılır yani özel dir. teoride char array. strin golarak çağırırısak value tip. yani değer tip.
            b="20";
            Console.WriteLine(a);

            string kelime = "Wissen Akademie";
            //cantaince kelime arama dizilerde de var çok kullanacağız.
            bool varMi=kelime.Contains("Akademie");
            //containce aradan arar startwith başlangıç enndswith de bitişinde arar.
            //kelime.indexof('i') içinde i arar gezebiliriz döngüule ilk karşılaştığınız indexini bulur.
            //last index of son dan arar sonda karşılaştığı ilk i inin indexini verirbasl
            //remove belli bir ifadeden sobrasını siliyor
            //replace iki karakter parametresi verir. 
            string baslik = "bfdjaklvkbjh wERÜĞbjklğdf oıfhvdwbdkfv oıdhgawvbajdkov hvbd";
            //değişiklik yaptıkça atama da yapmalısın yoksa değişim gerçekleşmemiş olur

            baslik = baslik.ToLower();
            baslik = baslik.Replace(" ", "-");
            baslik = baslik.Replace("ç","c");
            baslik = baslik.Replace("ü", "u-");
            Console.WriteLine(baslik);

            //trim kırpma yapmak için kullanılır aradai bolığa dokunmaz ama baş ve sondakileri kırpar
            string mailListesi = "ferbgdno@msk.com;dbfskf@nvefj.com";
            string[] mailler = mailListesi.Split(';');


            //tek parametre verirsek sonrası, iki verirsek arası
            Console.WriteLine(kelime.Substring(0,6));




        }
    }
}
