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
    public partial class urunMaliyetHesaplama : DevExpress.XtraEditors.XtraUserControl
    {
        public urunMaliyetHesaplama()
        {
            InitializeComponent();
        }

        private static urunMaliyetHesaplama _instance;

        public static urunMaliyetHesaplama Instance
        {
            get
            {
                if (_instance == null) _instance = new urunMaliyetHesaplama();
                return _instance;
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
