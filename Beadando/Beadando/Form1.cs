using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontag_Click(object sender, EventArgs e)
        {
            Tagadatok t = new Tagadatok();
            t.Show();
            this.Hide();
        }

        private void buttonkonyv_Click(object sender, EventArgs e)
        {
            Konyvadatok k = new Konyvadatok();
            k.Show();
            this.Hide();
        }

        private void Buttonbezar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonkolcsonzes_Click(object sender, EventArgs e)
        {
            Kolcsonzesadatok k = new Kolcsonzesadatok();
            k.Show();
            this.Hide();
        }
    }
}
