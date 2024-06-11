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
    public partial class Barrybolt : Form
    {
        public Barrybolt()
        {
            InitializeComponent();
            this.CenterToScreen();
            label1.Text = Itemek.penz.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Barryboltbelseje belul = new Barryboltbelseje();
            
            
            belul.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Spawn belul = new Spawn();
            this.Hide();
            belul.Show();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Barrybolt_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            label1.Enabled = false;
            pictureBox9.Enabled = false;
        }
    }
}
