
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Goldamount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gold = new System.Windows.Forms.PictureBox();
            this.Interactbutton = new System.Windows.Forms.PictureBox();
            this.bejárat = new System.Windows.Forms.PictureBox();
            this.Anna = new System.Windows.Forms.PictureBox();
            this.Barry = new System.Windows.Forms.PictureBox();
            this.player1 = new Minergame.Gameobjects.Player();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Goldamount
            // 
            this.Goldamount.AutoSize = true;
            this.Goldamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Goldamount.Location = new System.Drawing.Point(54, 22);
            this.Goldamount.Name = "Goldamount";
            this.Goldamount.Size = new System.Drawing.Size(27, 20);
            this.Goldamount.TabIndex = 7;
            this.Goldamount.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(492, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.Color.Transparent;
            this.Gold.Image = global::Minergame.Properties.Resources.Pénz;
            this.Gold.Location = new System.Drawing.Point(12, 12);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(36, 41);
            this.Gold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gold.TabIndex = 6;
            this.Gold.TabStop = false;
            // 
            // Interactbutton
            // 
            this.Interactbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Interactbutton.Location = new System.Drawing.Point(141, 493);
            this.Interactbutton.Name = "Interactbutton";
            this.Interactbutton.Size = new System.Drawing.Size(26, 29);
            this.Interactbutton.TabIndex = 5;
            this.Interactbutton.TabStop = false;
            // 
            // bejárat
            // 
            this.bejárat.BackColor = System.Drawing.SystemColors.Highlight;
            this.bejárat.Location = new System.Drawing.Point(385, 728);
            this.bejárat.Name = "bejárat";
            this.bejárat.Size = new System.Drawing.Size(296, 32);
            this.bejárat.TabIndex = 4;
            this.bejárat.TabStop = false;
            // 
            // Anna
            // 
            this.Anna.BackColor = System.Drawing.Color.Transparent;
            this.Anna.Image = global::Minergame.Properties.Resources.Anna;
            this.Anna.Location = new System.Drawing.Point(627, 248);
            this.Anna.Name = "Anna";
            this.Anna.Size = new System.Drawing.Size(140, 135);
            this.Anna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Anna.TabIndex = 3;
            this.Anna.TabStop = false;
            // 
            // Barry
            // 
            this.Barry.BackColor = System.Drawing.Color.Transparent;
            this.Barry.Image = global::Minergame.Properties.Resources.Berry;
            this.Barry.Location = new System.Drawing.Point(119, 116);
            this.Barry.Name = "Barry";
            this.Barry.Size = new System.Drawing.Size(135, 135);
            this.Barry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barry.TabIndex = 2;
            this.Barry.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Location = new System.Drawing.Point(364, 355);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(90, 135);
            this.player1.TabIndex = 9;
            this.player1.Load += new System.EventHandler(this.player1_Load);
            // 
            // Spawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Goldamount);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.Interactbutton);
            this.Controls.Add(this.bejárat);
            this.Controls.Add(this.Anna);
            this.Controls.Add(this.Barry);
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "Spawn";
            this.Text = "Spawn";
            this.Load += new System.EventHandler(this.Spawn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Barry;
        private System.Windows.Forms.PictureBox Anna;
        private System.Windows.Forms.PictureBox bejárat;
        private System.Windows.Forms.PictureBox Interactbutton;
        private System.Windows.Forms.PictureBox Gold;
        private System.Windows.Forms.Label Goldamount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Gameobjects.Player player1;
    }
}