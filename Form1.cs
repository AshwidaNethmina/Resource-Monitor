﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCpu.NextValue();
            chart1.Series["CPU"].Points.AddY(fcpu);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }
    }
}
