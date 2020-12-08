using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бандит
{
    public partial class Бандит : Form
    {
        public Бандит()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvig1.Enabled = true;
            dvig2.Enabled = true;
            dvig3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l1.Text = System.Convert.ToString(dig);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            dvig3.Enabled = false;
            stop3.Enabled = false;


            if ((l1.Text == "1") && (l2.Text == "1"))
            {
                if (l3.Text != "1")
                MessageBox.Show("Ви виграли $100");
            }
            if ((l1.Text == "2") && (l2.Text == "2"))
            {
                if (l3.Text != "2")
                    MessageBox.Show("Ви виграли $200");
            }
            if ((l1.Text == "3") && (l2.Text == "3"))
            {
                if (l3.Text != "3")
                    MessageBox.Show("Ви виграли $300");
            }
            if ((l1.Text == "4") && (l2.Text == "4"))
            {
                if (l3.Text != "4")
                    MessageBox.Show("Ви виграли $400");
            }
            if ((l1.Text == "5") && (l2.Text == "5"))
            {
                if (l3.Text != "5")
                    MessageBox.Show("Ви виграли $500");
            }
            if ((l1.Text == "6") && (l2.Text == "6"))
            {
                if (l3.Text != "6")
                    MessageBox.Show("Ви виграли $600");
            }
            if ((l1.Text == "7") && (l2.Text == "7"))
            {
                if (l3.Text != "7")
                    MessageBox.Show("Ви виграли $700");

            }
            if ((l1.Text == "8") && (l2.Text == "8"))
            {
                if (l3.Text != "8")
                    MessageBox.Show("Ви виграли $800");
            } 
            if ((l1.Text == "9") && (l2.Text == "9"))
            {
                if (l3.Text != "9")
                    MessageBox.Show("Ви виграли $900");
            }

            if ((l1.Text == "1") && (l2.Text == "1") && (l3.Text == "1"))
            {
                MessageBox.Show("Ви виграли $1000");
            }
            if ((l1.Text == "2") && (l2.Text == "2") && (l3.Text == "2"))
            {
                MessageBox.Show("Ви виграли $2000");
            }
            if ((l1.Text == "2") && (l2.Text == "2") && (l3.Text == "2"))
            {
                MessageBox.Show("Ви виграли $2000");
            }
            if ((l1.Text == "3") && (l2.Text == "3") && (l3.Text == "3"))
            {
                MessageBox.Show("Ви виграли $3000");
            }
            if ((l1.Text == "3") && (l2.Text == "3") && (l3.Text == "3"))
            {
                MessageBox.Show("Ви виграли $3000");
            }
            if ((l1.Text == "4") && (l2.Text == "4") && (l3.Text == "4"))
            {
                MessageBox.Show("Ви виграли $4000");
            }
            if ((l1.Text == "5") && (l2.Text == "5") && (l3.Text == "5"))
            {
                MessageBox.Show("Ви виграли $5000");
            }
            if ((l1.Text == "6") && (l2.Text == "6") && (l3.Text == "6"))
            {
                MessageBox.Show("Ви виграли $6000");
            }
            if ((l1.Text == "7") && (l2.Text == "7") && (l3.Text == "7"))
            {
                MessageBox.Show("Ви виграли $1000000");
            }
            if ((l1.Text == "8") && (l2.Text == "8") && (l3.Text == "8"))
            {
                MessageBox.Show("Ви виграли $8000");
            }
            if ((l1.Text == "9") && (l2.Text == "9") && (l3.Text == "9"))
            {
                MessageBox.Show("Ви виграли $9000");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void Бандит_Load(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void dvig2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l2.Text = System.Convert.ToString(dig);
        }

        private void dvig3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dig = rand.Next(8);
            l3.Text = System.Convert.ToString(dig);
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dvig1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dvig2.Enabled = false;
            stop2.Enabled = false;
        }
    }
}
