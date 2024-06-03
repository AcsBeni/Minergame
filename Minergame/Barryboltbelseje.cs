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
        public bool kocsakany = false;
        public bool gyemantcsakany = false;
        public bool amethystcsakany = false;
        public bool uraniumcsakany = false;
        public bool emeraldcsakany = false;
        public bool procsakany = false;




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
            kocsakany = true;
            gyemantcsakany = false;
            amethystcsakany = false;
            uraniumcsakany = false;
            emeraldcsakany = false;
            procsakany = false;
            pictureBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gyemantcsakany = true;
            kocsakany = false;
            amethystcsakany = false;
            uraniumcsakany = false;
            emeraldcsakany = false;
            procsakany = false;
            pictureBox2.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            amethystcsakany = true;
            gyemantcsakany = false;
            kocsakany = false;
            uraniumcsakany = false;
            emeraldcsakany = false;
            procsakany = false;
            pictureBox3.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            uraniumcsakany = true;
            gyemantcsakany = false;
            amethystcsakany = false;
            kocsakany = false;
            emeraldcsakany = false;
            procsakany = false;
            pictureBox4.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            emeraldcsakany = true;
            gyemantcsakany = false;
            amethystcsakany = false;
            uraniumcsakany = false;
            kocsakany = false;
            procsakany = false;
            pictureBox5.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            procsakany = true;
            gyemantcsakany = false;
            amethystcsakany = false;
            uraniumcsakany = false;
            emeraldcsakany = false;
            kocsakany = false;
            pictureBox6.Enabled = false;
        }
    }
}
