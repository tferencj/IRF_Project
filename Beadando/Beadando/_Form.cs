﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class _Form : Form
    {
        public _Form()
        {
            InitializeComponent();
            Megsegomb megsebutton = new Megsegomb();
            Controls.Add(megsebutton);
            megsebutton.Click += new System.EventHandler(this.buttonmegse_Click);
        }
        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            t.Show();
            this.Close();
        }
    }
}
