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
    public partial class hamMaddeListesi : DevExpress.XtraEditors.XtraUserControl
    {
        public hamMaddeListesi()
        {
            InitializeComponent();
        }
        private static hamMaddeListesi _instance;
        
        public static hamMaddeListesi Instance
        {
            get
            {
                if  (_instance == null) _instance = new hamMaddeListesi();
                return _instance;
            }
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
