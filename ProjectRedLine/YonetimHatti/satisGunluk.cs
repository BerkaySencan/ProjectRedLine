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
    public partial class satisGunluk : DevExpress.XtraEditors.XtraUserControl
    {
        public satisGunluk()
        {
            InitializeComponent();
        }
        private static satisGunluk _instance;
        public static satisGunluk Instance
        {
            get
            {
                if (_instance == null) _instance = new satisGunluk();
                return _instance;
            }
        }

        private void SatisGunluk_Load(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
