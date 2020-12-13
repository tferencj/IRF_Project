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
    public partial class tagkilep : _Form
    {
        IRF_databaseEntitiesP context = new IRF_databaseEntitiesP();
        public tagkilep()
        {
            InitializeComponent();
            taglistazas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taglistazas();
        }
        private void taglistazas()
        {
            dataGridViewkonyv.Controls.Clear();

            var t = from x in context.Tags
                    where x.Nev.Contains(textBox1.Text)
                    select x;
            bindingSource1.DataSource = t.ToList();
        }

        private void buttonkilep_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void tagkilep_Load(object sender, EventArgs e)
        {
            //véletlen
        }
    }
}
