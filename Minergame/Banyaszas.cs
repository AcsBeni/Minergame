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
    public partial class Banyaszas : Form
    {
        public static int hp;
        public Banyaszas()
        {
            InitializeComponent();
            this.CenterToScreen();
            
            hpadas();
        }

        private void hpadas()
        {
            label1.Text = Itemek.penz.ToString();
            if (Itemek.haste)
            {
                hp = 20;
            }
            else
            {
                hp = 40;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            hp -= 1;
            if (Itemek.kocsakany)
            {
                hp -= 1;
            }
            if (Itemek.gyemantcsakany)
            {
                hp -= 2;
            }
            if (Itemek.amethystcsakany)
            {
                hp -= 3;
            }
            if (Itemek.uraniumcsakany)
            {
                hp -= 4;
            }
            if (Itemek.emeraldcsakany)
            {
                hp -= 5;
            }
            if (Itemek.procsakany)
            {
                hp -= 6;
            }

            label3.Text = hp.ToString();
            if (hp <= 19 && hp >= 11)
            {
                this.pictureBox1.Image = global::Minergame.Properties.Resources.Kőtörés2;
            }
            if (hp <= 10)
            {
                this.pictureBox1.Image = global::Minergame.Properties.Resources.Kőtörés3;
            }

            if (hp <= 0)
            {
                penzadas();

                this.Close();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            
            
           
        }

        private void penzadas()
        {
            Random r = new Random();
            if (Itemek.duplaerc)
            {
                Itemek.penz += r.Next(10, 14);
            }
            else
            {
                Itemek.penz += r.Next(5, 7);
            }
            
        }

        private void Banyaszas_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox9.Enabled = false;
            label1.Enabled = false;
            label3.Enabled = false;
            label2.Enabled = false;
            timer1.Enabled = false;
        }
    }
}
