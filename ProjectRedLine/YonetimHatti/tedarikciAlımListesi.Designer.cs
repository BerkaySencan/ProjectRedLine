namespace ProjectRedLine.YonetimHatti
{
    partial class tedarikciAlımListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tedarikciAlımListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTedarikci = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHepsiniGetir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTedarikci.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 87);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1024, 505);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Tedarikçiden Alınanlar ";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1020, 483);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.Location = new System.Drawing.Point(893, 36);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 50);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "EXPORT PDF";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(369, 31);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(128, 50);
            this.btnGetir.TabIndex = 17;
            this.btnGetir.Text = "Alınan Ürünleri Getir";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Tedarikçi Seç";
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.Location = new System.Drawing.Point(152, 33);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTedarikci.Size = new System.Drawing.Size(191, 20);
            this.cmbTedarikci.TabIndex = 14;
            // 
            // btnHepsiniGetir
            // 
            this.btnHepsiniGetir.Location = new System.Drawing.Point(513, 31);
            this.btnHepsiniGetir.Name = "btnHepsiniGetir";
            this.btnHepsiniGetir.Size = new System.Drawing.Size(128, 50);
            this.btnHepsiniGetir.TabIndex = 17;
            this.btnHepsiniGetir.Text = "Hepsini Getir";
            // 
            // tedarikciAlımListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnHepsiniGetir);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.groupControl1);
            this.Name = "tedarikciAlımListesi";
            this.Size = new System.Drawing.Size(1024, 592);
            this.Load += new System.EventHandler(this.TedarikciAlımListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTedarikci.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTedarikci;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniGetir;
    }
}
