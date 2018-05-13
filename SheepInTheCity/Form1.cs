﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepInTheCity
{
    public partial class Form1 : Form
    {
        
        private Form3 form3;
        private Form4 form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Show();
            
        }
    }
}
