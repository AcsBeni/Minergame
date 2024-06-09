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
    public partial class keszitok : Form
    {
        public keszitok()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
