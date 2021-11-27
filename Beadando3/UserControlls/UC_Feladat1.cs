using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Beadando3.UserControlls
{
    public partial class UC_Feladat1 : UserControl
    {
        string content;
        public UC_Feladat1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                        richTextBox1.Text = content;
                    }
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream;

                if((stream = sfd.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        content = richTextBox1.Text;
                        writer.Write(content);
                    }
                    stream.Close();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            content = richTextBox1.Text;
            int lettercount = content.Length;
            char space = ' ';
            int spacecount = 0;

            foreach (var c in content)
            {
                if (c == space)
                {
                    spacecount++;
                }
            }

            int lettercountwoutspaces = lettercount - spacecount;
           
            lblCharCounterSpaces.Text = "Characters (with spaces): " +  lettercount.ToString();
            lblCharCounter.Text = "Characters (without spaces): " + lettercountwoutspaces.ToString();
        }
    }
}
