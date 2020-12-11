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
    public partial class Tagadatok : _Form
    {
        IRF_databaseEntities context = new IRF_databaseEntities();

        public Tagadatok()
        {
            InitializeComponent();
            taglistazas();
        }

        private void buttonkonyv_Click(object sender, EventArgs e)
        {
            Tagszerkeztes t = new Tagszerkeztes();
            t.Show();
            this.Close();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        private void taglistazas()
        {
            var t = from x in context.Tags
                    where x.Nev.Contains(textBox1.Text)
                    select x;

            bindingSource1.DataSource = t.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taglistazas();
        }
    }
}
