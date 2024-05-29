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

            if (e.KeyCode == Keys.E)
            {
                if (player1.Bounds.IntersectsWith(Anna.Bounds))
                {
                    
                    this.Hide();
                    Annabolt belul = new Annabolt();
                    belul.ShowDialog();
                }
                if (player1.Bounds.IntersectsWith(Barry.Bounds))
                {
                    this.Hide();
                    Barrybolt belul = new Barrybolt();
                    belul.ShowDialog();
                }
                if (player1.Bounds.IntersectsWith(bejárat.Bounds))
                {
                    this.Hide();
                    Barlang belul = new Barlang();
                    belul.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player1.Bounds.IntersectsWith(Anna.Bounds))
            {
                Interactbutton.Location = new Point(player1.Location.X + 35, player1.Location.Y-20);
                Interactbutton.Visible = true;

            }
            else if (player1.Bounds.IntersectsWith(Barry.Bounds))
            {
                Interactbutton.Location = new Point(player1.Location.X + 35, player1.Location.Y - 20);
                Interactbutton.Visible = true;
            }
            else if (player1.Bounds.IntersectsWith(bejárat.Bounds))
            {
                Interactbutton.Location = new Point(player1.Location.X + 35, player1.Location.Y - 20);
                Interactbutton.Visible = true;
            }
            else
            {
                Interactbutton.Visible = false;
            }
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
