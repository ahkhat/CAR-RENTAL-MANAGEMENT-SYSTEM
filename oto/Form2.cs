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
    public partial class Form2 : Form
    {
        KayıtOlmaFormu a = new KayıtOlmaFormu();
        AudiForm gir1 = new AudiForm();
        FordForm gir2 = new FordForm();
        BMWForm gir3 = new BMWForm();
        JEEPForm gir4 = new JEEPForm();
        SciroccoForm gir6 = new SciroccoForm();
        MercedesAmgForm gir5 = new MercedesAmgForm();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void audi_Click(object sender, EventArgs e)
        {
            gir1.Show();

        }

        private void ford_Click(object sender, EventArgs e)
        {
            gir2.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            a.Show();
        }

        private void bmw_Click(object sender, EventArgs e)
        {
            gir3.Show();
        }

        private void amg_Click(object sender, EventArgs e)
        {
            gir5.Show();

        }

        private void scirocco_Click(object sender, EventArgs e)
        {
            gir6.Show();
        }

        private void jeep_Click(object sender, EventArgs e)
        {
            gir4.Show();

        }
    }
}
