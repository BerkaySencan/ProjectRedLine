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
    public partial class musteriSatılanlar : DevExpress.XtraEditors.XtraUserControl
    {
        public musteriSatılanlar()
        {
            InitializeComponent();
        }
        private static musteriSatılanlar _instance;
        public static musteriSatılanlar Instance
        {
            get
            {
                if (_instance == null) _instance = new musteriSatılanlar();
                return _instance;
            }
        }
        private void MusteriSatılanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
