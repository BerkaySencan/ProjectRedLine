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
    public partial class satisAylik : DevExpress.XtraEditors.XtraUserControl
    {
        public satisAylik()
        {
            InitializeComponent();
        }
        private static satisAylik _instance;
        public static satisAylik Instance
        {
            get
            {
                if (_instance == null) _instance = new satisAylik();
                return _instance;
            }
        }
        private void SatisAylik_Load(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
