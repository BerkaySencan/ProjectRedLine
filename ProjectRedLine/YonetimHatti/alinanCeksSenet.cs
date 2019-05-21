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
    public partial class alinanCeksSenet : DevExpress.XtraEditors.XtraUserControl
    {
        public alinanCeksSenet()
        {
            InitializeComponent();
        }
        private static alinanCeksSenet _instance;
        public static alinanCeksSenet Instance
        {
            get
            {
                if (_instance == null) _instance = new alinanCeksSenet();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
