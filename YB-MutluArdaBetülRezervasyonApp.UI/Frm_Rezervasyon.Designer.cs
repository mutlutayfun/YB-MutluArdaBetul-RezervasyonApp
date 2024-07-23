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
            grpGuest = new GroupBox();
            txtTCNo = new TextBox();
            lblTcNo = new Label();
            txtGuestMail = new TextBox();
            txtGuestPhone = new TextBox();
            txtGuestAddress = new TextBox();
            txtGuestSurname = new TextBox();
            txtGuestName = new TextBox();
            btnGuestSave = new Button();
            dtpDogumTarihi = new DateTimePicker();
            lblEmail = new Label();
            lblTelNo = new Label();
            lblAdres = new Label();
            lblDogumTarihi = new Label();
            lblSoyad = new Label();
            lblIsim = new Label();
            cmbOdaTipi = new ComboBox();
            lblGecelikUcret = new Label();
            label1 = new Label();
            grpRezervasyon = new GroupBox();
            lblCapacity = new Label();
            lbllabelDescription = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTotalPrice = new Label();
            lblPricePerNight = new Label();
            lblGrsTarih = new Label();
            lblRoomType = new Label();
            lblTutar = new Label();
            dtpCikisTarihi = new DateTimePicker();
            cmbHName = new ComboBox();
            lblCksTarih = new Label();
            lblHName = new Label();
            dtpGirisTarihi = new DateTimePicker();
            btnOluştur = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            btnSil = new Button();
            groupBox4 = new GroupBox();
            dgvListe = new DataGridView();
            lblSearch = new Label();
            nmrGuestNumber = new NumericUpDown();
            lblGuestNum = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            grpGuest.SuspendLayout();
            grpRezervasyon.SuspendLayout();
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
            // grpGuest
            // 
            grpGuest.Controls.Add(txtTCNo);
            grpGuest.Controls.Add(lblTcNo);
            grpGuest.Controls.Add(txtGuestMail);
            grpGuest.Controls.Add(txtGuestPhone);
            grpGuest.Controls.Add(txtGuestAddress);
            grpGuest.Controls.Add(txtGuestSurname);
            grpGuest.Controls.Add(txtGuestName);
            grpGuest.Controls.Add(btnGuestSave);
            grpGuest.Controls.Add(dtpDogumTarihi);
            grpGuest.Controls.Add(lblEmail);
            grpGuest.Controls.Add(lblTelNo);
            grpGuest.Controls.Add(lblAdres);
            grpGuest.Controls.Add(lblDogumTarihi);
            grpGuest.Controls.Add(lblSoyad);
            grpGuest.Controls.Add(lblIsim);
            grpGuest.Font = new Font("Segoe UI", 10.2F);
            grpGuest.Location = new Point(18, 53);
            grpGuest.Name = "grpGuest";
            grpGuest.Size = new Size(340, 319);
            grpGuest.TabIndex = 1;
            grpGuest.TabStop = false;
            grpGuest.Text = "Misafir";
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(122, 24);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(194, 26);
            txtTCNo.TabIndex = 19;
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTcNo.Location = new Point(6, 30);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(58, 19);
            lblTcNo.TabIndex = 18;
            lblTcNo.Text = "TC No :";
            // 
            // txtGuestMail
            // 
            txtGuestMail.Location = new Point(122, 207);
            txtGuestMail.Name = "txtGuestMail";
            txtGuestMail.Size = new Size(194, 26);
            txtGuestMail.TabIndex = 17;
            // 
            // txtGuestPhone
            // 
            txtGuestPhone.Location = new Point(122, 178);
            txtGuestPhone.Name = "txtGuestPhone";
            txtGuestPhone.Size = new Size(194, 26);
            txtGuestPhone.TabIndex = 16;
            // 
            // txtGuestAddress
            // 
            txtGuestAddress.Location = new Point(122, 149);
            txtGuestAddress.Name = "txtGuestAddress";
            txtGuestAddress.Size = new Size(194, 26);
            txtGuestAddress.TabIndex = 15;
            // 
            // txtGuestSurname
            // 
            txtGuestSurname.Location = new Point(122, 91);
            txtGuestSurname.Name = "txtGuestSurname";
            txtGuestSurname.Size = new Size(194, 26);
            txtGuestSurname.TabIndex = 14;
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(122, 59);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(194, 26);
            txtGuestName.TabIndex = 13;
            // 
            // btnGuestSave
            // 
            btnGuestSave.BackColor = Color.LimeGreen;
            btnGuestSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuestSave.Location = new Point(140, 270);
            btnGuestSave.Name = "btnGuestSave";
            btnGuestSave.Size = new Size(194, 39);
            btnGuestSave.TabIndex = 12;
            btnGuestSave.Text = "Kaydet";
            btnGuestSave.UseVisualStyleBackColor = false;
            btnGuestSave.Click += btnGuestSave_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(122, 120);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(194, 26);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(6, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 19);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelNo.Location = new Point(6, 181);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(60, 19);
            lblTelNo.TabIndex = 4;
            lblTelNo.Text = "Tel No :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAdres.Location = new Point(6, 152);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(56, 19);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDogumTarihi.Location = new Point(3, 125);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(107, 19);
            lblDogumTarihi.TabIndex = 2;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoyad.Location = new Point(6, 94);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(59, 19);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIsim.Location = new Point(9, 62);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(44, 19);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "İsim :";
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(144, 62);
            cmbOdaTipi.Name = "cmbOdaTipi";
            cmbOdaTipi.Size = new Size(194, 27);
            cmbOdaTipi.TabIndex = 5;
            cmbOdaTipi.SelectedIndexChanged += cmbOdaTipi_SelectedIndexChanged;
            // 
            // lblGecelikUcret
            // 
            lblGecelikUcret.AutoSize = true;
            lblGecelikUcret.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGecelikUcret.Location = new Point(6, 94);
            lblGecelikUcret.Name = "lblGecelikUcret";
            lblGecelikUcret.Size = new Size(110, 19);
            lblGecelikUcret.TabIndex = 2;
            lblGecelikUcret.Text = "Gecelik Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 64);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            // 
            // grpRezervasyon
            // 
            grpRezervasyon.Controls.Add(lblCapacity);
            grpRezervasyon.Controls.Add(lbllabelDescription);
            grpRezervasyon.Controls.Add(label3);
            grpRezervasyon.Controls.Add(label2);
            grpRezervasyon.Controls.Add(lblTotalPrice);
            grpRezervasyon.Controls.Add(lblPricePerNight);
            grpRezervasyon.Controls.Add(lblGrsTarih);
            grpRezervasyon.Controls.Add(lblRoomType);
            grpRezervasyon.Controls.Add(lblTutar);
            grpRezervasyon.Controls.Add(dtpCikisTarihi);
            grpRezervasyon.Controls.Add(cmbHName);
            grpRezervasyon.Controls.Add(lblCksTarih);
            grpRezervasyon.Controls.Add(lblHName);
            grpRezervasyon.Controls.Add(dtpGirisTarihi);
            grpRezervasyon.Controls.Add(cmbOdaTipi);
            grpRezervasyon.Controls.Add(btnOluştur);
            grpRezervasyon.Controls.Add(label1);
            grpRezervasyon.Controls.Add(lblGecelikUcret);
            grpRezervasyon.Font = new Font("Segoe UI", 10.2F);
            grpRezervasyon.Location = new Point(376, 53);
            grpRezervasyon.Name = "grpRezervasyon";
            grpRezervasyon.Size = new Size(426, 319);
            grpRezervasyon.TabIndex = 7;
            grpRezervasyon.TabStop = false;
            grpRezervasyon.Text = "Rezervasyon";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.BackColor = Color.Wheat;
            lblCapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblCapacity.ForeColor = Color.Black;
            lblCapacity.Location = new Point(144, 149);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(121, 19);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "                            ";
            // 
            // lbllabelDescription
            // 
            lbllabelDescription.AutoSize = true;
            lbllabelDescription.BackColor = Color.Wheat;
            lbllabelDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbllabelDescription.ForeColor = Color.Black;
            lbllabelDescription.Location = new Point(144, 120);
            lbllabelDescription.Name = "lbllabelDescription";
            lbllabelDescription.Size = new Size(121, 19);
            lbllabelDescription.TabIndex = 21;
            lbllabelDescription.Text = "                            ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(7, 149);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 20;
            label3.Text = "Kapasite :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(6, 120);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 19;
            label2.Text = "Açıklama :";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Wheat;
            lblTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(144, 245);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(93, 19);
            lblTotalPrice.TabIndex = 18;
            lblTotalPrice.Text = "                     ";
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.BackColor = Color.Wheat;
            lblPricePerNight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblPricePerNight.ForeColor = Color.Black;
            lblPricePerNight.Location = new Point(144, 96);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(121, 19);
            lblPricePerNight.TabIndex = 18;
            lblPricePerNight.Text = "                            ";
            // 
            // lblGrsTarih
            // 
            lblGrsTarih.AutoSize = true;
            lblGrsTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGrsTarih.Location = new Point(7, 178);
            lblGrsTarih.Name = "lblGrsTarih";
            lblGrsTarih.Size = new Size(88, 19);
            lblGrsTarih.TabIndex = 17;
            lblGrsTarih.Text = "Giriş Tarihi :";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRoomType.Location = new Point(9, 70);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(74, 19);
            lblRoomType.TabIndex = 16;
            lblRoomType.Text = "Oda Tipi :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTutar.Location = new Point(9, 245);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(51, 19);
            lblTutar.TabIndex = 15;
            lblTutar.Text = "Tutar :";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(144, 204);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(194, 26);
            dtpCikisTarihi.TabIndex = 13;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // cmbHName
            // 
            cmbHName.FormattingEnabled = true;
            cmbHName.Location = new Point(144, 22);
            cmbHName.Name = "cmbHName";
            cmbHName.Size = new Size(194, 27);
            cmbHName.TabIndex = 12;
            cmbHName.SelectedIndexChanged += cmbHName_SelectedIndexChanged;
            // 
            // lblCksTarih
            // 
            lblCksTarih.AutoSize = true;
            lblCksTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCksTarih.Location = new Point(7, 208);
            lblCksTarih.Name = "lblCksTarih";
            lblCksTarih.Size = new Size(89, 19);
            lblCksTarih.TabIndex = 6;
            lblCksTarih.Text = "Çıkış Tarihi :";
            // 
            // lblHName
            // 
            lblHName.AutoSize = true;
            lblHName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHName.Location = new Point(9, 33);
            lblHName.Name = "lblHName";
            lblHName.Size = new Size(72, 19);
            lblHName.TabIndex = 11;
            lblHName.Text = "Otel Adı :";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(144, 178);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(195, 26);
            dtpGirisTarihi.TabIndex = 10;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            // 
            // btnOluştur
            // 
            btnOluştur.BackColor = Color.LimeGreen;
            btnOluştur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnOluştur.Location = new Point(226, 270);
            btnOluştur.Name = "btnOluştur";
            btnOluştur.Size = new Size(194, 43);
            btnOluştur.TabIndex = 9;
            btnOluştur.Text = "Oluştur";
            btnOluştur.UseVisualStyleBackColor = false;
            btnOluştur.Click += btnOluştur_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Orange;
            btnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuncelle.Location = new Point(808, 96);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(194, 49);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Turquoise;
            btnListele.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnListele.Location = new Point(808, 173);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(194, 47);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSil.Location = new Point(808, 247);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(194, 51);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvListe);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox4.Location = new Point(18, 409);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(993, 263);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rezervasyon Listesi";
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Dock = DockStyle.Fill;
            dgvListe.Location = new Point(3, 22);
            dgvListe.Name = "dgvListe";
            dgvListe.RowHeadersWidth = 51;
            dgvListe.Size = new Size(987, 238);
            dgvListe.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSearch.Location = new Point(168, 382);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(131, 19);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Rezervasyon Ara :";
            // 
            // nmrGuestNumber
            // 
            nmrGuestNumber.Location = new Point(134, 18);
            nmrGuestNumber.Name = "nmrGuestNumber";
            nmrGuestNumber.Size = new Size(58, 23);
            nmrGuestNumber.TabIndex = 15;
            nmrGuestNumber.ValueChanged += nmrGuestNumber_ValueChanged;
            // 
            // lblGuestNum
            // 
            lblGuestNum.AutoSize = true;
            lblGuestNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGuestNum.Location = new Point(18, 18);
            lblGuestNum.Name = "lblGuestNum";
            lblGuestNum.Size = new Size(105, 19);
            lblGuestNum.TabIndex = 16;
            lblGuestNum.Text = "Misafir Sayısı :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(306, 382);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 23);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(523, 378);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 28);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1034, 681);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblGuestNum);
            Controls.Add(nmrGuestNumber);
            Controls.Add(lblSearch);
            Controls.Add(groupBox4);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(grpRezervasyon);
            Controls.Add(grpGuest);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Rezervasyon";
            Text = "Rezervasyon";
            Load += Frm_Rezervasyon_Load;
            grpGuest.ResumeLayout(false);
            grpGuest.PerformLayout();
            grpRezervasyon.ResumeLayout(false);
            grpRezervasyon.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private GroupBox grpGuest;
        private Button btnGuestSave;
        private DateTimePicker dtpDogumTarihi;
        private Label lblEmail;
        private Label lblTelNo;
        private Label lblAdres;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblIsim;
        private ComboBox cmbOdaTipi;
        private Label lblGecelikUcret;
        private Label label1;
        private GroupBox grpRezervasyon;
        private Label lblTutar;
        private DateTimePicker dtpCikisTarihi;
        private ComboBox cmbHName;
        private Label lblCksTarih;
        private Label lblHName;
        private DateTimePicker dtpGirisTarihi;
        private Button btnOluştur;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private GroupBox groupBox4;
        private DataGridView dgvListe;
        private Label lblSearch;
        private NumericUpDown nmrGuestNumber;
        private Label lblGuestNum;
        private TextBox txtSearch;
        private TextBox txtGuestMail;
        private TextBox txtGuestPhone;
        private TextBox txtGuestAddress;
        private TextBox txtGuestSurname;
        private TextBox txtGuestName;
        private Label lblRoomType;
        private TextBox txtTCNo;
        private Label lblTcNo;
        private Label lblGrsTarih;
        private Label lblTotalPrice;
        private Label lblPricePerNight;
        private Button btnSearch;
        private Label lblCapacity;
        private Label lbllabelDescription;
        private Label label3;
        private Label label2;
    }
}
