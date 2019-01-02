using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPart1
{
    class Insan
    {
        /*
         *** CLASS da olması gerekenler***
         * Erişim Belirleyiciler /Access Modifiers
         * Fields alanlar //vei tutan alanlardır
         * Constructors / Yapıcı Methodlar
         * Destruction / Yıkıcı Methodlar
         * Properties / Özellikler
         * Methodlar / Fonksiyonlar
         * Event
         * Delege
         * *Kalıtım / İnheritance
         * *Polymorphism / Çok Biçimlilik
         */

        //Erişim Belirleyiciler / Access Modifiers
        /*
         * Private - aynı scope yada alt scope içinde erişimi yapılan nesnelerdir.
           tanımlanan tüm değişken ve methodlar onune yazılmasa dahi private olarak çalışırlar.
         * İnternal - Aynı namespace içerisinde erişime açıktır.Class Interface enum default internaldır.
         * public - Farklı namespace lerden erişim için kullanılır.
         * 
         * *Protected
         * *Protected İnternal
         */

        internal int yas;

        //constructer
        /*
         * insan b=new insan(); //constructer 
         * field e ihtiyacm var
         * insan . yazaman çünkü insan bir tip olarak sınıf dır
         * bu yüzden this bulunduğu sınıfı temsil eder. o anki referansla erişime alınır
         * constructer nesne oluşturulurken atamalarının da yapılması için kullanılıyor.
         */

        //field yazmak için _ kullanıyoruz
        private int _yas;
        private DateTime _dogumTarihi;

        //insan . yazaman çünkü insan bir tip olarak sınıf dır
        //bu yüzden this bulunduğu sınıfı temsil eder. o anki referansla erişime alınır
        public Insan(int yas)
        {
            this.yas = yas;
        }

        //constructer nesne oluşturulurken atamalarının da yapılması için kullanılıyor.
        public Insan()
        {
            DateTime date = DateTime.Now;

        }

        //Encapsulation


        public void setYas(int yas)
        {
            if (yas <= 0)
                throw new Exception("yas 0 dan büyük olmalı");
            this._yas = yas;
        }

        //tek satır method
        public int getYas() => this._yas;
        //{
        //    return this.yas;
        //}


        //Property(ft.encapsulation)
        //yeni modern kısım
        public int Yas
        {
            //get { return DateTime.Now.Year-_dogumTarihi.Year; }
            get { return this.yasHesapla(_dogumTarihi.Year); }

            //{
            //    return this._yas;
            //}
            set
            {
                if (value <= 0)
                    throw new Exception("yas 0 dan büyük olmalı");
                this._yas = value;
            }
        }

        public DateTime DogumTarihi
        {
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    throw new Exception("18 yaşıdan küçükler sisteme dahil olamaz");
                this._yas = DateTime.Now.Year - value.Year;
                this._dogumTarihi = value;
            }
        }

        //yas hesapla 
        //line 87 get i var
        private int yasHesapla(int year) => DateTime.Now.Year - year;


    }
}
