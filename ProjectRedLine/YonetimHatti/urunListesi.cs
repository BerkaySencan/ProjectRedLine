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
    public partial class urunListesi : DevExpress.XtraEditors.XtraUserControl
    {

        public urunListesi()
        {
            InitializeComponent();
        }

        private static urunListesi _instance;
        public static urunListesi Instance
        {
            get
            {
                if (_instance == null) _instance = new urunListesi();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
