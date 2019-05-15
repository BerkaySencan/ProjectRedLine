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
    public partial class urunIslemKayit : DevExpress.XtraEditors.XtraUserControl
    {
        public urunIslemKayit()
        {
            InitializeComponent();
        }

        private static urunIslemKayit _instance;

        public static urunIslemKayit Instance
        {
            get
            {
                if (_instance == null) _instance = new urunIslemKayit();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnIslemlemAta_Click(object sender, EventArgs e)
        {

        }
    }
}
