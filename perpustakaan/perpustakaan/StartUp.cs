﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using perpustakaan.view;

namespace perpustakaan
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ParentForm frm = new ParentForm();
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();

                Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
