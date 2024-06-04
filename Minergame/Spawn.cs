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
                if (player2.Bounds.IntersectsWith(Anna.Bounds))
                {
                    
                    this.Hide();
                    Annabolt belul = new Annabolt();
                    belul.ShowDialog();
                }
                if (player2.Bounds.IntersectsWith(Barry.Bounds))
                {
                    this.Hide();
                    Barrybolt belul = new Barrybolt();
                    belul.ShowDialog();
                }
                if (player2.Bounds.IntersectsWith(bejárat.Bounds))
                {
                    this.Hide();
                    Barlang belul = new Barlang();
                    belul.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nemfutszki();
            if (player2.Bounds.IntersectsWith(Anna.Bounds))
            {
                Interactbutton.Location = new Point(player2.Location.X + 50, player2.Location.Y-30);
                Interactbutton.Visible = true;

            }
            else if (player2.Bounds.IntersectsWith(Barry.Bounds))
            {
                Interactbutton.Location = new Point(player2.Location.X + 50, player2.Location.Y - 30);
                Interactbutton.Visible = true;
            }
            else if (player2.Bounds.IntersectsWith(bejárat.Bounds))
            {
                Interactbutton.Location = new Point(player2.Location.X + 50, player2.Location.Y - 30);
                Interactbutton.Visible = true;
            }
            else
            {
                Interactbutton.Visible = false;
            }
            if (player2.Bounds.IntersectsWith(Hazteto.Bounds))
            {
                Hazteto.Visible = false;

            }
            else
            {
                Hazteto.Visible = true;
            }
        }

        private void nemfutszki()
        {
            if (player2.Bounds.Location.Y > 580)
            {
                player2.Location = new Point(player2.Location.X, 570);
            }
            else if (player2.Bounds.Location.Y < 250)
            {
                player2.Location = new Point(player2.Location.X, 260);
            }
            if (player2.Bounds.Location.X > 800)
            {
                player2.Location = new Point(790, player2.Location.Y);
            }
            else if (player2.Bounds.Location.X < 50)
            {
                player2.Location = new Point(60, player2.Location.Y);
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

        private void player2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
