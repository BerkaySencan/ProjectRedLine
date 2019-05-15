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
    public partial class nakitOdeme : DevExpress.XtraEditors.XtraUserControl
    {
        public nakitOdeme()
        {
            InitializeComponent();
        }
        private static nakitOdeme _instance;
        public static nakitOdeme Instance
        {
            get
            {
                if (_instance == null) _instance = new nakitOdeme();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
