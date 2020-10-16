namespace OOP_Hamburger_Otomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblAcıklama = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.grbMalzeme = new System.Windows.Forms.GroupBox();
            this.chSarimsak = new System.Windows.Forms.CheckBox();
            this.chBufallo = new System.Windows.Forms.CheckBox();
            this.chRanch = new System.Windows.Forms.CheckBox();
            this.chBarbeku = new System.Windows.Forms.CheckBox();
            this.chAcıSos = new System.Windows.Forms.CheckBox();
            this.chHardal = new System.Windows.Forms.CheckBox();
            this.chMayonez = new System.Windows.Forms.CheckBox();
            this.chKetcap = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.grbMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(524, 636);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 30);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(12, 57);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(67, 17);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menüler :";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(405, 57);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(45, 17);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet :";
            // 
            // lblAcıklama
            // 
            this.lblAcıklama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcıklama.Location = new System.Drawing.Point(19, 500);
            this.lblAcıklama.Name = "lblAcıklama";
            this.lblAcıklama.Size = new System.Drawing.Size(484, 132);
            this.lblAcıklama.TabIndex = 3;
            this.lblAcıklama.Text = "Discription :";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(524, 276);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(742, 356);
            this.lstSiparisler.TabIndex = 10;
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbKucuk.Location = new System.Drawing.Point(14, 160);
            this.rdbKucuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(104, 21);
            this.rdbKucuk.TabIndex = 11;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Kucuk Boy :";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbOrta.Location = new System.Drawing.Point(14, 204);
            this.rdbOrta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(93, 21);
            this.rdbOrta.TabIndex = 12;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta Boy :";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbBuyuk.Location = new System.Drawing.Point(14, 251);
            this.rdbBuyuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(104, 21);
            this.rdbBuyuk.TabIndex = 13;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Buyuk Boy :";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(14, 92);
            this.cmbMenuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(300, 24);
            this.cmbMenuler.TabIndex = 15;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(404, 92);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(74, 22);
            this.nmrAdet.TabIndex = 16;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbMalzeme
            // 
            this.grbMalzeme.Controls.Add(this.chSarimsak);
            this.grbMalzeme.Controls.Add(this.chBufallo);
            this.grbMalzeme.Controls.Add(this.chRanch);
            this.grbMalzeme.Controls.Add(this.chBarbeku);
            this.grbMalzeme.Controls.Add(this.chAcıSos);
            this.grbMalzeme.Controls.Add(this.chHardal);
            this.grbMalzeme.Controls.Add(this.chMayonez);
            this.grbMalzeme.Controls.Add(this.chKetcap);
            this.grbMalzeme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbMalzeme.Location = new System.Drawing.Point(14, 292);
            this.grbMalzeme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMalzeme.Name = "grbMalzeme";
            this.grbMalzeme.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbMalzeme.Size = new System.Drawing.Size(300, 156);
            this.grbMalzeme.TabIndex = 17;
            this.grbMalzeme.TabStop = false;
            this.grbMalzeme.Text = "Extras :";
            // 
            // chSarimsak
            // 
            this.chSarimsak.AutoSize = true;
            this.chSarimsak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chSarimsak.Location = new System.Drawing.Point(155, 114);
            this.chSarimsak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chSarimsak.Name = "chSarimsak";
            this.chSarimsak.Size = new System.Drawing.Size(88, 21);
            this.chSarimsak.TabIndex = 7;
            this.chSarimsak.Tag = "1,25";
            this.chSarimsak.Text = "Sarimsak";
            this.chSarimsak.UseVisualStyleBackColor = true;
            // 
            // chBufallo
            // 
            this.chBufallo.AutoSize = true;
            this.chBufallo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chBufallo.Location = new System.Drawing.Point(155, 88);
            this.chBufallo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBufallo.Name = "chBufallo";
            this.chBufallo.Size = new System.Drawing.Size(73, 21);
            this.chBufallo.TabIndex = 6;
            this.chBufallo.Tag = "1,0";
            this.chBufallo.Text = "Bufallo";
            this.chBufallo.UseVisualStyleBackColor = true;
            // 
            // chRanch
            // 
            this.chRanch.AutoSize = true;
            this.chRanch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chRanch.Location = new System.Drawing.Point(155, 60);
            this.chRanch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chRanch.Name = "chRanch";
            this.chRanch.Size = new System.Drawing.Size(71, 21);
            this.chRanch.TabIndex = 5;
            this.chRanch.Tag = "0,90";
            this.chRanch.Text = "Ranch";
            this.chRanch.UseVisualStyleBackColor = true;
            // 
            // chBarbeku
            // 
            this.chBarbeku.AutoSize = true;
            this.chBarbeku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chBarbeku.Location = new System.Drawing.Point(155, 32);
            this.chBarbeku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBarbeku.Name = "chBarbeku";
            this.chBarbeku.Size = new System.Drawing.Size(83, 21);
            this.chBarbeku.TabIndex = 4;
            this.chBarbeku.Tag = "0,90";
            this.chBarbeku.Text = "Barbeku";
            this.chBarbeku.UseVisualStyleBackColor = true;
            // 
            // chAcıSos
            // 
            this.chAcıSos.AutoSize = true;
            this.chAcıSos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chAcıSos.Location = new System.Drawing.Point(6, 116);
            this.chAcıSos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chAcıSos.Name = "chAcıSos";
            this.chAcıSos.Size = new System.Drawing.Size(77, 21);
            this.chAcıSos.TabIndex = 3;
            this.chAcıSos.Tag = "0,85";
            this.chAcıSos.Text = "Acı Sos";
            this.chAcıSos.UseVisualStyleBackColor = true;
            // 
            // chHardal
            // 
            this.chHardal.AutoSize = true;
            this.chHardal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chHardal.Location = new System.Drawing.Point(6, 88);
            this.chHardal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chHardal.Name = "chHardal";
            this.chHardal.Size = new System.Drawing.Size(72, 21);
            this.chHardal.TabIndex = 2;
            this.chHardal.Tag = "0,75";
            this.chHardal.Text = "Hardal";
            this.chHardal.UseVisualStyleBackColor = true;
            // 
            // chMayonez
            // 
            this.chMayonez.AutoSize = true;
            this.chMayonez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chMayonez.Location = new System.Drawing.Point(6, 60);
            this.chMayonez.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chMayonez.Name = "chMayonez";
            this.chMayonez.Size = new System.Drawing.Size(91, 21);
            this.chMayonez.TabIndex = 1;
            this.chMayonez.Tag = "0,50";
            this.chMayonez.Text = "Mayonez ";
            this.chMayonez.UseVisualStyleBackColor = true;
            // 
            // chKetcap
            // 
            this.chKetcap.AutoSize = true;
            this.chKetcap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chKetcap.Location = new System.Drawing.Point(6, 32);
            this.chKetcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chKetcap.Name = "chKetcap";
            this.chKetcap.Size = new System.Drawing.Size(78, 21);
            this.chKetcap.TabIndex = 0;
            this.chKetcap.Tag = "0,50";
            this.chKetcap.Text = "Ketcap ";
            this.chKetcap.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(1188, 636);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(77, 30);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(656, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Menü  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1283, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbMalzeme);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.rdbBuyuk);
            this.Controls.Add(this.rdbOrta);
            this.Controls.Add(this.rdbKucuk);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.lblAcıklama);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.grbMalzeme.ResumeLayout(false);
            this.grbMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblAcıklama;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.GroupBox grbMalzeme;
        private System.Windows.Forms.CheckBox chSarimsak;
        private System.Windows.Forms.CheckBox chBufallo;
        private System.Windows.Forms.CheckBox chRanch;
        private System.Windows.Forms.CheckBox chBarbeku;
        private System.Windows.Forms.CheckBox chAcıSos;
        private System.Windows.Forms.CheckBox chHardal;
        private System.Windows.Forms.CheckBox chMayonez;
        private System.Windows.Forms.CheckBox chKetcap;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

