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
    public partial class Epilogi : Form
    {
        public Epilogi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Create a new instance of the Form2 class
                Point p = this.Location;
                TelikosBathmos bathmoi = new TelikosBathmos();
                this.Hide();
                bathmoi.Location = new Point(p.X + 10, p.Y); //Location!
                // Show the settings form
                bathmoi.ShowDialog();
                //bathmoi.ShowDialog();
                //this.Close();
            }

            if (radioButton2.Checked)
            {
                // Create a new instance of the Form2 class
                Point p = this.Location;
                EpithimitosBathmos bathmoi = new EpithimitosBathmos();
                this.Hide();
                bathmoi.Location = new Point(p.X + 10, p.Y); //Location!
                // Show the settings form
                bathmoi.ShowDialog();
                //bathmoi.ShowDialog();
                //this.Close();
            }
            //System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
