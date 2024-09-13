﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_1_2MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            lblResult.Text = "새 파일을 만듭니다.";
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            lblResult.Text = "파일을 엽니다.";
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = "파일을 저장합니다.";
        }

        private void TooStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
