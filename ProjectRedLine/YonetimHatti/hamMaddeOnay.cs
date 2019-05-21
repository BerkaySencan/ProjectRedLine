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
    public partial class hamMaddeOnay : DevExpress.XtraEditors.XtraUserControl
    {
        public hamMaddeOnay()
        {
            InitializeComponent();
        }
        private static hamMaddeOnay _instance;
        public static hamMaddeOnay Instance
        {
            get
            {
                if (_instance == null) _instance = new hamMaddeOnay();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
