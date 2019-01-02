using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kiraz");
            //yada 
            string[] meyveler = { "kirrraz", "üzüm", "pufff" };
            comboBox1.Items.AddRange(meyveler);

            listBox1.Items.AddRange(meyveler);
            listBox1.SelectionMode = SelectionMode.One;
            //string formatlara bak.
        }
    }
}
