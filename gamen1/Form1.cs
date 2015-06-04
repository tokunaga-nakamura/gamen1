using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form form8 = new Form8();
            form8.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form form9 = new Form9();
            form9.ShowDialog();
        }
    }
}
