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
    public partial class satisYillik : DevExpress.XtraEditors.XtraUserControl
    {
        public satisYillik()
        {
            InitializeComponent();
        }
        private static satisYillik _instance;
        public static satisYillik Instance
        {
            get
            {
                if (_instance == null) _instance = new satisYillik();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
