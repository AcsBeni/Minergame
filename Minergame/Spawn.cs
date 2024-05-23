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

           
            if (e.KeyCode == Keys.Right)
            {
                if (Player.Location.X + Player.Size.Width < 1000)
                {
                    Player.Location = new Point(Player.Location.X + 15, Player.Location.Y);


                }

            }
            if (e.KeyCode == Keys.Left)
            {
                if (Player.Location.X + Player.Size.Width > 130)
                {
                    Player.Location = new Point(Player.Location.X - 15, Player.Location.Y);



                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (Player.Location.Y + Player.Size.Height > 220)
                {
                    Player.Location = new Point(Player.Location.X, Player.Location.Y - 15);


                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (Player.Location.Y + Player.Size.Height < 750)
                {
                    Player.Location = new Point(Player.Location.X, Player.Location.Y + 15);
                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (Player.Bounds.IntersectsWith(bejárat.Bounds))
                {
                    this.Hide();
                    Barlang cave = new Barlang();
                    cave.ShowDialog();
                }
                else if (Player.Bounds.IntersectsWith(Anna.Bounds))
                {
                    this.Hide();
                    Annabolt bolt = new Annabolt();
                    bolt.ShowDialog();
                }
                else if (Player.Bounds.IntersectsWith(Barry.Bounds))
                {
                    this.Hide();
                    Barrybolt bolt = new Barrybolt();
                    bolt.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
