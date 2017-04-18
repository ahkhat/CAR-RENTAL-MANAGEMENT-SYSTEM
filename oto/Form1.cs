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
    public partial class Form1 : Form
    {
        CitroenForm enter = new CitroenForm();
        HyundaiForm enter2 = new HyundaiForm();
        ToyotaForm enter3 = new ToyotaForm();
        WolkwagenForm enter4 = new WolkwagenForm();
        MercedesForm enter5 = new MercedesForm();
        RenaultForm enter6 = new RenaultForm();
        KayıtOlmaFormu git = new KayıtOlmaFormu();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enter.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void corolla_Click(object sender, EventArgs e)
        {
            enter3.Show();

        }

        private void hyundai_Click(object sender, EventArgs e)
        {
            enter2.Show();
        }

        private void jetta_Click(object sender, EventArgs e)
        {
            enter4.Show();

        }

        private void mercedes_Click(object sender, EventArgs e)
        {
            enter5.Show();

        }

        private void symbol_Click(object sender, EventArgs e)
        {
            enter6.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            git.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
