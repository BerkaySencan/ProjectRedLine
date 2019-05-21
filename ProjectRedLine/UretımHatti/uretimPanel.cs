using DevExpress.XtraBars;
using ProjectRedLine.UretımHatti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectRedLine
{
    public partial class uretimPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public uretimPanel()
        {
            InitializeComponent();
        }

        private void BtnUrunKayıt_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunKayıt.Instance))
            {
                container.Controls.Add(urunKayıt.Instance);
                urunKayıt.Instance.Dock = DockStyle.Fill;
                urunKayıt.Instance.BringToFront();
            }
            urunKayıt.Instance.BringToFront();
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunGuncelle.Instance))
            {
                container.Controls.Add(urunGuncelle.Instance);
                urunGuncelle.Instance.Dock = DockStyle.Fill;
                urunGuncelle.Instance.BringToFront();
            }
            urunGuncelle.Instance.BringToFront();
        }

        private void BtnUrunSılme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunSil.Instance))
            {
                container.Controls.Add(urunSil.Instance);
                urunSil.Instance.Dock = DockStyle.Fill;
                urunSil.Instance.BringToFront();
            }
            urunSil.Instance.BringToFront();
        }

        private void BtnMaliyetHesap_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunMaliyetHesaplama.Instance))
            {
                container.Controls.Add(urunMaliyetHesaplama.Instance);
                urunMaliyetHesaplama.Instance.Dock = DockStyle.Fill;
                urunMaliyetHesaplama.Instance.BringToFront();
            }
            urunMaliyetHesaplama.Instance.BringToFront();

        }

        private void BtnUrunIslemKayıt_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunIslemKayit.Instance))
            {
                container.Controls.Add(urunIslemKayit.Instance);
                urunIslemKayit.Instance.Dock = DockStyle.Fill;
                urunIslemKayit.Instance.BringToFront();
            }
            urunIslemKayit.Instance.BringToFront();
        }

        private void UretimPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
