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
            label1.Text = Itemek.penz.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barrybolt belul = new Barrybolt();
            

            belul.Show();
            this.Close();
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
                label2.Text = "Sold";
                pictureBox10.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
            }
            
        }

        private void vetel()
        {
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
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
                label3.Text = "Sold";
                pictureBox11.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
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
                label4.Text = "Sold";
                pictureBox12.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
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
                label5.Text = "Sold";
                pictureBox13.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
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
                label6.Text = "Sold";
                pictureBox14.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
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
                label7.Text = "Sold";
                pictureBox15.Visible = false;
                vetel();
                label1.Text = Itemek.penz.ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
