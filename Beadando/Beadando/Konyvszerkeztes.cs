using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Konyvszerkeztes : Form
    {
        IRF_databaseEntities context = new IRF_databaseEntities();

        public Konyvszerkeztes()
        {
            InitializeComponent();
            konyvlistazas();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Konyvadatok k = new Konyvadatok();
            k.Show();
            this.Close();
        }
        private void konyvlistazas()
        {
            var k = from x in context.Konyvs
                    where x.Nev.Contains(textBox1.Text)
                    select x;
            bindingSource1.DataSource = k.ToList();
        }
        private void konyvhozzaadas()
        {
            Konyv konyv = new Konyv();
            konyv.Nev = textBoxnev.Text;
            konyv.Szerzo = textBoxszerzo.Text;
            konyv.Kiadas_datum = Convert.ToInt32(textBoxdatum.Text);
            konyv.Kiado = textBoxkiado.Text;
            konyv.Nyelv = textBoxnyelv.Text;
            konyv.Oldalszam = Convert.ToInt32(textBoxoldalszam.Text);

            bindingSource1.Add(konyv);

            context.SaveChanges();

            textBoxnev.Clear();
            textBoxszerzo.Clear();
            textBoxdatum.Clear();
            textBoxkiado.Clear();
            textBoxnyelv.Clear();
            textBoxoldalszam.Clear();

            dataGridViewkonyv.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            konyvlistazas();
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
            konyvhozzaadas();
        }
    }
}
