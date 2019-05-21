namespace ProjectRedLine.YonetimHatti
{
    partial class YonetimPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimPanel));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUrunListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStokListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnTukenmisUrunListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDetayliUretim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnYıllıkSatıs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAylıkSatıs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnGunlukSatıs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement15 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnVerilenCekSenet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAlınanCekSenet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNakitOdeme = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement19 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMusteriOdeme = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMusteriSatılan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement22 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTedarikciAlım = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTedarikciBorc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeOnay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSiparisOnay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeAlım = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 27);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(825, 653);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement10,
            this.accordionControlElement15,
            this.accordionControlElement19,
            this.accordionControlElement22,
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 653);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHamMaddeListele,
            this.btnUrunListele,
            this.btnStokListele,
            this.BtnTukenmisUrunListele,
            this.btnDetayliUretim});
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Üretim Raporları";
            this.accordionControlElement3.Click += new System.EventHandler(this.AccordionControlElement3_Click);
            // 
            // btnHamMaddeListele
            // 
            this.btnHamMaddeListele.Name = "btnHamMaddeListele";
            this.btnHamMaddeListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeListele.Text = "Ham Madde Listesi";
            this.btnHamMaddeListele.Click += new System.EventHandler(this.BtnHamMaddeListele_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUrunListele.Text = "Ürün Listesi";
            this.btnUrunListele.Click += new System.EventHandler(this.BtnUrunListele_Click);
            // 
            // btnStokListele
            // 
            this.btnStokListele.Name = "btnStokListele";
            this.btnStokListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStokListele.Text = "Ürün Stok Listesi";
            this.btnStokListele.Click += new System.EventHandler(this.BtnStokListele_Click);
            // 
            // BtnTukenmisUrunListele
            // 
            this.BtnTukenmisUrunListele.Name = "BtnTukenmisUrunListele";
            this.BtnTukenmisUrunListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnTukenmisUrunListele.Text = "Tükenmiş Ürün Listesi";
            this.BtnTukenmisUrunListele.Click += new System.EventHandler(this.BtnTukenmisUrunListele_Click);
            // 
            // btnDetayliUretim
            // 
            this.btnDetayliUretim.Name = "btnDetayliUretim";
            this.btnDetayliUretim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDetayliUretim.Text = "Detaylı Üretim Rapoları";
            this.btnDetayliUretim.Click += new System.EventHandler(this.BtnDetayliUretim_Click);
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnYıllıkSatıs,
            this.btnAylıkSatıs,
            this.btnGunlukSatıs});
            this.accordionControlElement10.Expanded = true;
            this.accordionControlElement10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement10.ImageOptions.Image")));
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Text = "Satış Raporları";
            this.accordionControlElement10.Click += new System.EventHandler(this.AccordionControlElement10_Click);
            // 
            // btnYıllıkSatıs
            // 
            this.btnYıllıkSatıs.Name = "btnYıllıkSatıs";
            this.btnYıllıkSatıs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnYıllıkSatıs.Text = "Yıllık Satış Raporu";
            this.btnYıllıkSatıs.Click += new System.EventHandler(this.BtnYıllıkSatıs_Click);
            // 
            // btnAylıkSatıs
            // 
            this.btnAylıkSatıs.Name = "btnAylıkSatıs";
            this.btnAylıkSatıs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAylıkSatıs.Text = "Aylık Satış Raporu";
            this.btnAylıkSatıs.Click += new System.EventHandler(this.BtnAylıkSatıs_Click);
            // 
            // btnGunlukSatıs
            // 
            this.btnGunlukSatıs.Name = "btnGunlukSatıs";
            this.btnGunlukSatıs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnGunlukSatıs.Text = "Günlük Satış Raporu";
            this.btnGunlukSatıs.Click += new System.EventHandler(this.BtnGunlukSatıs_Click);
            // 
            // accordionControlElement15
            // 
            this.accordionControlElement15.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnVerilenCekSenet,
            this.btnAlınanCekSenet,
            this.btnNakitOdeme});
            this.accordionControlElement15.Expanded = true;
            this.accordionControlElement15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement15.ImageOptions.Image")));
            this.accordionControlElement15.Name = "accordionControlElement15";
            this.accordionControlElement15.Text = "Ödeme Raporları";
            // 
            // btnVerilenCekSenet
            // 
            this.btnVerilenCekSenet.Name = "btnVerilenCekSenet";
            this.btnVerilenCekSenet.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnVerilenCekSenet.Text = "Verilen Çek-Senet Listesi";
            this.btnVerilenCekSenet.Click += new System.EventHandler(this.BtnVerilenCekSenet_Click);
            // 
            // btnAlınanCekSenet
            // 
            this.btnAlınanCekSenet.Name = "btnAlınanCekSenet";
            this.btnAlınanCekSenet.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAlınanCekSenet.Text = "Alınan Çek-Senet Listesi";
            this.btnAlınanCekSenet.Click += new System.EventHandler(this.BtnAlınanCekSenet_Click);
            // 
            // btnNakitOdeme
            // 
            this.btnNakitOdeme.Name = "btnNakitOdeme";
            this.btnNakitOdeme.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNakitOdeme.Text = "Nakit Ödeme Listesi";
            this.btnNakitOdeme.Click += new System.EventHandler(this.BtnNakitOdeme_Click);
            // 
            // accordionControlElement19
            // 
            this.accordionControlElement19.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnMusteriOdeme,
            this.btnMusteriSatılan});
            this.accordionControlElement19.Expanded = true;
            this.accordionControlElement19.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement19.ImageOptions.Image")));
            this.accordionControlElement19.Name = "accordionControlElement19";
            this.accordionControlElement19.Text = "Müşteri Raporları";
            this.accordionControlElement19.Click += new System.EventHandler(this.AccordionControlElement19_Click);
            // 
            // btnMusteriOdeme
            // 
            this.btnMusteriOdeme.Name = "btnMusteriOdeme";
            this.btnMusteriOdeme.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMusteriOdeme.Text = "Müşteri Ödeme Listesi";
            this.btnMusteriOdeme.Click += new System.EventHandler(this.BtnMusteriOdeme_Click);
            // 
            // btnMusteriSatılan
            // 
            this.btnMusteriSatılan.Name = "btnMusteriSatılan";
            this.btnMusteriSatılan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMusteriSatılan.Text = "Müşteri Satılanlar Listesi";
            this.btnMusteriSatılan.Click += new System.EventHandler(this.BtnMusteriSatılan_Click);
            // 
            // accordionControlElement22
            // 
            this.accordionControlElement22.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnTedarikciAlım,
            this.btnTedarikciBorc});
            this.accordionControlElement22.Expanded = true;
            this.accordionControlElement22.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement22.ImageOptions.Image")));
            this.accordionControlElement22.Name = "accordionControlElement22";
            this.accordionControlElement22.Text = "Tedarikçi İşlemleri";
            this.accordionControlElement22.Click += new System.EventHandler(this.AccordionControlElement22_Click);
            // 
            // btnTedarikciAlım
            // 
            this.btnTedarikciAlım.Name = "btnTedarikciAlım";
            this.btnTedarikciAlım.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTedarikciAlım.Text = "Tedarikçi Alım Raporu";
            this.btnTedarikciAlım.Click += new System.EventHandler(this.BtnTedarikciAlım_Click);
            // 
            // btnTedarikciBorc
            // 
            this.btnTedarikciBorc.Name = "btnTedarikciBorc";
            this.btnTedarikciBorc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTedarikciBorc.Text = "Tedarikçi Borç Raporu";
            this.btnTedarikciBorc.Click += new System.EventHandler(this.BtnTedarikciBorc_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHamMaddeOnay,
            this.btnSiparisOnay,
            this.btnHamMaddeAlım});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Onay Ve Sipariş İşlemleri";
            // 
            // btnHamMaddeOnay
            // 
            this.btnHamMaddeOnay.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnHamMaddeOnay.Name = "btnHamMaddeOnay";
            this.btnHamMaddeOnay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeOnay.Text = "Üretim Ham Madde Onay";
            this.btnHamMaddeOnay.Click += new System.EventHandler(this.BtnHamMaddeOnay_Click);
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSiparisOnay.Text = "Sipariş Rapor";
            this.btnSiparisOnay.Click += new System.EventHandler(this.BtnSiparisOnay_Click);
            // 
            // btnHamMaddeAlım
            // 
            this.btnHamMaddeAlım.Name = "btnHamMaddeAlım";
            this.btnHamMaddeAlım.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeAlım.Text = "Ham Madde Alım";
            this.btnHamMaddeAlım.Click += new System.EventHandler(this.BtnHamMaddeAlım_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1085, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // YonetimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 680);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "YonetimPanel";
            this.NavigationControl = this.accordionControl1;
            this.Text = "YonetimPanel";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeOnay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSiparisOnay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUrunListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStokListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnTukenmisUrunListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDetayliUretim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnYıllıkSatıs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAylıkSatıs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnGunlukSatıs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement15;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnVerilenCekSenet;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAlınanCekSenet;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNakitOdeme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement19;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteriOdeme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMusteriSatılan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement22;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTedarikciAlım;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTedarikciBorc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeAlım;
    }
}