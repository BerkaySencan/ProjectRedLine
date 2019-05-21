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
    public partial class urunKalipOlusturma : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunKalipOlusturma _instance;
        public static urunKalipOlusturma Instance
        {
            get
            {
                if (_instance == null) _instance = new urunKalipOlusturma();
                return _instance;
            }
        }
        public urunKalipOlusturma()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {

        }
    }
}
