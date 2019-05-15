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
    public partial class urunSil : DevExpress.XtraEditors.XtraUserControl
    {
        public urunSil()
        {
            InitializeComponent();
        }
        private static urunSil _instance;
        public static urunSil Instance
        {
            get
            {
                if (_instance == null) _instance = new urunSil();
                return _instance;
            }
        }
        private void UrunSil_Load(object sender, EventArgs e)
        {

        }
    }
}
