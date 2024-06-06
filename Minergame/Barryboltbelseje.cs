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
    public partial class Barryboltbelseje : Form
    {

        public Barryboltbelseje()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Barrybolt bolt = new Barrybolt();
            bolt.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=3)
            {
                Itemek.kocsakany = true;
                Itemek.gyemantcsakany = false;
                Itemek.amethystcsakany = false;
                Itemek.uraniumcsakany = false;
                Itemek.emeraldcsakany = false;
                Itemek.procsakany = false;
                pictureBox1.Enabled = false;
                Itemek.penz -= 3;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=23)
            {

                Itemek.gyemantcsakany = true;
                Itemek.kocsakany = false;
                Itemek.amethystcsakany = false;
                Itemek.uraniumcsakany = false;
                Itemek.emeraldcsakany = false;
                Itemek.procsakany = false;
                pictureBox2.Enabled = false;
                Itemek.penz -= 23;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=33)
            {
                Itemek.amethystcsakany = true;
                Itemek.gyemantcsakany = false;
                Itemek.kocsakany = false;
                Itemek.uraniumcsakany = false;
                Itemek.emeraldcsakany = false;
                Itemek.procsakany = false;
                pictureBox3.Enabled = false;
                Itemek.penz -= 33;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=43)
            {
                Itemek.uraniumcsakany = true;
                Itemek.gyemantcsakany = false;
                Itemek.amethystcsakany = false;
                Itemek.kocsakany = false;
                Itemek.emeraldcsakany = false;
                Itemek.procsakany = false;
                pictureBox4.Enabled = false;
                Itemek.penz -= 43;
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=53)
            {
                Itemek.emeraldcsakany = true;
                Itemek.gyemantcsakany = false;
                Itemek.amethystcsakany = false;
                Itemek.uraniumcsakany = false;
                Itemek.kocsakany = false;
                Itemek.procsakany = false;
                pictureBox5.Enabled = false;
                Itemek.penz -= 53;
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Itemek.penz>=63)
            {
                Itemek.procsakany = true;
                Itemek.gyemantcsakany = false;
                Itemek.amethystcsakany = false;
                Itemek.uraniumcsakany = false;
                Itemek.emeraldcsakany = false;
                Itemek.kocsakany = false;
                pictureBox6.Enabled = false;
                Itemek.penz -= 63;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Itemek.penz.ToString();
        }
    }
}
