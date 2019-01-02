using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BinarySeralition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        MemoryStream memorySteram = new MemoryStream();
        private void btnAc_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir Resim Dosyası seçiniz";
            // açacağımız resmin uzantısını ayarlıyoruz
            dosyaAc.Filter = "Resim Dosyaları | *.jpg;*.png";
            dosyaAc.FileName = string.Empty;
            dosyaAc.Multiselect = false;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //dialog penceresi açıldıysa işlemler devam etsin istiyorum
            //DialogResult sonuc= dosyaAc.ShowDialog();
            //if(sonuc==DialogResult.OK)
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                //dosyaları dönüştürkmek için (reism dosyas vb) file streame ihtiyacım var
                //akışı olan herseyde stream kullanıyouz mesela film akışı.
                FileStream dosya = File.Open(dosyaAc.FileName,FileMode.Open);
                while (dosya.Read(resimArray,0,bufferSize)!=0)
                {
                    memorySteram.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                //dosyayı kapat başka bir program kullanmaya çaılştığında dosya kullanımda yazısını alalım diye 
                //dispose garbage colector u çalştırır nesneyi ramdan uzaklaştrr
                dosya.Dispose();

                pbResim.Image = new Bitmap(memorySteram);
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (memorySteram.Length==0)
            {
                MessageBox.Show("ramda bir dosya yok");
                return;
            }
            dosyaKaydet.Title = "bir dosya seç";
            dosyaAc.Filter = "(*.jpg)|*.png";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = string.Empty;

            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Create(dosyaKaydet.FileName);
                memorySteram.Seek(0, SeekOrigin.Begin);
                
                while (memorySteram.Read(resimArray, 0, bufferSize)!=0)
                {
                   dosya.Write(resimArray,0,resimArray.Length) ;
                }
                dosya.Close();             
                dosya.Dispose();

               
            }

        }
    }
}
