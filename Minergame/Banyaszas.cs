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
        public static int hp = 40;
        public Banyaszas()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hp >= 0)
            {
                if (Itemek.kocsakany)
                {
                    hp -= 1;
                    if (Itemek.haste)
                    {
                        hp -= 1;
                    }
                }
                if (Itemek.gyemantcsakany)
                {
                    hp -= 2;
                    if (Itemek.haste)
                    {
                        hp -= 2;
                    }
                }
                if (Itemek.amethystcsakany)
                {
                    hp -= 3;
                    if (Itemek.haste)
                    {
                        hp -= 3;
                    }
                }
                if (Itemek.uraniumcsakany)
                {
                    hp -= 4;
                    if (Itemek.haste)
                    {
                        hp -= 4;
                    }
                }
                if (Itemek.emeraldcsakany)
                {
                    hp -= 5;
                    if (Itemek.haste)
                    {
                        hp -= 5;
                    }
                }
                if (Itemek.procsakany)
                {
                    hp -= 6;
                    if (Itemek.haste)
                    {
                        hp -= 6;
                    }
                }
            }
            else
            {
                hp = 40;
                this.Hide();
            }


        }
    }
}
