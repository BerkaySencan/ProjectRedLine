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
    public partial class urunHamMaddeGuncelleme : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunHamMaddeGuncelleme _instance;
        public static urunHamMaddeGuncelleme Instance
        {
            get
            {
                if (_instance == null) _instance = new urunHamMaddeGuncelleme();
                return _instance;
            }
        }
        public urunHamMaddeGuncelleme()
        {
            InitializeComponent();
        }

        private void BtnResimSec_Click(object sender, EventArgs e)
        {

        }
    }
}
