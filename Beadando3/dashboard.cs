using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando3
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Feladat11.Visible = true;
            uC_Feladat21.Visible = false;
            uC_Welcome1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_Feladat11.Visible = false;
            uC_Feladat21.Visible = true;
            uC_Welcome1.Visible = false;
        }
    }
}
