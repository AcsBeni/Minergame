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
            this.Hide();
            keszitok f2 = new keszitok();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Spawn spawn = new Spawn();
            spawn.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spawn spawn = new Spawn();
            spawn.ShowDialog();
        }
    }
}
