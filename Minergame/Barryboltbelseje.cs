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

        private void Barryboltbelseje_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;

            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;

            button1.Enabled = false;

        }
    }
}
