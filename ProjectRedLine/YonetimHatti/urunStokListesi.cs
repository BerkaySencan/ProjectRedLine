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

namespace ProjectRedLine.YonetimHatti
{
    public partial class urunStokListesi : DevExpress.XtraEditors.XtraUserControl
    {
        public urunStokListesi()
        {
            InitializeComponent();
        }
        private static urunStokListesi _instance;

        public static urunStokListesi Instance
        {
            get
            {
                if (_instance == null) _instance = new urunStokListesi();
                return _instance;
            }
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
