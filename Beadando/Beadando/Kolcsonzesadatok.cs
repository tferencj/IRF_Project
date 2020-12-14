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
            konyvlistazas();
            taglistazas();
        }

        private void buttonmegse_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void buttonkonyv_Click(object sender, EventArgs e)
        {
            Kolcsonzes k = new Kolcsonzes();
            k.Show();
            this.Close();
        }
        private void konyvlistazas()
        {
            Konyv kolcsonzott = (Konyv)listBoxkonyv.SelectedItem;

            var t = from x in context.Kolcsonzes
                    where x.Konyv_ID == kolcsonzott.Konyv_Id
                    select new
                    {
                        kolcsonzott.Nev,
                        kolcsonzott.Szerzo
                    };

            bindingSource1.DataSource = t.ToList(); // valamiért nem jó
        }

        private void taglistazas()
        {
            Tag kolcsonzo = (Tag)listBoxtag.SelectedItem;

            var t = from x in context.Kolcsonzes
                    where x.Szemely_ID==kolcsonzo.tag_Id                   
                    select new
                    {
                        kolcsonzo.Nev
                    };

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            konyvlistazas();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            taglistazas();
        }

        private void buttontorol_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewkonyv.SelectedRows)
            {
                dataGridViewkonyv.Rows.RemoveAt(item.Index);
            }
        }
    }
}
