namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    partial class Frm_Rezervasyon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            groupBox1 = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            cmbEmail = new ComboBox();
            cmbNo = new ComboBox();
            cmbAdres = new ComboBox();
            cmbSoyad = new ComboBox();
            cmbIsim = new ComboBox();
            lblEmail = new Label();
            lblNo = new Label();
            lblAdres = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblIsim = new Label();
            groupBox2 = new GroupBox();
            cmbPricePerNight = new ComboBox();
            cmbStatu = new ComboBox();
            cmbDescription = new ComboBox();
            nudCapacity = new NumericUpDown();
            cmbOdaName = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            cudStar = new NumericUpDown();
            lblStar = new Label();
            cmbHEmail = new ComboBox();
            cmbHNo = new ComboBox();
            cmbHAdres = new ComboBox();
            cmbHName = new ComboBox();
            lblHEmail = new Label();
            lblHNo = new Label();
            lblHAdres = new Label();
            lnlHName = new Label();
            btnArama = new Button();
            btnOluştur = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            btnSil = new Button();
            groupBox4 = new GroupBox();
            dgvListe = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cudStar).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(957, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 68);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(cmbEmail);
            groupBox1.Controls.Add(cmbNo);
            groupBox1.Controls.Add(cmbAdres);
            groupBox1.Controls.Add(cmbSoyad);
            groupBox1.Controls.Add(cmbIsim);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(lblAdres);
            groupBox1.Controls.Add(lblDogumTarihi);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblIsim);
            groupBox1.Location = new Point(39, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 219);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misafir";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(96, 80);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(194, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // cmbEmail
            // 
            cmbEmail.FormattingEnabled = true;
            cmbEmail.Location = new Point(96, 167);
            cmbEmail.Name = "cmbEmail";
            cmbEmail.Size = new Size(194, 23);
            cmbEmail.TabIndex = 10;
            // 
            // cmbNo
            // 
            cmbNo.FormattingEnabled = true;
            cmbNo.Location = new Point(96, 138);
            cmbNo.Name = "cmbNo";
            cmbNo.Size = new Size(194, 23);
            cmbNo.TabIndex = 9;
            // 
            // cmbAdres
            // 
            cmbAdres.FormattingEnabled = true;
            cmbAdres.Location = new Point(96, 109);
            cmbAdres.Name = "cmbAdres";
            cmbAdres.Size = new Size(194, 23);
            cmbAdres.TabIndex = 8;
            // 
            // cmbSoyad
            // 
            cmbSoyad.FormattingEnabled = true;
            cmbSoyad.Location = new Point(96, 51);
            cmbSoyad.Name = "cmbSoyad";
            cmbSoyad.Size = new Size(194, 23);
            cmbSoyad.TabIndex = 7;
            // 
            // cmbIsim
            // 
            cmbIsim.FormattingEnabled = true;
            cmbIsim.Location = new Point(96, 22);
            cmbIsim.Name = "cmbIsim";
            cmbIsim.Size = new Size(194, 23);
            cmbIsim.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(6, 141);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(46, 15);
            lblNo.TabIndex = 4;
            lblNo.Text = "Tel No :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(6, 112);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(43, 15);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Location = new Point(6, 86);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(84, 15);
            lblDogumTarihi.TabIndex = 2;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(6, 54);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(45, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Location = new Point(6, 25);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(35, 15);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "İsim :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbPricePerNight);
            groupBox2.Controls.Add(cmbStatu);
            groupBox2.Controls.Add(cmbDescription);
            groupBox2.Controls.Add(nudCapacity);
            groupBox2.Controls.Add(cmbOdaName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(345, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 219);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Oda ve Oda Tipi";
            // 
            // cmbPricePerNight
            // 
            cmbPricePerNight.FormattingEnabled = true;
            cmbPricePerNight.Location = new Point(129, 80);
            cmbPricePerNight.Name = "cmbPricePerNight";
            cmbPricePerNight.Size = new Size(165, 23);
            cmbPricePerNight.TabIndex = 9;
            // 
            // cmbStatu
            // 
            cmbStatu.FormattingEnabled = true;
            cmbStatu.Location = new Point(129, 109);
            cmbStatu.Name = "cmbStatu";
            cmbStatu.Size = new Size(165, 23);
            cmbStatu.TabIndex = 8;
            // 
            // cmbDescription
            // 
            cmbDescription.FormattingEnabled = true;
            cmbDescription.Location = new Point(129, 51);
            cmbDescription.Name = "cmbDescription";
            cmbDescription.Size = new Size(165, 23);
            cmbDescription.TabIndex = 7;
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(130, 138);
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(51, 23);
            nudCapacity.TabIndex = 6;
            // 
            // cmbOdaName
            // 
            cmbOdaName.FormattingEnabled = true;
            cmbOdaName.Location = new Point(129, 22);
            cmbOdaName.Name = "cmbOdaName";
            cmbOdaName.Size = new Size(165, 23);
            cmbOdaName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 140);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Kapasite :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Durum :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Gecelik Ücreti :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Açıklama :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Oda Tipi :";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cudStar);
            groupBox3.Controls.Add(lblStar);
            groupBox3.Controls.Add(cmbHEmail);
            groupBox3.Controls.Add(cmbHNo);
            groupBox3.Controls.Add(cmbHAdres);
            groupBox3.Controls.Add(cmbHName);
            groupBox3.Controls.Add(lblHEmail);
            groupBox3.Controls.Add(lblHNo);
            groupBox3.Controls.Add(lblHAdres);
            groupBox3.Controls.Add(lnlHName);
            groupBox3.Location = new Point(651, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 219);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hotel";
            // 
            // cudStar
            // 
            cudStar.Location = new Point(100, 139);
            cudStar.Name = "cudStar";
            cudStar.Size = new Size(51, 23);
            cudStar.TabIndex = 22;
            // 
            // lblStar
            // 
            lblStar.AutoSize = true;
            lblStar.Location = new Point(12, 141);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(41, 15);
            lblStar.TabIndex = 21;
            lblStar.Text = "Yıldız :";
            // 
            // cmbHEmail
            // 
            cmbHEmail.FormattingEnabled = true;
            cmbHEmail.Location = new Point(100, 109);
            cmbHEmail.Name = "cmbHEmail";
            cmbHEmail.Size = new Size(194, 23);
            cmbHEmail.TabIndex = 20;
            // 
            // cmbHNo
            // 
            cmbHNo.FormattingEnabled = true;
            cmbHNo.Location = new Point(100, 80);
            cmbHNo.Name = "cmbHNo";
            cmbHNo.Size = new Size(194, 23);
            cmbHNo.TabIndex = 19;
            // 
            // cmbHAdres
            // 
            cmbHAdres.FormattingEnabled = true;
            cmbHAdres.Location = new Point(100, 51);
            cmbHAdres.Name = "cmbHAdres";
            cmbHAdres.Size = new Size(194, 23);
            cmbHAdres.TabIndex = 18;
            // 
            // cmbHName
            // 
            cmbHName.FormattingEnabled = true;
            cmbHName.Location = new Point(100, 22);
            cmbHName.Name = "cmbHName";
            cmbHName.Size = new Size(194, 23);
            cmbHName.TabIndex = 16;
            // 
            // lblHEmail
            // 
            lblHEmail.AutoSize = true;
            lblHEmail.Location = new Point(10, 112);
            lblHEmail.Name = "lblHEmail";
            lblHEmail.Size = new Size(36, 15);
            lblHEmail.TabIndex = 15;
            lblHEmail.Text = "Email";
            // 
            // lblHNo
            // 
            lblHNo.AutoSize = true;
            lblHNo.Location = new Point(10, 83);
            lblHNo.Name = "lblHNo";
            lblHNo.Size = new Size(46, 15);
            lblHNo.TabIndex = 14;
            lblHNo.Text = "Tel No :";
            // 
            // lblHAdres
            // 
            lblHAdres.AutoSize = true;
            lblHAdres.Location = new Point(10, 54);
            lblHAdres.Name = "lblHAdres";
            lblHAdres.Size = new Size(43, 15);
            lblHAdres.TabIndex = 13;
            lblHAdres.Text = "Adres :";
            lblHAdres.Click += label8_Click;
            // 
            // lnlHName
            // 
            lnlHName.AutoSize = true;
            lnlHName.Location = new Point(10, 25);
            lnlHName.Name = "lnlHName";
            lnlHName.Size = new Size(35, 15);
            lnlHName.TabIndex = 11;
            lnlHName.Text = "İsim :";
            // 
            // btnArama
            // 
            btnArama.BackColor = SystemColors.Info;
            btnArama.Location = new Point(229, 253);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(100, 60);
            btnArama.TabIndex = 3;
            btnArama.Text = "REZERVASYON ARAMA";
            btnArama.UseVisualStyleBackColor = false;
            // 
            // btnOluştur
            // 
            btnOluştur.BackColor = SystemColors.Info;
            btnOluştur.Location = new Point(345, 253);
            btnOluştur.Name = "btnOluştur";
            btnOluştur.Size = new Size(100, 60);
            btnOluştur.TabIndex = 4;
            btnOluştur.Text = "REZERVASYON OLUŞTUR";
            btnOluştur.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.Info;
            btnGuncelle.Location = new Point(539, 253);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(100, 60);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "REZERVASYON GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.Info;
            btnListele.Location = new Point(661, 253);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(100, 60);
            btnListele.TabIndex = 6;
            btnListele.Text = "REZERVASYON LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Info;
            btnSil.Location = new Point(845, 253);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(100, 60);
            btnSil.TabIndex = 7;
            btnSil.Text = "REZERVASYON SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvListe);
            groupBox4.Location = new Point(12, 319);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1021, 349);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Liste";
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(6, 22);
            dgvListe.Name = "dgvListe";
            dgvListe.Size = new Size(1009, 321);
            dgvListe.TabIndex = 0;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1037, 680);
            Controls.Add(groupBox4);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(btnOluştur);
            Controls.Add(btnArama);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Rezervasyon";
            Text = "Frm_Rezervasyon";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cudStar).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox cmbEmail;
        private ComboBox cmbNo;
        private ComboBox cmbAdres;
        private ComboBox cmbSoyad;
        private ComboBox cmbIsim;
        private Label lblEmail;
        private Label lblNo;
        private Label lblAdres;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblIsim;
        private ComboBox cmbOdaName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPricePerNight;
        private ComboBox cmbStatu;
        private ComboBox cmbDescription;
        private NumericUpDown nudCapacity;
        private NumericUpDown cudStar;
        private Label lblStar;
        private ComboBox cmbHEmail;
        private ComboBox cmbHNo;
        private ComboBox cmbHAdres;
        private ComboBox cmbHName;
        private Label lblHEmail;
        private Label lblHNo;
        private Label lblHAdres;
        private Label lnlHName;
        private Button btnArama;
        private Button btnOluştur;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private GroupBox groupBox4;
        private DataGridView dgvListe;
    }
}
