
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
            this.Goldamount = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.PictureBox();
            this.Interactbutton = new System.Windows.Forms.PictureBox();
            this.bejárat = new System.Windows.Forms.PictureBox();
            this.Anna = new System.Windows.Forms.PictureBox();
            this.Barry = new System.Windows.Forms.PictureBox();
            this.player1 = new Minergame.Gameobjects.Player();
            this.Hazteto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hazteto)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Goldamount
            // 
            this.Goldamount.AutoSize = true;
            this.Goldamount.BackColor = System.Drawing.Color.Transparent;
            this.Goldamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Goldamount.Location = new System.Drawing.Point(54, 22);
            this.Goldamount.Name = "Goldamount";
            this.Goldamount.Size = new System.Drawing.Size(27, 20);
            this.Goldamount.TabIndex = 7;
            this.Goldamount.Text = "10";
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
            this.Interactbutton.Location = new System.Drawing.Point(289, 24);
            this.Interactbutton.Name = "Interactbutton";
            this.Interactbutton.Size = new System.Drawing.Size(26, 29);
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
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Location = new System.Drawing.Point(398, 362);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(164, 191);
            this.player1.TabIndex = 8;
            // 
            // Hazteto
            // 
            this.Hazteto.Location = new System.Drawing.Point(113, 111);
            this.Hazteto.Name = "Hazteto";
            this.Hazteto.Size = new System.Drawing.Size(214, 321);
            this.Hazteto.TabIndex = 9;
            this.Hazteto.TabStop = false;
            // 
            // Spawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.bejárat);
            this.Controls.Add(this.Hazteto);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.Interactbutton);
            this.Controls.Add(this.Barry);
            this.Controls.Add(this.Anna);
            this.Controls.Add(this.Goldamount);
            this.Controls.Add(this.Gold);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "Spawn";
            this.Text = "Spawn";
            this.Load += new System.EventHandler(this.Spawn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hazteto)).EndInit();
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
        private Gameobjects.Player player1;
        private System.Windows.Forms.PictureBox Hazteto;
    }
}