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
    public partial class Kolcsonzesadatok : Form
    {
        IRF_databaseEntities context = new IRF_databaseEntities();

        public Kolcsonzesadatok()
        {
            InitializeComponent();
            listazas();
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
        private void listazas()
        {

            //var t = from x in context.Kolcsonzes
              //      where x.Konyv_ID==
                //    select x;
            //bindingSource1.DataSource = t.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listazas();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listazas();
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
