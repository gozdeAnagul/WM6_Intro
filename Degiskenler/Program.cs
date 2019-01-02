using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wold");
            //PascelCase
            //camelCase

            //isimlendirme kuralları

            //Tamsayı tipler.
            byte degiskenByte = 255; //işaretsiz 8bit
            sbyte degiskenSbyte = 127; //işaretli 8bit
            short degiskenShort = 3200; //işaretli 16bit
            ushort degiskenUshort = 65535; //işaretsiz 16bit
            int degiskenInt = int.MaxValue; //32Bit
            uint degiskenUint = uint.MaxValue; //32Bit
            long degiskenlong = 5000L; //64Bit
            ulong degiskenUlong = 8585744754L; //64Bit

            degiskenInt = degiskenShort;
            degiskenShort = Convert.ToInt16(degiskenlong);
            Console.WriteLine(degiskenShort);

            //Ondalıklı Tipler.
            float degiskenFloat = 3.14f;
            double degiskenDouble=3.14d; //Büyük D olabilirdi.
            decimal degiskenDecimal = 3.14m; //Many m M kullanılabilir.

            degiskenInt = 0b1011;
            degiskenInt=0x2efd;
            degiskenDouble = 3.10e10;

            Console.WriteLine(degiskenInt);
            Console.WriteLine(degiskenDouble);

            //Metinsel ifadeler.
            char degiskenChar = 'a';
            string degiskenString = "gmlkblksnglknwt";

            //Mantıksal ifade
            bool degiskenBool = false; //or true;

            DateTime suan = DateTime.Now;
            suan = new DateTime(2018, 11, 26,2,10,22);
            Console.WriteLine(suan);

            object degiskenObject = suan;

            var query = degiskenFloat * degiskenDouble;
            var d = "thbdtfygbwrt";


        }
    }
}
