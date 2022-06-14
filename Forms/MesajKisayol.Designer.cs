namespace yoklama_app.Forms
{
    partial class MesajKisayol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajKisayol));
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.İsimSoyisim = new System.Windows.Forms.Label();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.ch3 = new System.Windows.Forms.CheckBox();
            this.ch4 = new System.Windows.Forms.CheckBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.ForeColor = System.Drawing.Color.White;
            this.ch1.Location = new System.Drawing.Point(72, 58);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(113, 17);
            this.ch1.TabIndex = 0;
            this.ch1.Text = "Kıyafeti Uygunsuz ";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // İsimSoyisim
            // 
            this.İsimSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İsimSoyisim.ForeColor = System.Drawing.Color.White;
            this.İsimSoyisim.Location = new System.Drawing.Point(2, 9);
            this.İsimSoyisim.Name = "İsimSoyisim";
            this.İsimSoyisim.Size = new System.Drawing.Size(261, 23);
            this.İsimSoyisim.TabIndex = 1;
            this.İsimSoyisim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.İsimSoyisim.Click += new System.EventHandler(this.label1_Click);
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.ForeColor = System.Drawing.Color.White;
            this.ch2.Location = new System.Drawing.Point(72, 94);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(93, 17);
            this.ch2.TabIndex = 2;
            this.ch2.Text = "Derste Uyuyor";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.ForeColor = System.Drawing.Color.White;
            this.ch3.Location = new System.Drawing.Point(72, 130);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(113, 17);
            this.ch3.TabIndex = 3;
            this.ch3.Text = "Araç Gereçleri yok";
            this.ch3.UseVisualStyleBackColor = true;
            // 
            // ch4
            // 
            this.ch4.AutoSize = true;
            this.ch4.ForeColor = System.Drawing.Color.White;
            this.ch4.Location = new System.Drawing.Point(72, 166);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(78, 17);
            this.ch4.TabIndex = 4;
            this.ch4.Text = "benzeri bişi";
            this.ch4.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Gönder";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(63, 232);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(113, 33);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // MesajKisayol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(264, 305);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.İsimSoyisim);
            this.Controls.Add(this.ch1);
            this.Name = "MesajKisayol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Mesaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.CheckBox ch1;
        public System.Windows.Forms.Label İsimSoyisim;
        public System.Windows.Forms.CheckBox ch2;
        public System.Windows.Forms.CheckBox ch3;
        public System.Windows.Forms.CheckBox ch4;
    }
}