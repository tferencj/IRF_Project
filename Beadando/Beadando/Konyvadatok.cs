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
    public partial class Konyvadatok : _Form
    {
        IRF_databaseEntitiesP context = new IRF_databaseEntitiesP();

        public Konyvadatok()
        {
            InitializeComponent();
            konyvlistazas();
        }

        private void buttonkonyv_Click(object sender, EventArgs e)
        {
            Konyvszerkeztes k = new Konyvszerkeztes();
            k.Show();
            this.Close();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        private void konyvlistazas()
        {
            var k = from x in context.Konyvs
                    where x.Nev.Contains(textBox1.Text)
                    select x;

            bindingSource1.DataSource = k.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            konyvlistazas();
        }

        private void buttondia_Click(object sender, EventArgs e)
        {
            Diagram d = new Diagram();
            d.Show();
            this.Close();
        }
    }
}
