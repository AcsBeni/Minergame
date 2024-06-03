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
        public bool csizma = false;
        public bool duplaerc = false;
        public bool haste = false;
        public bool sapka = false;

        public Annaboltbelül()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Annabolt bolt = new Annabolt();
            bolt.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            csizma = true;
            pictureBox3.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            duplaerc = true;
            pictureBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            haste = true;
            pictureBox2.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sapka = true;
            pictureBox5.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string szerencse = "szerencsed lesz";
            string balszerencs = "balszerencse";
            string semmi = "üres";
            Random rnd = new Random();
            int szam = rnd.Next(1, 4);

            if (szam==1)
            {
                MessageBox.Show(szerencse);
            }
            else if (szam==2)
            {
                MessageBox.Show(balszerencs);
            }
            else
            {
                MessageBox.Show(semmi);
            }
        }
    }
}
