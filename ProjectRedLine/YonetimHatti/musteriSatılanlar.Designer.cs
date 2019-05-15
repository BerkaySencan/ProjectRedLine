namespace ProjectRedLine.YonetimHatti
{
    partial class musteriSatılanlar
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
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMusteri = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(904, 54);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 50);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "EXPORT PDF";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(411, 54);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(128, 50);
            this.btnGetir.TabIndex = 13;
            this.btnGetir.Text = "Satılan Ürünleri Getir";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Müsteri Seç :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.Location = new System.Drawing.Point(176, 39);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMusteri.Size = new System.Drawing.Size(191, 20);
            this.cmbMusteri.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 110);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1048, 493);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Müşteri Satılanlar Listesi ";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1044, 471);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // musteriSatılanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.groupControl1);
            this.Name = "musteriSatılanlar";
            this.Size = new System.Drawing.Size(1048, 603);
            this.Load += new System.EventHandler(this.MusteriSatılanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMusteri;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
