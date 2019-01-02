using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soyut.Lib;

namespace Soyut.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<object> sekiller = new List<object>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 10;
            //MessageBox.Show($"karenin Alanı: {kare.AlanHesapla()}");


            //atama yapmayımı unuttunuz? canınızı sıkmayın burada propety var:D
            //tama yapmayı unuttuğum varmı diye kontrol etmek için atamaları kolay yapmak için var
            //önce construction çalışır sonra propety atamaları yapar.
            Dikdortgen dikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 12
            };
            sekiller.Add(kare);
            sekiller.Add(dikdortgen);
            //MessageBox.Show($"dikdörtgenin Alanı: {dikdortgen.KosegenHesapla()}");

            //şekil tipinde bir ssekil örnekleyemezken şekil tipinde bir kare örnekledik

            //bir nesne üzerinden birden fazla aynı şekilden türeyen fakat farklı şekilde davranan nesne türettik buna polimorfiz denir.

            //yani polimorfizm farklı tipleri ortak tipte topalyıp kendi gibi çalışmasını sağlayabilirim.
            Sekil kare2 = new Kare() { X = 5 };
            Sekil dikdortgen2 = new Dikdortgen() { X = 8, Y = 10 };

            sekiller.Add(kare2);
            sekiller.Add(dikdortgen2);

            
            foreach (Sekil sekil in sekiller)
            {
                //poliformizm ile yapılışı.

                MessageBox.Show($"Şekilin Alanı: {sekil.AlanHesapla()}");

                //if (sekil is Kare kk)
                //    MessageBox.Show($"karenin Alanı: {kk.AlanHesapla()}");
                //else if(sekil is Dikdortgen dd)
                //    MessageBox.Show($"karenin Alanı: {dd.AlanHesapla()}");
            }
        }
    }
}
