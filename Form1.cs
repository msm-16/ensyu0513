﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "ボタン１が押された";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Left = 600;
        }
    }
}
