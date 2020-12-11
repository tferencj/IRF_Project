using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Megsegomb : Button
    {
        public Megsegomb()
        {
            InitializeComponent();
            this.Click += new System.EventHandler(this.buttonmegse_Click);
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Location = new System.Drawing.Point(625, 347);
            this.Name = "buttonmegse";
            this.Size = new System.Drawing.Size(163, 91);
            this.TabIndex = 4;
            this.Text = "Mégse";
            this.UseVisualStyleBackColor = true;
        }
        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            t.Show();
        }
    }
}
