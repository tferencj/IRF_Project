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
                //_belepes = _grid.CurrentRow.Cells["Kilepesi_datum"].Value.ToString();
                if (_belepes != null)
                {
                    //próbálkozás
                }
                else
                {

                }
            }
        }
    }

}
