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

namespace ProjectRedLine.UretımHatti
{
    public partial class urunHamMaddeKayit : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunHamMaddeKayit _instance;
        public static urunHamMaddeKayit Instance
        {
            get
            {
                if (_instance == null) _instance = new urunHamMaddeKayit();
                return _instance;
            }
        }
        public urunHamMaddeKayit()
        {
            InitializeComponent();
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
