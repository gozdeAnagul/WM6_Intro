namespace Cs.App
{
    partial class Form1
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
            this.btnAtes = new System.Windows.Forms.Button();
            this.btnYenidenDoldur = new System.Windows.Forms.Button();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.btnFirlat = new System.Windows.Forms.Button();
            this.cmbSilahlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_AtesliSilah = new System.Windows.Forms.GroupBox();
            this.lblDetay = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.gbYakinSaldiri = new System.Windows.Forms.GroupBox();
            this.gbFirlatilan = new System.Windows.Forms.GroupBox();
            this.panelSilah = new System.Windows.Forms.Panel();
            this.gb_AtesliSilah.SuspendLayout();
            this.gbYakinSaldiri.SuspendLayout();
            this.gbFirlatilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtes
            // 
            this.btnAtes.Location = new System.Drawing.Point(21, 28);
            this.btnAtes.Name = "btnAtes";
            this.btnAtes.Size = new System.Drawing.Size(91, 51);
            this.btnAtes.TabIndex = 0;
            this.btnAtes.Text = "Ateş Et";
            this.btnAtes.UseVisualStyleBackColor = true;
            this.btnAtes.Click += new System.EventHandler(this.btnAtes_Click);
            this.btnAtes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAtes_MouseDown);
            this.btnAtes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAtes_MouseUp);
            // 
            // btnYenidenDoldur
            // 
            this.btnYenidenDoldur.Location = new System.Drawing.Point(143, 28);
            this.btnYenidenDoldur.Name = "btnYenidenDoldur";
            this.btnYenidenDoldur.Size = new System.Drawing.Size(91, 51);
            this.btnYenidenDoldur.TabIndex = 1;
            this.btnYenidenDoldur.Text = "Doldur";
            this.btnYenidenDoldur.UseVisualStyleBackColor = true;
            this.btnYenidenDoldur.Click += new System.EventHandler(this.btnYenidenDoldur_Click);
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(33, 29);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(91, 51);
            this.btnSaldir.TabIndex = 2;
            this.btnSaldir.Text = "Saldır";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // btnFirlat
            // 
            this.btnFirlat.Location = new System.Drawing.Point(23, 28);
            this.btnFirlat.Name = "btnFirlat";
            this.btnFirlat.Size = new System.Drawing.Size(91, 51);
            this.btnFirlat.TabIndex = 3;
            this.btnFirlat.Text = "Fırlat";
            this.btnFirlat.UseVisualStyleBackColor = true;
            this.btnFirlat.Click += new System.EventHandler(this.btnFirlat_Click);
            // 
            // cmbSilahlar
            // 
            this.cmbSilahlar.FormattingEnabled = true;
            this.cmbSilahlar.Location = new System.Drawing.Point(97, 22);
            this.cmbSilahlar.Name = "cmbSilahlar";
            this.cmbSilahlar.Size = new System.Drawing.Size(201, 21);
            this.cmbSilahlar.TabIndex = 4;
            this.cmbSilahlar.SelectedIndexChanged += new System.EventHandler(this.cmbSilahlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silah Seçiniz";
            // 
            // gb_AtesliSilah
            // 
            this.gb_AtesliSilah.Controls.Add(this.lblDurum);
            this.gb_AtesliSilah.Controls.Add(this.btnAtes);
            this.gb_AtesliSilah.Controls.Add(this.btnYenidenDoldur);
            this.gb_AtesliSilah.Location = new System.Drawing.Point(29, 94);
            this.gb_AtesliSilah.Name = "gb_AtesliSilah";
            this.gb_AtesliSilah.Size = new System.Drawing.Size(344, 100);
            this.gb_AtesliSilah.TabIndex = 6;
            this.gb_AtesliSilah.TabStop = false;
            this.gb_AtesliSilah.Text = "Silah Kontrol";
            this.gb_AtesliSilah.Visible = false;
            // 
            // lblDetay
            // 
            this.lblDetay.AutoSize = true;
            this.lblDetay.Location = new System.Drawing.Point(26, 60);
            this.lblDetay.Name = "lblDetay";
            this.lblDetay.Size = new System.Drawing.Size(35, 13);
            this.lblDetay.TabIndex = 10;
            this.lblDetay.Text = "label2";
            this.lblDetay.Visible = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(261, 47);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(35, 13);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "label2";
            // 
            // gbYakinSaldiri
            // 
            this.gbYakinSaldiri.Controls.Add(this.btnSaldir);
            this.gbYakinSaldiri.Location = new System.Drawing.Point(29, 223);
            this.gbYakinSaldiri.Name = "gbYakinSaldiri";
            this.gbYakinSaldiri.Size = new System.Drawing.Size(200, 100);
            this.gbYakinSaldiri.TabIndex = 7;
            this.gbYakinSaldiri.TabStop = false;
            this.gbYakinSaldiri.Text = "Yakın Saldırı Kontrol";
            this.gbYakinSaldiri.Visible = false;
            // 
            // gbFirlatilan
            // 
            this.gbFirlatilan.Controls.Add(this.btnFirlat);
            this.gbFirlatilan.Location = new System.Drawing.Point(429, 223);
            this.gbFirlatilan.Name = "gbFirlatilan";
            this.gbFirlatilan.Size = new System.Drawing.Size(200, 100);
            this.gbFirlatilan.TabIndex = 8;
            this.gbFirlatilan.TabStop = false;
            this.gbFirlatilan.Text = "Fırlatılan Silah Kontrol";
            this.gbFirlatilan.Visible = false;
            // 
            // panelSilah
            // 
            this.panelSilah.Location = new System.Drawing.Point(429, 22);
            this.panelSilah.Name = "panelSilah";
            this.panelSilah.Size = new System.Drawing.Size(309, 162);
            this.panelSilah.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 355);
            this.Controls.Add(this.lblDetay);
            this.Controls.Add(this.panelSilah);
            this.Controls.Add(this.gbFirlatilan);
            this.Controls.Add(this.gbYakinSaldiri);
            this.Controls.Add(this.gb_AtesliSilah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSilahlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_AtesliSilah.ResumeLayout(false);
            this.gb_AtesliSilah.PerformLayout();
            this.gbYakinSaldiri.ResumeLayout(false);
            this.gbFirlatilan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtes;
        private System.Windows.Forms.Button btnYenidenDoldur;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.Button btnFirlat;
        private System.Windows.Forms.ComboBox cmbSilahlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_AtesliSilah;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.GroupBox gbYakinSaldiri;
        private System.Windows.Forms.GroupBox gbFirlatilan;
        private System.Windows.Forms.Panel panelSilah;
        private System.Windows.Forms.Label lblDetay;
    }
}

