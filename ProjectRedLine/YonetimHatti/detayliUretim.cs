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
    public partial class detayliUretim : DevExpress.XtraEditors.XtraUserControl
    {
        public detayliUretim()
        {
            InitializeComponent();
        }
        private static detayliUretim _instance;
        public static detayliUretim Instance
        {
            get
            {
                if (_instance == null) _instance = new detayliUretim();
                return _instance;
            }
        }
        private void DetayliUretim_Load(object sender, EventArgs e)
        {

        }
    }
}
