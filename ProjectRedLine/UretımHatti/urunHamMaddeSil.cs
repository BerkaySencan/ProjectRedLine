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
    public partial class urunHamMaddeSil : DevExpress.XtraEditors.XtraUserControl
    {
        private static urunHamMaddeSil _instance;
        public static urunHamMaddeSil Instance
        {
            get
            {
                if (_instance == null) _instance = new urunHamMaddeSil();
                return _instance;
            }
        }
        public urunHamMaddeSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
