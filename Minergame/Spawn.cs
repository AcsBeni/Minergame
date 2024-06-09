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
                if (player3.Bounds.IntersectsWith(Anna.Bounds))
                {


                    Annabolt belul = new Annabolt();
                    this.Hide();
                    belul.ShowDialog();
                    belul = null;
                    this.Show();
                }
                if (player3.Bounds.IntersectsWith(Barry.Bounds))
                {

                    Barrybolt belul = new Barrybolt();
                    this.Hide();
                    belul.ShowDialog();
                    belul = null;
                    this.Show();

                }
                if (player3.Bounds.IntersectsWith(bejárat.Bounds))
                {

                    Barlang belul = new Barlang();
                    this.Hide();
                    belul.ShowDialog();
                    belul = null;
                    this.Show();

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nemfutszki();
            if (player3.Bounds.IntersectsWith(Anna.Bounds))
            {
                Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y-30);
                Interactbutton.Visible = true;

            }
            else if (player3.Bounds.IntersectsWith(Barry.Bounds))
            {
                Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                Interactbutton.Visible = true;
            }
            else if (player3.Bounds.IntersectsWith(bejárat.Bounds))
            {
                Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                Interactbutton.Visible = true;
            }
            else
            {
                Interactbutton.Visible = false;
            }
            if (player3.Bounds.IntersectsWith(Hazteto.Bounds))
            {
                Hazteto.Visible = false;

            }
            else
            {
                Hazteto.Visible = true;
            }
            vege();
            label1.Text = Itemek.penz.ToString();

            

        }

        private void vege()
        {
            if (Itemek.procsakany == true && Itemek.bor == true)
            {
                End belul = new End();
                this.Hide();
                belul.ShowDialog();
                belul = null;
                this.Show();
            }
        }

        private void nemfutszki()
        {
            if (player3.Bounds.Location.Y > 580)
            {
                player3.Location = new Point(player3.Location.X, 570);
            }
            else if (player3.Bounds.Location.Y < 250)
            {
                player3.Location = new Point(player3.Location.X, 260);
            }
            if (player3.Bounds.Location.X > 800)
            {
                player3.Location = new Point(790, player3.Location.Y);
            }
            else if (player3.Bounds.Location.X < 50)
            {
                player3.Location = new Point(60, player3.Location.Y);
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
