using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando3.UserControlls
{
    public partial class UC_Feladat2 : UserControl
    {
        public UC_Feladat2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "EUR";
                label2.Text = "USD";
                label3.Text = "GPB";
                label4.Text = "CYN";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "HUF";
                label2.Text = "USD";
                label3.Text = "GPB";
                label4.Text = "CYN";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = "EUR";
                label2.Text = "HUF";
                label3.Text = "GPB";
                label4.Text = "CYN";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Text = "EUR";
                label2.Text = "USD";
                label3.Text = "HUF";
                label4.Text = "CYN";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label1.Text = "EUR";
                label2.Text = "USD";
                label3.Text = "GPB";
                label4.Text = "HUF";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] szorzomatrix = new double[5, 5] { { 1.0, 0.0028, 0.0033, 0.0025, 0.022 },
                                                   { 355.36, 1.0, 1.18, 0.89, 7.79 },
                                                   { 302.36, 0.85, 1.0, 0.76, 6.63 },
                                                   { 399.52, 1.12, 1.32, 1.0, 8.76 },
                                                   { 45.60, 0.13, 0.15, 0.11, 1.0 } };
            double number = double.Parse(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                double num1 = number * szorzomatrix[0, 1];
                double num2 = number * szorzomatrix[0, 2];
                double num3 = number * szorzomatrix[0, 3];
                double num4 = number * szorzomatrix[0, 4];

                textBox2.Text = num1.ToString();
                textBox3.Text = num2.ToString();
                textBox4.Text = num3.ToString();
                textBox5.Text = num4.ToString();
            }

        }
    }
}
