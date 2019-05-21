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
    public partial class tukenmisUrunListesi : DevExpress.XtraEditors.XtraUserControl
    {
        public tukenmisUrunListesi()
        {
            InitializeComponent();
        }

        private static tukenmisUrunListesi _instance;
        public static tukenmisUrunListesi Instance
        {
            get
            {
                if (_instance == null) _instance = new tukenmisUrunListesi();
                return _instance;
            }
        }

        private void TukenmisUrunListesi_Load(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
