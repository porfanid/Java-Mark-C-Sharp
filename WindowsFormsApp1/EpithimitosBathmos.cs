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
    public partial class EpithimitosBathmos : Form
    {
        public EpithimitosBathmos()
        {
            InitializeComponent();
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

                Mark1 = Convert.ToDouble(StringMark);
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
            double Mark1 = Mark(textBox1);

            double Mark2 = Mark(textBox2);

            double Mark3 = Mark(textBox3);

            //label6.Text = Mark1.ToString() + Mark2.ToString() + Mark3.ToString() + Mark4.ToString();


            if (Mark1 != -1 && Mark2 != -1 && Mark3 != -1)
            {
                double MO = (20 * Mark3 + (Mark1 + Mark2) / 2 * 30) / 100;
                //label6.Text = MO.ToString();
                double best = (50 - MO)*2;
                label6.Text = best.ToString();
            }
            else
            {
                label6.Text = "Wrong input. Please try again.";
            }
        }
    }
}
