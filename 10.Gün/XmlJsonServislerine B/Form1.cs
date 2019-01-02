using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlJsonServislerine_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Doviz> dovizler;
        private int sayac = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            var doviz = dovizler[sayac++%dovizler.Count];
            lblKod.Text = $"{doviz.Birim}{doviz.Ad}-{doviz.Kod}";
            lblDeger.Text = $"Alis: {doviz.Alis:c4}\nSatis: {doviz.Satis:c4}";
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dovizler = DovizFactory.Dovizler;
                // listBox1.Items.AddRange(dovizler.ToArray());
                listBox1.DataSource = dovizler;
                timer1.Start();
            }
            catch (Exception ex)
            {

                timer1.Stop() ;
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Doviz seciliDoviz = listBox1.SelectedItem as Doviz;
            this.Text=$"{seciliDoviz.Birim} {seciliDoviz.Ad}-{seciliDoviz.Kod} Alis: {seciliDoviz.Alis:c4}\nSatis: {seciliDoviz.Satis:c4}"; 
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            new FourFactory();
        }
    }
}
