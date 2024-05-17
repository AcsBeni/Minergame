
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Barry = new System.Windows.Forms.PictureBox();
            this.Anna = new System.Windows.Forms.PictureBox();
            this.bejárat = new System.Windows.Forms.PictureBox();
            this.Interactbutton = new System.Windows.Forms.PictureBox();
            this.Gold = new System.Windows.Forms.PictureBox();
            this.Goldamount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Player.Location = new System.Drawing.Point(448, 569);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(135, 135);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Barry
            // 
            this.Barry.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Barry.Location = new System.Drawing.Point(119, 116);
            this.Barry.Name = "Barry";
            this.Barry.Size = new System.Drawing.Size(135, 135);
            this.Barry.TabIndex = 2;
            this.Barry.TabStop = false;
            // 
            // Anna
            // 
            this.Anna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Anna.Location = new System.Drawing.Point(702, 151);
            this.Anna.Name = "Anna";
            this.Anna.Size = new System.Drawing.Size(135, 135);
            this.Anna.TabIndex = 3;
            this.Anna.TabStop = false;
            // 
            // bejárat
            // 
            this.bejárat.BackColor = System.Drawing.SystemColors.Highlight;
            this.bejárat.Location = new System.Drawing.Point(364, 730);
            this.bejárat.Name = "bejárat";
            this.bejárat.Size = new System.Drawing.Size(296, 32);
            this.bejárat.TabIndex = 4;
            this.bejárat.TabStop = false;
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
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Gold.Location = new System.Drawing.Point(12, 12);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(36, 41);
            this.Gold.TabIndex = 6;
            this.Gold.TabStop = false;
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
            // Spawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.Goldamount);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.Interactbutton);
            this.Controls.Add(this.bejárat);
            this.Controls.Add(this.Anna);
            this.Controls.Add(this.Barry);
            this.Controls.Add(this.Player);
            this.Name = "Spawn";
            this.Text = "Spawn";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spawn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejárat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interactbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Barry;
        private System.Windows.Forms.PictureBox Anna;
        private System.Windows.Forms.PictureBox bejárat;
        private System.Windows.Forms.PictureBox Interactbutton;
        private System.Windows.Forms.PictureBox Gold;
        private System.Windows.Forms.Label Goldamount;
    }
}