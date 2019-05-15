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
    public partial class hamMaddeAlım : DevExpress.XtraEditors.XtraUserControl
    {
        public hamMaddeAlım()
        {
            InitializeComponent();
        }
        private static hamMaddeAlım _instance;
        public static hamMaddeAlım Instance
        {
            get
            {
                if (_instance == null) _instance = new hamMaddeAlım();
                return _instance;
            }
        }

        private void LabelControl1_Click(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
