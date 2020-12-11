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
    public partial class Tagszerkeztes : _Form
    { //_form
        IRF_databaseEntities context = new IRF_databaseEntities();
        public Tagszerkeztes()
        {
            InitializeComponent();
            taglistazas();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Tagadatok t = new Tagadatok();
            t.Show();
        }

        private void taglistazas()
        {
            dataGridViewkonyv.Controls.Clear();

            var t = from x in context.Tags
                    where x.Nev.Contains(textBox1.Text)
                    select x;
            bindingSource1.DataSource = t.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taglistazas();
        }
        private void taghozzaadas()
        {
            Tag tag = new Tag();//textBoxnev.Text, Convert.ToDateTime(textBoxszuletes.Text), textBoxcim.Text, DateTime.Now); // ez a születési dátum, de a belépésihez kell

            tag.Nev = textBoxnev.Text;
            tag.Szuletesi_datum = Convert.ToDateTime(textBoxszuletes.Text);
            tag.Cim = textBoxcim.Text;
            tag.Belepesi_datum = Convert.ToDateTime(textBoxbelepes.Text);
            tag.Kilepesi_datum = Convert.ToDateTime(textBoxkilepes.Text);

            bindingSource1.Add(tag);

            context.SaveChanges();

            textBoxnev.Clear();
            textBoxszuletes.Clear();
            textBoxcim.Clear();
            textBoxbelepes.Clear();
            textBoxkilepes.Clear();

            dataGridViewkonyv.Refresh();
        }
        private void buttontorol_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewkonyv.SelectedRows)
            {
                dataGridViewkonyv.Rows.RemoveAt(item.Index);
            }
        }
        private void buttonveglegesit_Click(object sender, EventArgs e)
        {
            taghozzaadas();
        }

        private void dataGridViewkonyv_SelectionChanged(object sender, EventArgs e)
        {
            // törölgombot hozza fel, enable true-ra kell
            // ha kölcsönzött már könyvet akkor ne lehessen törölni
        }
        // kódból mégse vagy bezár gomb,felrakom a gombot, létrehozok egy eseményt, hiba, lemásolom
    }
}
