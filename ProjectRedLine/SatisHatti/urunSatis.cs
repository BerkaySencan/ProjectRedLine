using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectRedLine.SatisHatti
{
    public partial class urunSatis : DevExpress.XtraEditors.XtraUserControl
    {
        public urunSatis()
        {
            InitializeComponent();
        }
        private static urunSatis _instance;

        public static urunSatis Instance
        {
            get
            {
                if (_instance == null) _instance = new urunSatis();
                return _instance;
            }
        }
        private void UrunSatis_Load(object sender, EventArgs e)
        {

        }

        private void TextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
