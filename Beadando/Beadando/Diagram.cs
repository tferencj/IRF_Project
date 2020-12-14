using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class Diagram : _Form
    {
        IRF_databaseEntitiesP context = new IRF_databaseEntitiesP();

        public Diagram()
        {
            InitializeComponent();
            var c = (from x in context.Konyvs
                     group x by x.Nyelv into n
                     select new { Nyelv = n.Key, db = n.Count() }).Distinct();
            bindingSource1.DataSource = c.ToList();
            chart1.DataBind();
        }

        private void buttonoldal_Click(object sender, EventArgs e)
        {

        }

        private void buttonkiadas_Click(object sender, EventArgs e)
        {

        }
    }
}
