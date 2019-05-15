using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectRedLine.YonetimHatti
{
    public partial class YonetimPanel : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public YonetimPanel()
        {
            InitializeComponent();
        }

        private void AccordionControlElement11_Click(object sender, EventArgs e)
        {

        }

        private void AccordionControlElement10_Click(object sender, EventArgs e)
        {

        }

        private void AccordionControlElement19_Click(object sender, EventArgs e)
        {

        }

        private void AccordionControlElement22_Click(object sender, EventArgs e)
        {

        }

        private void AccordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(urunListesi.Instance))
            {
                container.Controls.Add(urunListesi.Instance);
                urunListesi.Instance.Dock = DockStyle.Fill;
                urunListesi.Instance.BringToFront();
            }
            urunListesi.Instance.BringToFront();
        }

        private void BtnHamMaddeListele_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(hamMaddeListesi.Instance))
            {
                container.Controls.Add(hamMaddeListesi.Instance);
                hamMaddeListesi.Instance.Dock = DockStyle.Fill;
                hamMaddeListesi.Instance.BringToFront();
            }
            hamMaddeListesi.Instance.BringToFront();
        }

        private void BtnStokListele_Click(object sender, EventArgs e)
        {
            
            if (!container.Controls.Contains(urunStokListesi.Instance))
            {
                container.Controls.Add(urunStokListesi.Instance);
                urunStokListesi.Instance.Dock = DockStyle.Fill;
                urunStokListesi.Instance.BringToFront();
            }
            urunStokListesi.Instance.BringToFront();

        }

        private void BtnTukenmisUrunListele_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(tukenmisUrunListesi.Instance))
            {
                container.Controls.Add(tukenmisUrunListesi.Instance);
                tukenmisUrunListesi.Instance.Dock = DockStyle.Fill;
                tukenmisUrunListesi.Instance.BringToFront();
            }
            tukenmisUrunListesi.Instance.BringToFront();
        }

        private void BtnDetayliUretim_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(detayliUretim.Instance))
            {
                container.Controls.Add(detayliUretim.Instance);
                detayliUretim.Instance.Dock = DockStyle.Fill;
                detayliUretim.Instance.BringToFront();
            }
            detayliUretim.Instance.BringToFront();
        }

        private void BtnYıllıkSatıs_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(satisYillik.Instance))
            {
                container.Controls.Add(satisYillik.Instance);
                satisYillik.Instance.Dock = DockStyle.Fill;
                satisYillik.Instance.BringToFront();
            }
            satisYillik.Instance.BringToFront();
        }

        private void BtnAylıkSatıs_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(satisAylik.Instance))
            {
                container.Controls.Add(satisAylik.Instance);
                satisAylik.Instance.Dock = DockStyle.Fill;
                satisAylik.Instance.BringToFront();
            }
            satisAylik.Instance.BringToFront();
        }

        private void BtnGunlukSatıs_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(satisGunluk.Instance))
            {
                container.Controls.Add(satisGunluk.Instance);
                satisGunluk.Instance.Dock = DockStyle.Fill;
                satisGunluk.Instance.BringToFront();
            }
            satisGunluk.Instance.BringToFront();
        }
    }
}
