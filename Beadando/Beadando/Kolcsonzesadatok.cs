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
    public partial class Kolcsonzesadatok : _Form
    {
        IRF_databaseEntitiesP context = new IRF_databaseEntitiesP();

        public Kolcsonzesadatok()
        {
            InitializeComponent();
            taglista();
            taglistazas();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
        }

        private void buttonkonyv_Click(object sender, EventArgs e)
        {
            Kolcsonzes k = new Kolcsonzes();
            k.Show();
            this.Close();
        }

        private void taglistazas()
        {
            Tag kolcsonzo = (Tag)listBoxtag.SelectedItem;

            var t = from x in context.Kolcsonzes
                    join y in context.Tags on x.Szemely_ID equals y.tag_Id
                    join z in context.Konyvs on x.Konyv_ID equals z.Konyv_Id
                    where y.Nev == kolcsonzo.Nev
                    select new 
                    {
                        Tag=y.Nev,
                        Könyv=z.Nev,
                        Dátum=x.Kivetel_datum
                    };

            bindingSource1.DataSource = t.ToList();

        }
        private void taglista()
        {
            var tag = from x in context.Tags
                    where x.Nev.Contains(textBox2.Text)
                    select x;
            listBoxtag.DisplayMember = "Nev";
            listBoxtag.DataSource = tag.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttontorol_Click(object sender, EventArgs e)
        {
        }

        private void listBoxtag_SelectedIndexChanged(object sender, EventArgs e)
        {
            taglistazas();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            taglista();
        }
    }
}
