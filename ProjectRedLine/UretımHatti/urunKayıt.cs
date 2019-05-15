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

namespace ProjectRedLine
{
    public partial class urunKayıt : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunKayıt _instance;
        public static urunKayıt Instance
        {
            get
            {
                if (_instance == null) _instance = new urunKayıt();
                return _instance;
            }
        }
        public urunKayıt()
        {
            InitializeComponent();
        }

        private void LabelControl2_Click(object sender, EventArgs e)
        {

        }

        private void LabelControl4_Click(object sender, EventArgs e)
        {

        }

        private void LabelControl5_Click(object sender, EventArgs e)
        {

        }

        private void LabelControl7_Click(object sender, EventArgs e)
        {

        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
