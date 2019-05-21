namespace ProjectRedLine.UretımHatti
{
    partial class urunGuncelle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMarka = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKdv = new DevExpress.XtraEditors.TextEdit();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.txtModelAd = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cmbKategori);
            this.groupControl1.Controls.Add(this.btnResimSec);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.cmbMarka);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKdv);
            this.groupControl1.Controls.Add(this.txtStok);
            this.groupControl1.Controls.Add(this.txtModelAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(628, 355);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Ürün Güncelleme";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupControl1_Paint);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(285, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Ürün Resmi ";
            // 
            // cmbKategori
            // 
            this.cmbKategori.Location = new System.Drawing.Point(115, 146);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategori.Size = new System.Drawing.Size(129, 20);
            this.cmbKategori.TabIndex = 4;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(258, 263);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(156, 71);
            this.btnResimSec.TabIndex = 2;
            this.btnResimSec.Text = "Resim Seç";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(442, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 71);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(285, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 141);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMarka
            // 
            this.cmbMarka.Location = new System.Drawing.Point(115, 184);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMarka.Size = new System.Drawing.Size(129, 20);
            this.cmbMarka.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Marka :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "KDV Oranı :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Kategori :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Stok :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Model Adi :";
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(115, 227);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(129, 20);
            this.txtKdv.TabIndex = 0;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(115, 104);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(129, 20);
            this.txtStok.TabIndex = 0;
            // 
            // txtModelAd
            // 
            this.txtModelAd.Location = new System.Drawing.Point(115, 65);
            this.txtModelAd.Name = "txtModelAd";
            this.txtModelAd.Size = new System.Drawing.Size(129, 20);
            this.txtModelAd.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 355);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(628, 174);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // urunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "urunGuncelle";
            this.Size = new System.Drawing.Size(628, 529);
            this.Load += new System.EventHandler(this.UrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKategori;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMarka;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKdv;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.TextEdit txtModelAd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
