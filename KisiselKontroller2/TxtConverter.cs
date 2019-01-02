using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller2
{
    public delegate string SinirAsimiHandler();
    public partial class TxtConverter : UserControl
    {
        public TxtConverter()
        {
            InitializeComponent();
        }
        
        public int Sayi { get; set; }
        public DateTime Tarih { get; set; }
        public bool AktifMİ { get; set; }
        public Color Renk { get; set; }

        public decimal Value
        {
            get => nuSayi.Value;
            set => nuSayi.Value = value;
        }

        //text baks u readonly true ;dışarıdan erişim engellendi ozman propertysinide yapmam lazım
        //readonly properties sadece get
        public string ConvertedText => txtOkunus.Text;


        private void nuSayi_ValueChanged(object sende, EventArgs e)
        {
            //txtOkunus.Text = nuSayi.Value.ToString();
            //okunusunu Form labelına yazar
            //this.ParentForm.Text = txtOkunus.Text;
            //txtOkunus.Text = TextToll.OkunusuGetir(Convert.ToInt32(nuSayi.Value));
            int sayi = Convert.ToInt32(nuSayi.Value);
            
            txtOkunus.Text = sayi.OkunusuGetir();
           
        }
       

    }
}
