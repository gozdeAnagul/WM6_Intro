namespace XmlJsonServislerine_B
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
            this.lblDeger = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblHereNow = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnHarita = new System.Windows.Forms.Button();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeger.ForeColor = System.Drawing.Color.Maroon;
            this.lblDeger.Location = new System.Drawing.Point(42, 67);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(57, 20);
            this.lblDeger.TabIndex = 0;
            this.lblDeger.Text = "label1";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.Color.Tomato;
            this.lblKod.Location = new System.Drawing.Point(42, 9);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(57, 20);
            this.lblKod.TabIndex = 1;
            this.lblKod.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 186);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Location = new System.Drawing.Point(463, 67);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(50, 13);
            this.lblFirmaAdi.TabIndex = 3;
            this.lblFirmaAdi.Text = "Firma Adı";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(463, 114);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres";
            // 
            // lblHereNow
            // 
            this.lblHereNow.AutoSize = true;
            this.lblHereNow.Location = new System.Drawing.Point(463, 161);
            this.lblHereNow.Name = "lblHereNow";
            this.lblHereNow.Size = new System.Drawing.Size(92, 13);
            this.lblHereNow.TabIndex = 5;
            this.lblHereNow.Text = "Şuan Kaç Kişi Var";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(466, 12);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(112, 43);
            this.btnGetir.TabIndex = 6;
            this.btnGetir.Text = "Getir De Getirelim";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnHarita
            // 
            this.btnHarita.Location = new System.Drawing.Point(466, 212);
            this.btnHarita.Name = "btnHarita";
            this.btnHarita.Size = new System.Drawing.Size(112, 43);
            this.btnHarita.TabIndex = 7;
            this.btnHarita.Text = "Haritada Göster";
            this.btnHarita.UseVisualStyleBackColor = true;
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.Location = new System.Drawing.Point(268, 12);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(183, 277);
            this.lstFirmalar.TabIndex = 8;
            this.lstFirmalar.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 351);
            this.Controls.Add(this.lstFirmalar);
            this.Controls.Add(this.btnHarita);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lblHereNow);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.lblDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblHereNow;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnHarita;
        private System.Windows.Forms.ListBox lstFirmalar;
    }
}

