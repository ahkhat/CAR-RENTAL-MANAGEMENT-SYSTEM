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
    public partial class CitroenForm : Form
    {  int hata = 0;
        public CitroenForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') 
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {





            int hata = 0;


            if (textBox1.Text == string.Empty)

                hata = 1;

            if (textBox2.Text == string.Empty)

                hata = 1;

            if (textBox3.Text == string.Empty)

                hata = 1;

            if (textBox4.Text == string.Empty)

                hata = 1;
            if (checkBox1.Checked==false)
                hata = 2;
            if (hata == 1)

            {

                MessageBox.Show("Bütün Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (hata == 2)

            {

                MessageBox.Show("Üye olmayı kabul etmediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
    }

