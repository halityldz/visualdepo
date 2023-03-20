using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Halit Tayyip";
            label7.Text = "yıldız";
            label8.Text = "yazılım mühendisliği";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "halit tayyip";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
