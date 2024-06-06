
namespace Minergame
{
    partial class Spawn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spawn));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Interactbutton = new System.Windows.Forms.PictureBox();
            this.bejárat = new System.Windows.Forms.PictureBox();
            this.Anna = new System.Windows.Forms.PictureBox();
            this.Barry = new System.Windows.Forms.PictureBox();
            this.Hazteto = new System.Windows.Forms.PictureBox();
            this.player3 = new Minergame.Gameobjects.Player();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hazteto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Interactbutton
            // 
            this.Interactbutton.BackColor = System.Drawing.Color.Transparent;
            this.Interactbutton.BackgroundImage = global::Minergame.Properties.Resources.interakciogomb;
            this.Interactbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Interactbutton.Location = new System.Drawing.Point(289, 24);
            this.Interactbutton.Name = "Interactbutton";
            this.Interactbutton.Size = new System.Drawing.Size(26, 29);
            this.Interactbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Interactbutton.TabIndex = 5;
            this.Interactbutton.TabStop = false;
            this.Interactbutton.Visible = false;
            // 
            // bejárat
            // 
            this.bejárat.BackColor = System.Drawing.Color.Transparent;
            this.bejárat.Image = ((System.Drawing.Image)(resources.GetObject("bejárat.Image")));
            this.bejárat.Location = new System.Drawing.Point(410, 682);
            this.bejárat.Name = "bejárat";
            this.bejárat.Size = new System.Drawing.Size(296, 127);
            this.bejárat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bejárat.TabIndex = 4;
            this.bejárat.TabStop = false;
            // 
            // Anna
            // 
            this.Anna.BackColor = System.Drawing.Color.Transparent;
            this.Anna.Location = new System.Drawing.Point(584, 289);
            this.Anna.Name = "Anna";
            this.Anna.Size = new System.Drawing.Size(186, 184);
            this.Anna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anna.TabIndex = 3;
            this.Anna.TabStop = false;
            this.Anna.Visible = false;
            // 
            // Barry
            // 
            this.Barry.BackColor = System.Drawing.Color.Transparent;
            this.Barry.Location = new System.Drawing.Point(155, 182);
            this.Barry.Name = "Barry";
            this.Barry.Size = new System.Drawing.Size(135, 135);
            this.Barry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barry.TabIndex = 2;
            this.Barry.TabStop = false;
            // 
            // Hazteto
            // 
            this.Hazteto.BackColor = System.Drawing.Color.Transparent;
            this.Hazteto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hazteto.Image = global::Minergame.Properties.Resources.Berryshoptop1;
            this.Hazteto.Location = new System.Drawing.Point(103, 90);
            this.Hazteto.Name = "Hazteto";
            this.Hazteto.Size = new System.Drawing.Size(249, 359);
            this.Hazteto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hazteto.TabIndex = 9;
            this.Hazteto.TabStop = false;
            // 
            // player3
            // 
            this.player3.BackColor = System.Drawing.Color.Transparent;
            this.player3.Location = new System.Drawing.Point(358, 399);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(126, 186);
            this.player3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "0";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Minergame.Properties.Resources.Pénz1;
            this.pictureBox9.Location = new System.Drawing.Point(12, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(53, 49);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            // 
            // Spawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Hazteto);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.bejárat);
            this.Controls.Add(this.Interactbutton);
            this.Controls.Add(this.Barry);
            this.Controls.Add(this.Anna);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "Spawn";
            this.Text = "Spawn";
            this.Load += new System.EventHandler(this.Spawn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hazteto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Barry;
        private System.Windows.Forms.PictureBox Anna;
        private System.Windows.Forms.PictureBox bejárat;
        private System.Windows.Forms.PictureBox Interactbutton;
        //private Gameobjects.Player player1;
        private System.Windows.Forms.PictureBox Hazteto;
        //private Gameobjects.Player player2;
        private Gameobjects.Player player3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}