using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YueyangSun_Lab5_Ex1
{
    public partial class Form1 : Form
    {
        int[] a = new int []{ 1, 2, 3, 4, 5 };
        double[] b = new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 };
        public Form1()
        {   
            InitializeComponent();
            comboBox1.Items.Add("1,2,3,4,5");
            comboBox1.Items.Add("1.5, 2.5, 3.5, 4.5, 5.5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) { 
            case 0:
                    label4.Text=Exercise1.Search<int>(a, Convert.ToInt32(textBox1.Text)).ToString();
                break;
            case 1:
                    label4.Text += Exercise1.Search<double>(b, Convert.ToDouble(textBox1.Text)).ToString();
                break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = rand.Next(0, 6).ToString();
        }
    }
}
