using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TelikosBathmos : Form
    {
        public TelikosBathmos()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double Mark(TextBox textBox)
        {
            string StringMark = textBox.Text;
            //label6.Text += textBox.Text;
            double Mark1;
            try
            {
                int mingrade = 0;
                int maxgrade = 112;

                Mark1= Convert.ToDouble(StringMark);
                if (Mark1 < mingrade)
                {
                    Mark1 = -1;
                    NotNumber.SetError(textBox, "The value you entered is bellow "+mingrade);
                }

                if (Mark1 > maxgrade)
                {
                    Mark1 = -1;
                    NotNumber.SetError(textBox, "The value you entered is over "+maxgrade);
                }
                return Mark1;
            }
            catch (Exception)
            {
                NotNumber.SetError(textBox, "The value you entered is not an double.");
                return -1;
            }
        }


        private void Enter_Click(object sender, EventArgs e)
        {
            label6.ResetText();
            NotNumber.Clear();
            double Mark1=Mark(textBox1);
            
            double Mark2 = Mark(textBox2);

            double Mark3 = Mark(textBox3);

            double Mark4 = Mark(textBox4);

            //label6.Text = Mark1.ToString() + Mark2.ToString() + Mark3.ToString() + Mark4.ToString();


            if (Mark1 != -1 && Mark2 != -1 && Mark3 != -1 && Mark4 != -1)
            {
                double MO = (20 * Mark3 + (Mark1 + Mark2) / 2 * 30 + Mark4 * 50) / 100;
                label6.Text = MO.ToString();
            }
            else
            {
                label6.Text = "Wrong input. Please try again.";
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
