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

        }
    }
}
