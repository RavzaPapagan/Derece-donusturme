using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru1derecedonusturme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            private void button1_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);      //textbox tan sayımı aldım
            double sonuc;
            sonuc = deger * 9 / 5 + 32;                          //sonuc içinde fahrenayt formulüne göre hesapladım
            textBox2.Text = (sonuc.ToString()+" F");             // sonucumu textboxa yazdırdım
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);           
            double sonuc;
            sonuc = (deger - 32) * 5 / 9;                     // derecenin formülünü uyguladım
            textBox2.Text = (sonuc.ToString()+" C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
