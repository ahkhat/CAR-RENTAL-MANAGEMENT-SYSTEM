using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oto
{
    public partial class Giris_paneli : Form
    {
        Form1 giris = new Form1();
        Form2 giris2 = new Form2();
        KayıtOlmaFormu giris3 = new KayıtOlmaFormu();
        public Giris_paneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris2.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            giris3.Show();
        }
    }
}
