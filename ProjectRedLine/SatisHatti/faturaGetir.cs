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

namespace ProjectRedLine.SatisHatti
{
    public partial class faturaGetir : DevExpress.XtraEditors.XtraUserControl
    {
        public faturaGetir()
        {
            InitializeComponent();
        }
        public static faturaGetir Instance
        {
            get
            {
                if (_instance == null) _instance = new faturaGetir();
                return _instance;
            }
        }
        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
