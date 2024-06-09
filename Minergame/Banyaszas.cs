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
            timer1.Start();
            hpadas();
        }

        private void hpadas()
        {
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






        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Itemek.penz.ToString();

            label3.Text = hp.ToString();
            if (hp == 0)
            {
                penzadas();
                timer1.Stop();
                this.Close();
            }
            if (hp <= 19 && hp>= 11)
            {
                this.pictureBox1.Image = global::Minergame.Properties.Resources.Kőtörés2;
            }
            else if (hp<=10)
            {
                this.pictureBox1.Image = global::Minergame.Properties.Resources.Kőtörés3;
            }
        }

        private void penzadas()
        {
            Random r = new Random();
            Itemek.penz += r.Next(3, 7);
        }

    }
}
