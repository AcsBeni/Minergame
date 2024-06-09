using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minergame
{
    public partial class Annaboltbelül : Form
    {
        

        public Annaboltbelül()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=7)
            {
                Itemek.csizma = true;
                pictureBox3.Enabled = false;
                Itemek.penz -= 7;
                label2.Text = "Sold";
                pictureBox10.Visible = false;
                vettel();
            }
            
        }

        private void vettel()
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=17)
            {
                Itemek.duplaerc = true;
                pictureBox1.Enabled = false;
                Itemek.penz -= 17;
                label3.Text = "Sold";
                pictureBox11.Visible = false;
                vettel();

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=27)
            {
                Itemek.haste = true;
                pictureBox2.Enabled = false;
                Itemek.penz -= 27;
                label4.Text = "Sold";
                pictureBox12.Visible = false;
                vettel();
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=50)
            {
                Itemek.sapka = true;
                pictureBox5.Enabled = false;
                Itemek.penz -= 50;
                label6.Text = "Sold";
                pictureBox14.Visible = false;
                vettel();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=80)
            {
                Itemek.bor = true;
                Itemek.penz -= 80;
                label7.Text = "Sold";
                pictureBox15.Visible = false;
                vettel();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=1)
            {
                Itemek.penz -= 1;
                string szerencse = "szerencsed lesz";
                string balszerencs = "balszerencse";
                string semmi = "üres";
                Random rnd = new Random();
                int szam = rnd.Next(1, 4);

                if (szam == 1)
                {
                    MessageBox.Show(szerencse);
                }
                else if (szam == 2)
                {
                    MessageBox.Show(balszerencs);
                }
                else
                {
                    MessageBox.Show(semmi);
                }

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=  Itemek.penz.ToString();
        }
    }
}
