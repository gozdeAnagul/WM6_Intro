using Cs.Lib;
using Cs.Lib.Abstract;
using Cs.Lib.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cs.Lib.Abstract.Silah;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer seriTimer = new Timer();
      
        private Silah seciliSilah;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.Items.AddRange(Enum.GetNames(typeof(Silahlar)));
            seriTimer.Tick += SeriTimer_Tick;
        }

        private void SeriTimer_Tick(object sender, EventArgs e)
        {
            btnAtes.PerformClick();
        }

        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedIndex < 0) return;

            //Bir seçili enumdan hangi seçili enum olduğunu bulmak için yazdık yani combobox da hangi silah seçili ona baktık tip istediği için tyoeof diye gönderdik
            //parse biz eobje dödürüyor. oyuzden(silahlar) yazıkki emin olalım tipini bilelim tipi silahlar görörelim
            Silahlar silah = (Silahlar)Enum.Parse(typeof(Silahlar), cmbSilahlar.SelectedItem.ToString());
            //enum sabit listeleri kullanmak için kullanıyoruz silahların içinde bie enum var.
            lblDetay.Visible = true;
            
            //diğer bir yöntem 
            //hiç bişey yazılmadıysa 0 1 2 diye kaydetmiştir ve indexden yola çıkarak buluyor.

            //bu yöntemi kullanarak enumları numaralandırabiliriz.
            Silahlar silahb = (Silahlar)cmbSilahlar.SelectedIndex;
            byte deger = (byte)silah;

            switch (silah)
            {
                case Silahlar.Bıçak:
                    seciliSilah = new Bicak();
                    break;
                case Silahlar.USP:
                    seciliSilah = new USP();
                    break;
                case Silahlar.Glock:
                    seciliSilah = new Glock();
                    break;
                case Silahlar.Deserteagle:
                    seciliSilah = new DesertEagle();
                    break;
                case Silahlar.AK47:
                    seciliSilah = new AK47();
                    break;
                case Silahlar.M4A1S:
                    seciliSilah = new M4A1S();
                    break;
                case Silahlar.AWP:
                    seciliSilah = new AWP();
                    break;
                case Silahlar.ElBombası:
                    seciliSilah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    seciliSilah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            panelSilah.Controls.Clear();
            panelSilah.Controls.Add(seciliSilah.SilahResmi);
            seciliSilah.SilahResmi.Dock = DockStyle.Fill;

            silahBilgisiGoster(seciliSilah);

            gb_AtesliSilah.Visible = seciliSilah is IAtesEdebilen;
            gbYakinSaldiri.Visible = seciliSilah is IVurulabilir;
            gbFirlatilan.Visible = seciliSilah is IFirlatilabilen;


        }

        private void silahBilgisiGoster(Silah silah)
        {
            
            
            lblDetay.Text = $"Ülke{seciliSilah.Ulke}\nFiyat: {seciliSilah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorlSilah)
                lblDurum.Text = $"{sarjorlSilah.KalanFisek}/{sarjorlSilah.SarjorKapatisesi}";
        }

        private void btnAtes_Click(object sender, EventArgs e)
        {
            btnAtes.Enabled = false;
            if (seciliSilah is IAtesEdebilen ss)
            {
                ss.AtesEt();
                silahBilgisiGoster(seciliSilah);
            }
            btnAtes.Enabled = true;
           
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = false;
            (seciliSilah as IVurulabilir).Vur();
            silahBilgisiGoster(seciliSilah);
            btnSaldir.Enabled = true;

        }

        private void btnFirlat_Click(object sender, EventArgs e)
        {

            btnFirlat.Enabled = false;
            (seciliSilah as IFirlatilabilen).Firlat();
            silahBilgisiGoster(seciliSilah);
            btnFirlat.Enabled = true;


        }

        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            btnYenidenDoldur.Enabled = false;
            (seciliSilah as ISarjorlu).YenidenDoldur();
            silahBilgisiGoster(seciliSilah);
            btnYenidenDoldur.Enabled = true;
        }

        private void btnAtes_MouseDown(object sender, MouseEventArgs e)
        {
            if(seciliSilah is ISeriAtabilir seriSilah)
            {
                seriTimer.Interval = seriSilah.AtisKatsayisi;
                seriTimer.Start();
            }
        }

        private void btnAtes_MouseUp(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir seriSilah)
            {
                
                seriTimer.Stop();
            }
        }
    }
}
