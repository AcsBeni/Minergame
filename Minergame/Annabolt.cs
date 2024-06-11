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
    public partial class Annabolt : Form
    {
        public Annabolt()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Text = Itemek.penz.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Spawn belul = new Spawn();
            
            belul.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Annaboltbelül belul = new Annaboltbelül();
            
            belul.Show();
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Annabolt_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            label1.Enabled = false;
            pictureBox9.Enabled = false;
        }
    }
}
