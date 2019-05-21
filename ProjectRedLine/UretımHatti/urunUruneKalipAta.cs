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
    public partial class urunUruneKalipAta : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunUruneKalipAta _instance;
        public static urunUruneKalipAta Instance
        {
            get
            {
                if (_instance == null) _instance = new urunUruneKalipAta();
                return _instance;
            }
        }
        public urunUruneKalipAta()
        {
            InitializeComponent();
        }

        private void BtnMaliyetGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
