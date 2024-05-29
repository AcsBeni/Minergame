using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minergame.Gameobjects
{
    public class Player : UserControl
    {
        private Timer Timerupdate;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;

        private int speed = 12;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timerupdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minergame.Properties.Resources.Mike;
            this.pictureBox1.Location = new System.Drawing.Point(-48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Timerupdate
            // 
            this.Timerupdate.Enabled = true;
            this.Timerupdate.Interval = 33;
            this.Timerupdate.Tick += new System.EventHandler(this.Update);
            // 
            // Player
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(91, 135);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public Player()
        {
            InitializeComponent();
        }
        private void Update(object sender, EventArgs e)
        {
            if (Core.IsUp)
                Top -= speed;
            if (Core.IsDown)
                Top += speed;
            if (Core.IsRight)
                Left += speed;
            if (Core.IsLeft)
                Left -= speed;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
