namespace ProjectRedLine.SatisHatti
{
    partial class faturaGetir
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
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnFaturaGetir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(130, 66);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(149, 20);
            this.txtFaturaNo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fatura No :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnFaturaGetir);
            this.groupControl1.Controls.Add(this.txtFaturaNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(373, 254);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Fatura Getir ";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupControl1_Paint);
            // 
            // btnFaturaGetir
            // 
            this.btnFaturaGetir.Location = new System.Drawing.Point(121, 122);
            this.btnFaturaGetir.Name = "btnFaturaGetir";
            this.btnFaturaGetir.Size = new System.Drawing.Size(135, 66);
            this.btnFaturaGetir.TabIndex = 2;
            this.btnFaturaGetir.Text = "Fatura Getir";
            // 
            // faturaGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "faturaGetir";
            this.Size = new System.Drawing.Size(373, 254);
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnFaturaGetir;
    }
}
