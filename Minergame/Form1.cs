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
    public partial class kezdo : Form
    {
        public kezdo()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            keszitok f2 = new keszitok();
            this.Hide();
            f2.ShowDialog();
            f2 = null;
            this.Show();
            
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Spawn spawn = new Spawn();
            this.Hide();

            spawn.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Spawn spawn = new Spawn();
            this.Hide();

            spawn.Show();
        }

        private void kezdo_FormClosed(object sender, FormClosedEventArgs e)
        {
            label1.Enabled = false;
            pictureBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            
        }
    }
}
