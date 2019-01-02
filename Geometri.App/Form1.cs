using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometri.Lib;

namespace Geometri.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kare kare = new Lib.Kare();
            //Dikdortgen dikdortgen = new Lib.Dikdortgen();
            
            //kare.X = 5;
            //MessageBox.Show($"karenin alanı:{kare.AlanHesapla()}");

            //dikdortgen.X = 3;
            //dikdortgen.Y = 4;
            //MessageBox.Show($"karenin alanı:{dikdortgen.AlanHesapla()}");

            DikUcgen dikucgen = new Lib.DikUcgen();
            dikucgen.X = 5;
            dikucgen.Y = 12;
            MessageBox.Show($"ucgenin alanı:{dikucgen.AlanHesapla()}");
            MessageBox.Show($"ucgenin alanı:{dikucgen.CevreHesapla()}");
            MessageBox.Show($"ucgenin alanı:{dikucgen.KosegenHesapla()}");


            //şekilden bir örnek instance aldık
            //çalıştımı evet ama bir mantıkhatası mevcut.
            //hangi şekilin alanı peki??
            //sekil soyut bir kavram oyüzden şeklil sınıfını abstract yapmam soyutlamam lazım
            //abstract yaptıktan snra instance alınamaz.

            //Sekil sekil = new Sekil();
            //sekil.X = 10;
            //MessageBox.Show($"ucgenin alanı:{sekil.AlanHesapla()}");



        }
    }
}
