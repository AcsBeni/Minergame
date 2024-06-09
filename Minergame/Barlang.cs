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
    public partial class Barlang : Form
    {
        public Barlang()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Barlang_KeyDown(object sender, KeyEventArgs e)
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
                if (player3.Bounds.IntersectsWith(panel1.Bounds))
                {

                    this.Close();
                }

                if (player3.Bounds.IntersectsWith(Ko2.Bounds))
                {
                    if (Ko2.Enabled)
                    {
                        Banyaszas belul = new Banyaszas();
                        belul.ShowDialog();
                    }
                    Ko2.Visible = false;
                    Ko2.Enabled = false;
                    
                    
                }
                if (player3.Bounds.IntersectsWith(Ko3.Bounds))
                {
                    if (Ko3.Enabled)
                    {
                        Banyaszas belul = new Banyaszas();
                        belul.ShowDialog();
                    }
                    Ko3.Visible = false;
                    Ko3.Enabled = false;

                   
                }
                if (player3.Bounds.IntersectsWith(Ko1.Bounds))
                {
                    if (Ko1.Enabled)
                    {
                        Banyaszas belul = new Banyaszas();
                        belul.ShowDialog();
                    }
                    Ko1.Visible = false;
                    Ko1.Enabled = false;

                    
                }

            }
        }

        private void Barlang_KeyUp(object sender, KeyEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            nemfutszki();

            if (player3.Bounds.IntersectsWith(Ko1.Bounds))
            {
                if (Ko1.Enabled)
                {
                    Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                    Interactbutton.Visible = true;
                }
               

            }
            else if (player3.Bounds.IntersectsWith(Ko2.Bounds))
            {
                if (Ko2.Enabled)
                {
                    Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                    Interactbutton.Visible = true;
                }
                
            }
            else if (player3.Bounds.IntersectsWith(Ko3.Bounds))
            {
                if (Ko3.Enabled)
                {
                    Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                    Interactbutton.Visible = true;
                }
                
            }
            else if (player3.Bounds.IntersectsWith(panel1.Bounds))
            {
                Interactbutton.Location = new Point(player3.Location.X + 50, player3.Location.Y - 30);
                Interactbutton.Visible = true;

            }
            else
            {
                Interactbutton.Visible = false;
            }

            label1.Text = Itemek.penz.ToString();

        }

        private void nemfutszki()
        {
            if (player3.Bounds.Location.Y > 580)
            {
                player3.Location = new Point(player3.Location.X, 570);
            }
            else if (player3.Bounds.Location.Y < 20)
            {
                player3.Location = new Point(player3.Location.X, 30);
            }
            if (player3.Bounds.Location.X > 800)
            {
                player3.Location = new Point(790, player3.Location.Y);
            }
            else if (player3.Bounds.Location.X < 120)
            {
                player3.Location = new Point(130, player3.Location.Y);
            }
        }

        private void Barlang_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void Barlang_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
