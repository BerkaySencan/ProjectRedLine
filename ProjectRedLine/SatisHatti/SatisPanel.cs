using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectRedLine.SatisHatti
{
    public partial class SatisPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public SatisPanel()
        {
            InitializeComponent();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunSatis.Instance))
            {
                container.Controls.Add(urunSatis.Instance);
                urunSatis.Instance.Dock = DockStyle.Fill;
                urunSatis.Instance.BringToFront();
            }
            urunSatis.Instance.BringToFront();
        }

        private void AccordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(faturaGetir.Instance))
            {
                container.Controls.Add(faturaGetir.Instance);
                faturaGetir.Instance.Dock = DockStyle.Fill;
                faturaGetir.Instance.BringToFront();
            }
            faturaGetir.Instance.BringToFront();

        }
    }
}
