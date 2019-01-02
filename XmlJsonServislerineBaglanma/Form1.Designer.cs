namespace XmlJsonServislerineBaglanma
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
            this.components = new System.ComponentModel.Container();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblHereNow = new System.Windows.Forms.Label();
            this.btnHaritadaGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.Color.Red;
            this.lblKod.Location = new System.Drawing.Point(12, 9);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(57, 20);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "label1";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDeger.Location = new System.Drawing.Point(12, 38);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(57, 20);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 225);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.lstbEkle_SelectedIndexChanged);
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.Location = new System.Drawing.Point(268, 16);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(191, 290);
            this.lstFirmalar.TabIndex = 3;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(486, 16);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(114, 46);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "Getir de getirelim";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(495, 81);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(46, 13);
            this.lblFirmaAdi.TabIndex = 5;
            this.lblFirmaAdi.Text = "firma adi";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(495, 118);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(33, 13);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "adres";
            // 
            // lblHereNow
            // 
            this.lblHereNow.AutoSize = true;
            this.lblHereNow.Location = new System.Drawing.Point(495, 152);
            this.lblHereNow.Name = "lblHereNow";
            this.lblHereNow.Size = new System.Drawing.Size(90, 13);
            this.lblHereNow.TabIndex = 7;
            this.lblHereNow.Text = "şu an kaç kişi var";
            // 
            // btnHaritadaGoster
            // 
            this.btnHaritadaGoster.Location = new System.Drawing.Point(486, 190);
            this.btnHaritadaGoster.Name = "btnHaritadaGoster";
            this.btnHaritadaGoster.Size = new System.Drawing.Size(114, 46);
            this.btnHaritadaGoster.TabIndex = 8;
            this.btnHaritadaGoster.Text = "Haritada göster";
            this.btnHaritadaGoster.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 350);
            this.Controls.Add(this.btnHaritadaGoster);
            this.Controls.Add(this.lblHereNow);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lstFirmalar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblKod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstFirmalar;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblHereNow;
        private System.Windows.Forms.Button btnHaritadaGoster;
    }
}

