using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declarations
            int temp;
            Random rnd = new Random();

            // initialization
            temp = rnd.Next(min, max);

            // show result, label1
            label1.Text = "Generated number is: " + temp.ToString();

            // show proper picture, picturebox1
            switch (temp)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.a;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.b;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.c;
                    break;
                default:
                    break;
            }
            pictureBox1.Visible = true;
            tabControl1.SelectedTab = tabPage2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            min = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            max = Int32.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
