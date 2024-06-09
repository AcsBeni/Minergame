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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Barryboltbelseje belul = new Barryboltbelseje();
            this.Hide();
            belul.ShowDialog();
            belul = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Itemek.penz.ToString();
        }
    }
}
