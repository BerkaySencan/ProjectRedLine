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

        private void BtnHamMaddeGuncelle_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunHamMaddeGuncelleme.Instance))
            {
                container.Controls.Add(urunHamMaddeGuncelleme.Instance);
                urunHamMaddeGuncelleme.Instance.Dock = DockStyle.Fill;
                urunHamMaddeGuncelleme.Instance.BringToFront();
            }
            urunHamMaddeGuncelleme.Instance.BringToFront();
        }

        private void BtnHamMaddeOlustur_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunHamMaddeKayit.Instance))
            {
                container.Controls.Add(urunHamMaddeKayit.Instance);
                urunHamMaddeKayit.Instance.Dock = DockStyle.Fill;
                urunHamMaddeKayit.Instance.BringToFront();
            }
            urunHamMaddeKayit.Instance.BringToFront();
        }

        private void BtnHamMaddeSil_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunHamMaddeSil.Instance))
            {
                container.Controls.Add(urunHamMaddeSil.Instance);
                urunHamMaddeSil.Instance.Dock = DockStyle.Fill;
                urunHamMaddeSil.Instance.BringToFront();
            }
            urunHamMaddeSil.Instance.BringToFront();
        }

        private void BtnKalıpOlustur_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunKalipOlusturma.Instance))
            {
                container.Controls.Add(urunKalipOlusturma.Instance);
                urunKalipOlusturma.Instance.Dock = DockStyle.Fill;
                urunKalipOlusturma.Instance.BringToFront();
            }
            urunKalipOlusturma.Instance.BringToFront();
        }

        private void BtnUruneKalıpAta_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunUruneKalipAta.Instance))
            {
                container.Controls.Add(urunUruneKalipAta.Instance);
                urunUruneKalipAta.Instance.Dock = DockStyle.Fill;
                urunUruneKalipAta.Instance.BringToFront();
            }
            urunUruneKalipAta.Instance.BringToFront();
        }

      

        private void BtnUrunHamMaddeTalep_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunHamMaddeTalep.Instance))
            {
                container.Controls.Add(urunHamMaddeTalep.Instance);
                urunHamMaddeTalep.Instance.Dock = DockStyle.Fill;
                urunHamMaddeTalep.Instance.BringToFront();
            }
            urunHamMaddeTalep.Instance.BringToFront();
        }
    }
}
