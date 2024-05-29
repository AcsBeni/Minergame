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
    public partial class Spawn : Form
    {
        public Spawn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
        private void Spawn_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Core.Keyup)
                Core.IsUp = true;
            if (e.KeyCode == Core.Keydown)
                Core.IsDown = true;
            if (e.KeyCode == Core.Keyright)
                Core.IsRight = true;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Spawn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.Keyup)
                Core.IsUp = false;
            if (e.KeyCode == Core.Keydown)
                Core.IsDown = false;
            if (e.KeyCode == Core.Keyright)
                Core.IsRight = false;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;
        }

        private void Spawn_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void player1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
