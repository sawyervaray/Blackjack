﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        override
        protected void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {



            //Add column header

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
