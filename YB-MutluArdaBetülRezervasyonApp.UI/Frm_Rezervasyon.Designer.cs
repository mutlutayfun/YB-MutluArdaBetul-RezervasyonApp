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
            txtTCNo = new TextBox();
            label5 = new Label();
            txtGuestMail = new TextBox();
            txtGuestPhone = new TextBox();
            txtGuestAddress = new TextBox();
            txtGuestSurname = new TextBox();
            txtGuestName = new TextBox();
            btnGuestSave = new Button();
            dtpDogumTarihi = new DateTimePicker();
            lblEmail = new Label();
            lblNo = new Label();
            lblAdres = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblIsim = new Label();
            cmbOdaTipi = new ComboBox();
            lblGecelikUcret = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            lblTutar = new Label();
            dtpCikisTarihi = new DateTimePicker();
            cmbHName = new ComboBox();
            label7 = new Label();
            lnlHName = new Label();
            dtpGirisTarihi = new DateTimePicker();
            btnOluştur = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            btnSil = new Button();
            groupBox4 = new GroupBox();
            dgvListe = new DataGridView();
            label2 = new Label();
            nmrGuestNumber = new NumericUpDown();
            label4 = new Label();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).BeginInit();
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
            groupBox1.Controls.Add(txtTCNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtGuestMail);
            groupBox1.Controls.Add(txtGuestPhone);
            groupBox1.Controls.Add(txtGuestAddress);
            groupBox1.Controls.Add(txtGuestSurname);
            groupBox1.Controls.Add(txtGuestName);
            groupBox1.Controls.Add(btnGuestSave);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(lblAdres);
            groupBox1.Controls.Add(lblDogumTarihi);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblIsim);
            groupBox1.Location = new Point(18, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 291);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Misafir";
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(96, 24);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(194, 23);
            txtTCNo.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 30);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 18;
            label5.Text = "TC No :";
            // 
            // txtGuestMail
            // 
            txtGuestMail.Location = new Point(96, 207);
            txtGuestMail.Name = "txtGuestMail";
            txtGuestMail.Size = new Size(194, 23);
            txtGuestMail.TabIndex = 17;
            // 
            // txtGuestPhone
            // 
            txtGuestPhone.Location = new Point(96, 178);
            txtGuestPhone.Name = "txtGuestPhone";
            txtGuestPhone.Size = new Size(194, 23);
            txtGuestPhone.TabIndex = 16;
            // 
            // txtGuestAddress
            // 
            txtGuestAddress.Location = new Point(96, 149);
            txtGuestAddress.Name = "txtGuestAddress";
            txtGuestAddress.Size = new Size(194, 23);
            txtGuestAddress.TabIndex = 15;
            // 
            // txtGuestSurname
            // 
            txtGuestSurname.Location = new Point(96, 91);
            txtGuestSurname.Name = "txtGuestSurname";
            txtGuestSurname.Size = new Size(194, 23);
            txtGuestSurname.TabIndex = 14;
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(96, 59);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(194, 23);
            txtGuestName.TabIndex = 13;
            // 
            // btnGuestSave
            // 
            btnGuestSave.BackColor = Color.LimeGreen;
            btnGuestSave.Location = new Point(96, 252);
            btnGuestSave.Name = "btnGuestSave";
            btnGuestSave.Size = new Size(194, 33);
            btnGuestSave.TabIndex = 12;
            btnGuestSave.Text = "Kaydet";
            btnGuestSave.UseVisualStyleBackColor = false;
            btnGuestSave.Click += btnGuestSave_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(96, 120);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(194, 23);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(6, 181);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(46, 15);
            lblNo.TabIndex = 4;
            lblNo.Text = "Tel No :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(6, 152);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(43, 15);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Location = new Point(6, 126);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(84, 15);
            lblDogumTarihi.TabIndex = 2;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(6, 94);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(45, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Location = new Point(6, 65);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(35, 15);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "İsim :";
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(100, 54);
            cmbOdaTipi.Name = "cmbOdaTipi";
            cmbOdaTipi.Size = new Size(194, 23);
            cmbOdaTipi.TabIndex = 5;
            // 
            // lblGecelikUcret
            // 
            lblGecelikUcret.AutoSize = true;
            lblGecelikUcret.Location = new Point(10, 94);
            lblGecelikUcret.Name = "lblGecelikUcret";
            lblGecelikUcret.Size = new Size(85, 15);
            lblGecelikUcret.TabIndex = 2;
            lblGecelikUcret.Text = "Gecelik Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lblTutar);
            groupBox3.Controls.Add(dtpCikisTarihi);
            groupBox3.Controls.Add(cmbHName);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lnlHName);
            groupBox3.Controls.Add(dtpGirisTarihi);
            groupBox3.Controls.Add(cmbOdaTipi);
            groupBox3.Controls.Add(btnOluştur);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lblGecelikUcret);
            groupBox3.Location = new Point(355, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 291);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rezervasyon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 62);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Oda Tipi :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(10, 188);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(40, 15);
            lblTutar.TabIndex = 15;
            lblTutar.Text = "Tutar :";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(100, 136);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(194, 23);
            dtpCikisTarihi.TabIndex = 13;
            // 
            // cmbHName
            // 
            cmbHName.FormattingEnabled = true;
            cmbHName.Location = new Point(100, 22);
            cmbHName.Name = "cmbHName";
            cmbHName.Size = new Size(194, 23);
            cmbHName.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 140);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 6;
            label7.Text = "Çıkış Tarihi :";
            // 
            // lnlHName
            // 
            lnlHName.AutoSize = true;
            lnlHName.Location = new Point(10, 22);
            lnlHName.Name = "lnlHName";
            lnlHName.Size = new Size(56, 15);
            lnlHName.TabIndex = 11;
            lnlHName.Text = "Otel Adı :";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(100, 97);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(194, 23);
            dtpGirisTarihi.TabIndex = 10;
            // 
            // btnOluştur
            // 
            btnOluştur.BackColor = Color.LimeGreen;
            btnOluştur.Location = new Point(100, 226);
            btnOluştur.Name = "btnOluştur";
            btnOluştur.Size = new Size(194, 43);
            btnOluştur.TabIndex = 9;
            btnOluştur.Text = "Oluştur";
            btnOluştur.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Orange;
            btnGuncelle.Location = new Point(688, 62);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(194, 49);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Turquoise;
            btnListele.Location = new Point(688, 133);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(194, 47);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.Location = new Point(688, 205);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(194, 51);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvListe);
            groupBox4.Location = new Point(18, 409);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(946, 263);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rezervasyon Listesi";
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Dock = DockStyle.Fill;
            dgvListe.Location = new Point(3, 19);
            dgvListe.Name = "dgvListe";
            dgvListe.Size = new Size(940, 241);
            dgvListe.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 388);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 14;
            label2.Text = "Rezervasyon Ara :";
            // 
            // nmrGuestNumber
            // 
            nmrGuestNumber.Location = new Point(114, 16);
            nmrGuestNumber.Name = "nmrGuestNumber";
            nmrGuestNumber.Size = new Size(58, 23);
            nmrGuestNumber.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 16;
            label4.Text = "Misafir Sayısı :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(275, 380);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 23);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1034, 681);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(nmrGuestNumber);
            Controls.Add(label2);
            Controls.Add(groupBox4);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Name = "Frm_Rezervasyon";
            Text = "Rezervasyon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox groupBox1;
        private Button btnGuestSave;
        private DateTimePicker dtpDogumTarihi;
        private Label lblEmail;
        private Label lblNo;
        private Label lblAdres;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblIsim;
        private ComboBox cmbOdaTipi;
        private Label lblGecelikUcret;
        private Label label1;
        private GroupBox groupBox3;
        private Label lblTutar;
        private DateTimePicker dtpCikisTarihi;
        private ComboBox cmbHName;
        private Label label7;
        private Label lnlHName;
        private DateTimePicker dtpGirisTarihi;
        private Button btnOluştur;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private GroupBox groupBox4;
        private DataGridView dgvListe;
        private Label label2;
        private NumericUpDown nmrGuestNumber;
        private Label label4;
        private TextBox txtSearch;
        private TextBox txtGuestMail;
        private TextBox txtGuestPhone;
        private TextBox txtGuestAddress;
        private TextBox txtGuestSurname;
        private TextBox txtGuestName;
        private Label label3;
        private TextBox txtTCNo;
        private Label label5;
    }
}
