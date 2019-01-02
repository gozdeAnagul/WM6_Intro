using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //class içine değişken tanımlama field
        private DateTime kronometre = new DateTime(), simdi = DateTime.Now, once = DateTime.Now;
        private bool basladiMi = false;

        private void Yaz()
        {
            lblSaat.Text = $"{kronometre.Hour:00}";
            lblDakika.Text = $"{kronometre.Minute:00}";
            lblSaniye.Text = $"{kronometre.Second:00}";
            lblSanise.Text = $"{kronometre.Millisecond:000}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (basladiMi) return;
            kronometre = new DateTime();
            Yaz();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //simdi ile önceyi güncelleyip akan bir saat elde etmem lazım
            //timer çalışıyorsa tick çalışıyor demektir
            once = simdi;
            simdi = DateTime.Now;
            TimeSpan fark = simdi - once;
            this.Text = $"{fark.TotalMilliseconds:0000}";
            kronometre = kronometre.AddMilliseconds(fark.TotalMilliseconds);

            //zamanlı olarak ayarlarsak
            if (cbZamanli.Checked)
            {
                DateTime bitis = dtpZamanli.Value;
                //toplam fark picker la kronometre başlangıcını veriyor
                //gün ay yılını aynı yaptık
                //10Dk 60000 taban sayı mesela
                
                TimeSpan toplamAralık = bitis - new DateTime(bitis.Year, bitis.Month, bitis.Day);
                TimeSpan baslangıctanFark = kronometre-new DateTime();
                int yuzde = (int)(baslangıctanFark.TotalMilliseconds/toplamAralık.TotalMilliseconds*100);
                //yüzde bulduktan snra timer ı durduramız lazım ki timer ilerlemesin
                //yoksa program 100ü geçince hta veriyor

                //bazen 101 oranı falan çıkıyor onları egale etmek için >=100 yapıp daha sonra if in içinde yüzde degerimi 100 e eşitledik
                if (yuzde>=100)
                {
                    
                    yuzde = 100;
                    kronometre = new DateTime(kronometre.Year, kronometre.Month, kronometre.Day, kronometre.Hour, kronometre.Minute, kronometre.Second);
                    //perform click tıklamış gibi çalışacak
                    btnStartStop.PerformClick();

                    Yaz();
                    kronometre = new DateTime();
                }
                progressBar1.Value = yuzde;
            }

            Yaz();
        }


        private void btnStartStop_Click(object sender, EventArgs e)
        {
            basladiMi = !basladiMi;
            if (basladiMi)
            {
                btnStartStop.Text = "Durdur";
                btnStartStop.FlatStyle = FlatStyle.Flat;
                btnStartStop.BackColor = Color.Chartreuse;
                //zamanlama başlaya basınca başlasn
                simdi = DateTime.Now;
                //basladıysa resetleme enable false olmalı
                btnReset.Enabled = false;
                timer1.Start();
                
            }
            else
            {
                btnStartStop.Text = "Başla";
                btnStartStop.FlatStyle = FlatStyle.Standard;
                btnStartStop.BackColor = Color.IndianRed;
                //true olarak duzelttik
                btnReset.Enabled = true;
                timer1.Stop();
            }
        }
    }
}
