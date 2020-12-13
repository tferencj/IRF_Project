using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    class datumgomb:Button
    {
        public DataGridView _grid { get; set; }
        private string _belepes;
        public string belepes
        {
            get { return _belepes; }
            set
            {
                _belepes = belepes;
                if (_grid.CurrentRow.Cells["Belepesi_datum"].Value != null)
                {
                    _belepes = _grid.CurrentRow.Cells["Belepesi_datum"].Value.ToString();
                }
                else
                {
                    _belepes = "nincs beléptetve";
                }
            }
        }
    }

}
