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

        private void BtnVerilenCekSenet_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(verilenCekSenet.Instance))
            {
                container.Controls.Add(verilenCekSenet.Instance);
                verilenCekSenet.Instance.Dock = DockStyle.Fill;
                verilenCekSenet.Instance.BringToFront();
            }
            verilenCekSenet.Instance.BringToFront();
        }

        private void BtnAlınanCekSenet_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(alinanCeksSenet.Instance))
            {
                container.Controls.Add(alinanCeksSenet.Instance);
                alinanCeksSenet.Instance.Dock = DockStyle.Fill;
                alinanCeksSenet.Instance.BringToFront();
            }
            alinanCeksSenet.Instance.BringToFront();
        }

        private void BtnNakitOdeme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(nakitOdeme.Instance))
            {
                container.Controls.Add(nakitOdeme.Instance);
                nakitOdeme.Instance.Dock = DockStyle.Fill;
                nakitOdeme.Instance.BringToFront();
            }
            nakitOdeme.Instance.BringToFront();
        }

        private void BtnMusteriOdeme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(musteriOdeme.Instance))
            {
                container.Controls.Add(musteriOdeme.Instance);
                musteriOdeme.Instance.Dock = DockStyle.Fill;
                musteriOdeme.Instance.BringToFront();
            }
            musteriOdeme.Instance.BringToFront();
        }

        private void BtnMusteriSatılan_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(musteriSatılanlar.Instance))
            {
                container.Controls.Add(musteriSatılanlar.Instance);
                musteriSatılanlar.Instance.Dock = DockStyle.Fill;
                musteriSatılanlar.Instance.BringToFront();
            }
            musteriSatılanlar.Instance.BringToFront();
        }

        private void BtnTedarikciAlım_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(tedarikciAlımListesi.Instance))
            {
                container.Controls.Add(tedarikciAlımListesi.Instance);
                tedarikciAlımListesi.Instance.Dock = DockStyle.Fill;
                tedarikciAlımListesi.Instance.BringToFront();
            }
            tedarikciAlımListesi.Instance.BringToFront();
        }

        private void BtnTedarikciBorc_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(tedarikciBorcListesi.Instance))
            {
                container.Controls.Add(tedarikciBorcListesi.Instance);
                tedarikciBorcListesi.Instance.Dock = DockStyle.Fill;
                tedarikciBorcListesi.Instance.BringToFront();
            }
            tedarikciBorcListesi.Instance.BringToFront();
        }

        private void BtnHamMaddeOnay_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(hamMaddeOnay.Instance))
            {
                container.Controls.Add(hamMaddeOnay.Instance);
                hamMaddeOnay.Instance.Dock = DockStyle.Fill;
                hamMaddeOnay.Instance.BringToFront();
            }
            hamMaddeOnay.Instance.BringToFront();
        }

        private void BtnSiparisOnay_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(siparisRapor.Instance))
            {
                container.Controls.Add(siparisRapor.Instance);
                siparisRapor.Instance.Dock = DockStyle.Fill;
                siparisRapor.Instance.BringToFront();
            }
            siparisRapor.Instance.BringToFront();
        }

        private void BtnHamMaddeAlım_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(hamMaddeAlım.Instance))
            {
                container.Controls.Add(hamMaddeAlım.Instance);
                hamMaddeAlım.Instance.Dock = DockStyle.Fill;
                hamMaddeAlım.Instance.BringToFront();
            }
            hamMaddeAlım.Instance.BringToFront();
        }
    }
}
