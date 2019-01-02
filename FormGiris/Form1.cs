using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComploments();
            txt_Ekran.Text = "0";// ekranı boşalt

        }
        private double sayi = 0, ekran = 0;
        private char islem = '0';

        private void InitMyComploments()
        {

            //eventları oluştur
            btn_0.Click += BtnSayi_Click;
            btn_1.Click += BtnSayi_Click;
            btn_2.Click += BtnSayi_Click;
            btn_3.Click += BtnSayi_Click;
            btn_4.Click += BtnSayi_Click;
            btn_5.Click += BtnSayi_Click;
            btn_6.Click += BtnSayi_Click;
            btn_7.Click += BtnSayi_Click;
            btn_8.Click += BtnSayi_Click;
            btn_9.Click += BtnSayi_Click;


            btn_Esittir.Click += BtnIslem_Click;
            btn_Topla.Click += BtnIslem_Click;
            btn_Cikar.Click += BtnIslem_Click;
            btn_Carp.Click += BtnIslem_Click;
            btn_Bol.Click += BtnIslem_Click;
            


        }

        private void BtnIslem_Click(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            
            if (islem == '0')
            {
                sayi = ekran;
                ekran = 0;
                txt_Ekran.Text = "0";
            }

            else if (islem == '+')
            {
                sayi += ekran;
                ekran = 0;
                txt_Ekran.Text = sayi.ToString();
            }

            else if (islem == '-')
            {
                sayi -= ekran;
                ekran = 0;
                txt_Ekran.Text = sayi.ToString();
            }

            else if(islem == '/')
            {
                sayi /= ekran;
                ekran = 0;
                txt_Ekran.Text = sayi.ToString();
            }

            else if (islem=='x')
            {
                sayi *= ekran;
                ekran = 0;
                txt_Ekran.Text = sayi.ToString();

            }
            else if(islem=='=')
            {
                txt_Ekran.Text = sayi.ToString();
            }
            islem = Convert.ToChar(btn.Text);

        }
        // klavyeden giriş yapabilmek için yapıldı.
        //form 1 in property kısmından 
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn_0.PerformClick();
                    break;
                case '1':
                    btn_1.PerformClick();
                    break;
                case '2':
                    btn_2.PerformClick();
                    break;
                case '3':
                    btn_3.PerformClick();
                    break;
                case '4':
                    btn_4.PerformClick();
                    break;
                case '5':
                    btn_5.PerformClick();
                    break;
                case '6':
                    btn_6.PerformClick();
                    break;
                case '7':
                    btn_7.PerformClick();
                    break;
                case '8':
                    btn_8.PerformClick();
                    break;
                case '9':
                    btn_9.PerformClick();
                    break;
                case '+':
                    btn_Topla.PerformClick();
                    break;
                case '-':
                    btn_Cikar.PerformClick();
                    break;
                case '/':
                    btn_Bol.PerformClick();
                    break;
                case 'x':
                    btn_Carp.PerformClick();
                    break;
                case '=':
                    btn_Esittir.PerformClick();
                    break;
                case '\u001b':
                    sayi = 0;
                    ekran = 0;
                    txt_Ekran.Text = "0";
                    break;
                case '\r':
                    //enter ın kodu
                    btn_Esittir.PerformClick();
                    break;
            }
        }

        private void BtnSayi_Click(object sender, System.EventArgs e)
        {
            //Sender= gönderici. Eventı buton tetikliyor.
            //Button btn = sender as Button
            // butonlara click vermektense böyle yaptık.
            Button btn = (Button)sender;
            string birlestirme = ekran + btn.Text;
            ekran = double.Parse(birlestirme);
            txt_Ekran.Text = ekran.ToString();

        }
    }
}
