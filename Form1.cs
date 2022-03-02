using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHun01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text), y = int.Parse(textBox2.Text);
            int soucet = x + y;
            MessageBox.Show("Součet dvou čísel je: " + soucet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text), y = int.Parse(textBox2.Text);
            int rozdil = x - y;
            MessageBox.Show("Rozdíl dvou čísel je: " + rozdil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text), y = int.Parse(textBox2.Text);
            int soucin = x - y;
            MessageBox.Show("Součin dvou čísel je: " + soucin);
        }
    }
}
