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
    public partial class Kolcsonzes : _Form
    {
        IRF_databaseEntitiesP context= new IRF_databaseEntitiesP();
        public Kolcsonzes()
        {
            InitializeComponent();
            taglistazas();
            konyvlistazas();
            tablazat();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Kolcsonzesadatok k = new Kolcsonzesadatok();
            k.Show();
            this.Close();
        }
        private void hozzaad()
        {
            Kolcsonze k = new Kolcsonze();
            k.Konyv_ID = ((Konyv)listBoxkonyv.SelectedItem).Konyv_Id;
            k.Szemely_ID = ((Tag)listBoxtag.SelectedItem).tag_Id;
            k.Kivetel_datum = DateTime.Today;

            bindingSource1.Add(k);
            context.SaveChanges();
        }
        private void vissza()
        {
            dynamic v = bindingSource1.Current;
            DateTime vissza = DateTime.Today;
            vissza = v.Visszahozas_Datum;

            bindingSource1.Add(v);
            context.SaveChanges();
        }

        private void buttonhozzaad_Click(object sender, EventArgs e)
        {
            hozzaad();
        }
        private void konyvlistazas()
        {
            var konyv = from x in context.Konyvs
                        where x.Nev.Contains(textBoxkonyv.Text)
                        select x;
            listBoxkonyv.DataSource = konyv.ToList();
            listBoxkonyv.DisplayMember = "Nev";
        }
        private void taglistazas()
        {
            var tag = from x in context.Tags
                      where x.Nev.Contains(textBoxtag.Text)
                      select x;

            listBoxtag.DisplayMember = "Nev";
            listBoxtag.DataSource = tag.ToList();
        }

        private void tablazat()
        {
            var tg = from x in context.Konyvs
                      join y in context.Kolcsonzes on x.Konyv_Id equals y.Konyv_ID
                      join z in context.Tags on y.Szemely_ID equals z.tag_Id
                      where x.Nev.Contains(textBoxkonyv.Text)
                      select new
                      {
                          Könyv = x.Nev,
                          Tag = z.Nev,
                          Kivitel = y.Kivetel_datum
                      };

            bindingSource1.DataSource = tg.ToList();
                      
        }

        private void textBoxkonyv_TextChanged(object sender, EventArgs e)
        {
            konyvlistazas();
        }

        private void textBoxtag_TextChanged(object sender, EventArgs e)
        {
            taglistazas();
        }

        private void listBoxkonyv_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablazat();
        }

        private void buttonvissza_Click(object sender, EventArgs e)
        {

        }
    }
}
