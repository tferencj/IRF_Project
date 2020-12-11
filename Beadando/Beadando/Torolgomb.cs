using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Torolgomb : Button
    {
        public Torolgomb()
        {
            // GRID-et be kell állítani a gombnál
            this.Text = "Töröl";
            this.Enabled = false;
            InitializeComponent();
            this.Click += new System.EventHandler(this.buttontorol_Click);
        }
        public DataGridView _grid { get; set; }

        private void buttontorol_Click(object sender, EventArgs e)
        {
            if (_grid != null)
            {
                foreach (DataGridViewRow item in this._grid.SelectedRows)
                {
                    _grid.Rows.RemoveAt(item.Index);
                }
            }
        }
    }
}
