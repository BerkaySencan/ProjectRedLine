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
    public partial class musteriOdeme : DevExpress.XtraEditors.XtraUserControl
    {
        public musteriOdeme()
        {
            InitializeComponent();
        }
        private static musteriOdeme _instance;
        public static musteriOdeme Instance
        {
            get
            {
                if (_instance == null) _instance = new musteriOdeme();
                return _instance;
            }
        }
        private void MusteriOdeme_Load(object sender, EventArgs e)
        {

        }
    }
}
