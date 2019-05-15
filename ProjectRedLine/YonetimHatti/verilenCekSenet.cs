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
    public partial class verilenCekSenet : DevExpress.XtraEditors.XtraUserControl
    {
        public verilenCekSenet()
        {
            InitializeComponent();
        }
        private static verilenCekSenet _instance;
        public static verilenCekSenet Instance
        {
            get
            {
                if (_instance == null) _instance = new verilenCekSenet();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
