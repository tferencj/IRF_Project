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
        IRF_databaseEntitiesuj context = new IRF_databaseEntitiesuj();
        public tagkilep()
        {
            InitializeComponent();
            taglistazas();
            string torlendo = "Jan 1, 2009";
            torlendo = dataGridViewkonyv.CurrentRow.Cells["Kilepesi_datum"].Value.ToString();
            var torol = DateTime.Parse(torlendo);
        }
        private DateTime _kilepes;
        public DateTime kilepes
        {
            get { return _kilepes; }
            set
            {
                _kilepes = kilepes;
                if (/*_kilepes<torol*/)
                {

                }
            }
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

        }
    }
}
