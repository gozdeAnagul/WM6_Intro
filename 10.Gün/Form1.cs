using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Gün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<KisiV2> kisiler = new List<KisiV2>();
        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                else if (control is CheckBox)
                    (control as CheckBox).Checked = false;
                else if (control is ListBox lstBox)
                    lstBox.Items.Clear();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KisiV2 yeniKisi = new KisiV2();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.Email = txtEmail.Text;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.TCKN = txtTckn.Text;

                MessageBox.Show($"Hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                FormuTemizle();

                //array istıyorum sen list yolluyosun toArray yap.
                lstKisiler.Items.AddRange(kisiler.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            KisiV2 secili = (KisiV2)lstKisiler.SelectedItem;

            try
            {
                secili.Ad = txtAd.Text;
                secili.Soyad = txtSoyad.Text;
                secili.Email = txtEmail.Text;
                secili.TCKN = txtTckn.Text;
                secili.Telefon = txtTelefon.Text;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());

        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            //REferans tipli anında değişir.
            KisiV2 secili = (KisiV2)lstKisiler.SelectedItem;

            txtAd.Text = secili.Ad;
            txtSoyad.Text = secili.Soyad;
            txtEmail.Text = secili.Email;
            txtTckn.Text = secili.TCKN;
            txtTelefon.Text = secili.Telefon;
        }
    }
}
