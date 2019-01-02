using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaydet
{
    public class Kisi
    {
        //regex lerin başına @ işratei konulmalı 
        //regex in kütüphanesi eklenmeli
        private string _ad, _soyad, _telefon, _email, _tckn;

        public String ad
        {
            get
            {
                return this._ad;
            }
            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String SoyAd
        {
            get
            {
                return this._soyad;
            }
            set
            {
                NameValid(value, "Soyad");
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

       
        private void NameValid(string value, string v)
        {
            
        }

        //formu temizle fonk
        //controls bir koleksiyon olduğu için içinde dönebilirim
        //control is checkbox chbox
        //controlü checkbox tipine çevirmek için ***control as checkbox***
        //control is textbox control textbox tipindemi yani istance ı textbox mu diye kontrol ediyoruz
        //else if control is listbox lstbox
                //lstbox.ıtems.clear();//itemleri temizler.
        //Ödev
        //formun yanına listbox ekle listele birini çekince textboxlar dolacak
        //ekle sil güncelle yapacağz.
        //üstüne text box koy adına soyadına göre ara
        //key lerle yapılacak

        //2, ödev kronometre
        //start stop aynı buton biri enable ken diğeri disanble olmalı.
        //progress bar yapacaksın
        //4 alan saat dakika saniye mili saniye
        //sıfırlama
        //check boxu işaretleyince date time picker çıkacak  ordan zamanı ayarlayacağım.
        //ayarladığım zaman kadar çalışacak ve proses bar kum saati o kadar saniyede duracak.
    }
}
