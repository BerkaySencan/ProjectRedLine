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
    public partial class urunGuncelle : DevExpress.XtraEditors.XtraUserControl
    {
        public urunGuncelle()
        {
            InitializeComponent();
        }
        private static urunGuncelle _instance;
        public static urunGuncelle Instance
        {
            get
            {
                if (_instance == null) _instance = new urunGuncelle();
                return _instance;
            }
        }
        private void UrunGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
