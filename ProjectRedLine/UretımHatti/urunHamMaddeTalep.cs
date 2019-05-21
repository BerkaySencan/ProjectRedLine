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

namespace ProjectRedLine.UretımHatti
{
    public partial class urunHamMaddeTalep : DevExpress.XtraEditors.XtraUserControl
    {
    
        public urunHamMaddeTalep()
        {
            InitializeComponent();
        }
      
        private static urunHamMaddeTalep _instance;
        public static urunHamMaddeTalep Instance
        {
            get
            {
                if (_instance == null) _instance = new urunHamMaddeTalep();
                return _instance;
            }
        }
        private void BtnSepeteEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
