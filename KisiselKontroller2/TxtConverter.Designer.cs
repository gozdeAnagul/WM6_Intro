namespace KisiselKontroller2
{
    partial class TxtConverter
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
            this.txtOkunus = new System.Windows.Forms.TextBox();
            this.nuSayi = new System.Windows.Forms.NumericUpDown();
            this.txtCconverter = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).BeginInit();
            this.txtCconverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOkunus
            // 
            this.txtOkunus.Location = new System.Drawing.Point(3, 29);
            this.txtOkunus.Name = "txtOkunus";
            this.txtOkunus.ReadOnly = true;
            this.txtOkunus.Size = new System.Drawing.Size(128, 20);
            this.txtOkunus.TabIndex = 0;
            // 
            // nuSayi
            // 
            this.nuSayi.Location = new System.Drawing.Point(3, 3);
            this.nuSayi.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nuSayi.MaximumSize = new System.Drawing.Size(128, 0);
            this.nuSayi.MinimumSize = new System.Drawing.Size(128, 0);
            this.nuSayi.Name = "nuSayi";
            this.nuSayi.Size = new System.Drawing.Size(128, 20);
            this.nuSayi.TabIndex = 1;
            // 
            // txtCconverter
            // 
            this.txtCconverter.Controls.Add(this.nuSayi);
            this.txtCconverter.Controls.Add(this.txtOkunus);
            this.txtCconverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCconverter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.txtCconverter.Location = new System.Drawing.Point(0, 0);
            this.txtCconverter.MaximumSize = new System.Drawing.Size(145, 65);
            this.txtCconverter.MinimumSize = new System.Drawing.Size(145, 65);
            this.txtCconverter.Name = "txtCconverter";
            this.txtCconverter.Size = new System.Drawing.Size(145, 65);
            this.txtCconverter.TabIndex = 2;
            // 
            // TxtConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCconverter);
            this.Name = "TxtConverter";
            this.Size = new System.Drawing.Size(142, 61);
            ((System.ComponentModel.ISupportInitialize)(this.nuSayi)).EndInit();
            this.txtCconverter.ResumeLayout(false);
            this.txtCconverter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOkunus;
        private System.Windows.Forms.NumericUpDown nuSayi;
        private System.Windows.Forms.FlowLayoutPanel txtCconverter;
    }
}
