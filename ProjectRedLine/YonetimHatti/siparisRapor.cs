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
    public partial class siparisRapor : DevExpress.XtraEditors.XtraUserControl
    {
        public siparisRapor()
        {
            InitializeComponent();
        }
        private static siparisRapor _instance;
        public static siparisRapor Instance
        {
            get
            {
                if (_instance == null) _instance = new siparisRapor();
                return _instance;
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SiparisRapor_Load(object sender, EventArgs e)
        {

        }
    }
}
