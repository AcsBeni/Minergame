
namespace Minergame
{
    partial class Barlang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barlang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ko1 = new System.Windows.Forms.PictureBox();
            this.Ko3 = new System.Windows.Forms.PictureBox();
            this.Ko2 = new System.Windows.Forms.PictureBox();
            this.player3 = new Minergame.Gameobjects.Player();
            this.Interactbutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ko1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ko3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ko2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(384, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 68);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ko1
            // 
            this.Ko1.BackColor = System.Drawing.Color.Transparent;
            this.Ko1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ko1.BackgroundImage")));
            this.Ko1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ko1.Location = new System.Drawing.Point(224, 367);
            this.Ko1.Name = "Ko1";
            this.Ko1.Size = new System.Drawing.Size(203, 215);
            this.Ko1.TabIndex = 2;
            this.Ko1.TabStop = false;
            // 
            // Ko3
            // 
            this.Ko3.BackColor = System.Drawing.Color.Transparent;
            this.Ko3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ko3.BackgroundImage")));
            this.Ko3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ko3.Location = new System.Drawing.Point(742, 207);
            this.Ko3.Name = "Ko3";
            this.Ko3.Size = new System.Drawing.Size(148, 215);
            this.Ko3.TabIndex = 3;
            this.Ko3.TabStop = false;
            // 
            // Ko2
            // 
            this.Ko2.BackColor = System.Drawing.Color.Transparent;
            this.Ko2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ko2.BackgroundImage")));
            this.Ko2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ko2.Location = new System.Drawing.Point(706, 598);
            this.Ko2.Name = "Ko2";
            this.Ko2.Size = new System.Drawing.Size(148, 71);
            this.Ko2.TabIndex = 4;
            this.Ko2.TabStop = false;
            // 
            // player3
            // 
            this.player3.BackColor = System.Drawing.Color.Transparent;
            this.player3.Location = new System.Drawing.Point(458, 74);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(125, 186);
            this.player3.TabIndex = 0;
            // 
            // Interactbutton
            // 
            this.Interactbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Interactbutton.BackgroundImage = global::Minergame.Properties.Resources.interakciogomb;
            this.Interactbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Interactbutton.Location = new System.Drawing.Point(288, 60);
            this.Interactbutton.Name = "Interactbutton";
            this.Interactbutton.Size = new System.Drawing.Size(26, 29);
            this.Interactbutton.TabIndex = 6;
            this.Interactbutton.TabStop = false;
            this.Interactbutton.Visible = false;
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
            // Barlang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Interactbutton);
            this.Controls.Add(this.Ko2);
            this.Controls.Add(this.Ko3);
            this.Controls.Add(this.Ko1);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "Barlang";
            this.Text = "Barlang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Barlang_FormClosed);
            this.Load += new System.EventHandler(this.Barlang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Barlang_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Barlang_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ko1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ko3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ko2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gameobjects.Player player3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ko1;
        private System.Windows.Forms.PictureBox Ko3;
        private System.Windows.Forms.PictureBox Ko2;
        private System.Windows.Forms.PictureBox Interactbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}