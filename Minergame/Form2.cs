﻿using System;
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
    public partial class keszitok : Form
    {
        public keszitok()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void keszitok_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;

            button1.Enabled = false;
        }
    }
}
