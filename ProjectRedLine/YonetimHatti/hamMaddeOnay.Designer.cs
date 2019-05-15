namespace ProjectRedLine.YonetimHatti
{
    partial class hamMaddeOnay
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
            this.btnBekleme = new System.Windows.Forms.Button();
            this.btnYeniSiparis = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBekleme
            // 
            this.btnBekleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBekleme.Location = new System.Drawing.Point(666, 32);
            this.btnBekleme.Name = "btnBekleme";
            this.btnBekleme.Size = new System.Drawing.Size(164, 46);
            this.btnBekleme.TabIndex = 0;
            this.btnBekleme.Text = "\"\" Beklemede Hammadde Siparişi";
            this.btnBekleme.UseVisualStyleBackColor = false;
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYeniSiparis.Location = new System.Drawing.Point(853, 32);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(164, 46);
            this.btnYeniSiparis.TabIndex = 0;
            this.btnYeniSiparis.Text = "\"\" Yeni Hammade Siparişi";
            this.btnYeniSiparis.UseVisualStyleBackColor = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(609, 417);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBekleme);
            this.groupControl1.Controls.Add(this.btnYeniSiparis);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1033, 144);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Ham Madde Onay";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupControl1_Paint);
            // 
            // hamMaddeOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "hamMaddeOnay";
            this.Size = new System.Drawing.Size(1033, 583);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBekleme;
        private System.Windows.Forms.Button btnYeniSiparis;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
