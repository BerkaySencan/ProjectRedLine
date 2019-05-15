namespace ProjectRedLine
{
    partial class uretimPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uretimPanel));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMaliyetHesap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUrunKayıt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUrunGuncelle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUrunSılme = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUrunIslemKayıt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeOlustur = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeGuncelle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnHamMaddeSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnKalıpOlustur = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUruneKalıpAta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(180, 27);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(891, 559);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement6,
            this.accordionControlElement9,
            this.accordionControlElement12});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(180, 559);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnMaliyetHesap,
            this.btnUrunKayıt,
            this.btnUrunGuncelle,
            this.btnUrunSılme});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Ürün İşlemleri";
            // 
            // btnMaliyetHesap
            // 
            this.btnMaliyetHesap.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnMaliyetHesap.Name = "btnMaliyetHesap";
            this.btnMaliyetHesap.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMaliyetHesap.Text = "Maliyet Hesaplama";
            this.btnMaliyetHesap.Click += new System.EventHandler(this.BtnMaliyetHesap_Click);
            // 
            // btnUrunKayıt
            // 
            this.btnUrunKayıt.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnUrunKayıt.Name = "btnUrunKayıt";
            this.btnUrunKayıt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUrunKayıt.Text = "Ürün Kayıt Etme";
            this.btnUrunKayıt.Click += new System.EventHandler(this.BtnUrunKayıt_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUrunGuncelle.Text = "Ürün Güncelleme";
            this.btnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // btnUrunSılme
            // 
            this.btnUrunSılme.Name = "btnUrunSılme";
            this.btnUrunSılme.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUrunSılme.Text = "Ürün Silme";
            this.btnUrunSılme.Click += new System.EventHandler(this.BtnUrunSılme_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.btnUrunIslemKayıt});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Üretim Aşamaları";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // btnUrunIslemKayıt
            // 
            this.btnUrunIslemKayıt.Name = "btnUrunIslemKayıt";
            this.btnUrunIslemKayıt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUrunIslemKayıt.Text = "Ürün İşlem Kayıt";
            this.btnUrunIslemKayıt.Click += new System.EventHandler(this.BtnUrunIslemKayıt_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHamMaddeOlustur,
            this.btnHamMaddeGuncelle,
            this.btnHamMaddeSil});
            this.accordionControlElement9.Expanded = true;
            this.accordionControlElement9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement9.ImageOptions.Image")));
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Text = "Ham Madde İşlemleri";
            // 
            // btnHamMaddeOlustur
            // 
            this.btnHamMaddeOlustur.Name = "btnHamMaddeOlustur";
            this.btnHamMaddeOlustur.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeOlustur.Text = "Ham Madde Oluştur";
            // 
            // btnHamMaddeGuncelle
            // 
            this.btnHamMaddeGuncelle.Name = "btnHamMaddeGuncelle";
            this.btnHamMaddeGuncelle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeGuncelle.Text = "Ham Madde Güncelle";
            // 
            // btnHamMaddeSil
            // 
            this.btnHamMaddeSil.Name = "btnHamMaddeSil";
            this.btnHamMaddeSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHamMaddeSil.Text = "Ham Madde Sil";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnKalıpOlustur,
            this.btnUruneKalıpAta});
            this.accordionControlElement12.Expanded = true;
            this.accordionControlElement12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement12.ImageOptions.Image")));
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Text = "Kalıp Işlemleri";
            // 
            // btnKalıpOlustur
            // 
            this.btnKalıpOlustur.Name = "btnKalıpOlustur";
            this.btnKalıpOlustur.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnKalıpOlustur.Text = "Kalıp Oluştur";
            // 
            // btnUruneKalıpAta
            // 
            this.btnUruneKalıpAta.Name = "btnUruneKalıpAta";
            this.btnUruneKalıpAta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUruneKalıpAta.Text = "Ürüne Kalıp Ata";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1071, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // uretimPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 586);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "uretimPanel";
            this.NavigationControl = this.accordionControl1;
            this.Text = "uretimPanel";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUrunGuncelle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUrunSılme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUrunKayıt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMaliyetHesap;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUrunIslemKayıt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeOlustur;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeGuncelle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnHamMaddeSil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnKalıpOlustur;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUruneKalıpAta;
    }
}