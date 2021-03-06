﻿using System;
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
    public partial class Konyvszerkeztes : _Form
    {
        IRF_databaseEntitiesP context = new IRF_databaseEntitiesP();

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
            if (textBoxnev.Text == "")
            {
                MessageBox.Show("A név mező nem lehet üres");
            }
            else
            {
                konyv.Nev = textBoxnev.Text;
            }
            if (textBoxdatum.Text == "")
            {
                MessageBox.Show("A kiadás dátuma mező nem lehet üres");
            }
            else
            {
                konyv.Kiadas_datum = Convert.ToInt32(textBoxdatum.Text);
            }
            if (textBoxszerzo.Text == "")
            {
                MessageBox.Show("A szerző mező nem lehet üres");
            }
            else
            {
                konyv.Szerzo = textBoxszerzo.Text;
            }
            if (textBoxkiado.Text == "")
            {
                MessageBox.Show("A kiadó mező nem lehet üres");
            }
            else
            {
                konyv.Kiado = textBoxkiado.Text;
            }
            if (textBoxnyelv.Text == "")
            {
                MessageBox.Show("A nyelv mező nem lehet üres");
            }
            else
            {
                konyv.Nyelv = textBoxnyelv.Text;
            }
            if (textBoxoldalszam.Text == "")
            {
                MessageBox.Show("Az oldalszám mező nem lehet üres");
            }
            else
            {
                konyv.Oldalszam = Convert.ToInt32(textBoxoldalszam.Text);
            }

            bindingSource1.EndEdit();

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

        private void dataGridViewkonyv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // véletlen
        }

        private void dataGridViewkonyv_SelectionChanged(object sender, EventArgs e)
        {
            // hülyeség
        }
    }
}
