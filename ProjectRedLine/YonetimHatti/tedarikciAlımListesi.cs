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
    public partial class tedarikciAlımListesi : DevExpress.XtraEditors.XtraUserControl
    {
        public tedarikciAlımListesi()
        {
            InitializeComponent();
        }
        private static tedarikciAlımListesi _instance;
        public static tedarikciAlımListesi Instance
        {
            get
            {
                if (_instance == null) _instance = new tedarikciAlımListesi();
                return _instance;
            }
        }
        private void TedarikciAlımListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
