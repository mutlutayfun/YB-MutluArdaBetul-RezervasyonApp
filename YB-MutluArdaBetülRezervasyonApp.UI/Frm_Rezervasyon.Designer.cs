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
            btnSaveAllGuests = new Button();
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
            cmbOdaNo = new ComboBox();
            label4 = new Label();
            lblGuestNum = new Label();
            nmrGuestNumber = new NumericUpDown();
            lblGun = new Label();
            cmbPaymentMethod = new ComboBox();
            lblPaymentMethod = new Label();
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
            btnOlustur = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            btnSil = new Button();
            groupBox4 = new GroupBox();
            dgvList = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnClear = new Button();
            grpGuest.SuspendLayout();
            grpRezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1094, 16);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 91);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // grpGuest
            // 
            grpGuest.Controls.Add(btnSaveAllGuests);
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
            grpGuest.Location = new Point(528, 17);
            grpGuest.Margin = new Padding(3, 4, 3, 4);
            grpGuest.Name = "grpGuest";
            grpGuest.Padding = new Padding(3, 4, 3, 4);
            grpGuest.Size = new Size(389, 473);
            grpGuest.TabIndex = 1;
            grpGuest.TabStop = false;
            grpGuest.Text = "Misafir";
            // 
            // btnSaveAllGuests
            // 
            btnSaveAllGuests.BackColor = Color.Turquoise;
            btnSaveAllGuests.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaveAllGuests.Location = new Point(143, 400);
            btnSaveAllGuests.Margin = new Padding(3, 4, 3, 4);
            btnSaveAllGuests.Name = "btnSaveAllGuests";
            btnSaveAllGuests.Size = new Size(222, 51);
            btnSaveAllGuests.TabIndex = 20;
            btnSaveAllGuests.Text = "Tüm Misafirleri Kaydet";
            btnSaveAllGuests.UseVisualStyleBackColor = false;
            btnSaveAllGuests.Click += btnSaveAllGuests_Click;
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(143, 35);
            txtTCNo.Margin = new Padding(3, 4, 3, 4);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(221, 30);
            txtTCNo.TabIndex = 19;
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTcNo.Location = new Point(10, 43);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(68, 23);
            lblTcNo.TabIndex = 18;
            lblTcNo.Text = "TC No :";
            // 
            // txtGuestMail
            // 
            txtGuestMail.Location = new Point(143, 279);
            txtGuestMail.Margin = new Padding(3, 4, 3, 4);
            txtGuestMail.Name = "txtGuestMail";
            txtGuestMail.Size = new Size(221, 30);
            txtGuestMail.TabIndex = 17;
            // 
            // txtGuestPhone
            // 
            txtGuestPhone.Location = new Point(143, 240);
            txtGuestPhone.Margin = new Padding(3, 4, 3, 4);
            txtGuestPhone.Name = "txtGuestPhone";
            txtGuestPhone.Size = new Size(221, 30);
            txtGuestPhone.TabIndex = 16;
            // 
            // txtGuestAddress
            // 
            txtGuestAddress.Location = new Point(143, 201);
            txtGuestAddress.Margin = new Padding(3, 4, 3, 4);
            txtGuestAddress.Name = "txtGuestAddress";
            txtGuestAddress.Size = new Size(221, 30);
            txtGuestAddress.TabIndex = 15;
            // 
            // txtGuestSurname
            // 
            txtGuestSurname.Location = new Point(143, 124);
            txtGuestSurname.Margin = new Padding(3, 4, 3, 4);
            txtGuestSurname.Name = "txtGuestSurname";
            txtGuestSurname.Size = new Size(221, 30);
            txtGuestSurname.TabIndex = 14;
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(143, 81);
            txtGuestName.Margin = new Padding(3, 4, 3, 4);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(221, 30);
            txtGuestName.TabIndex = 13;
            // 
            // btnGuestSave
            // 
            btnGuestSave.BackColor = Color.LimeGreen;
            btnGuestSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuestSave.Location = new Point(142, 340);
            btnGuestSave.Margin = new Padding(3, 4, 3, 4);
            btnGuestSave.Name = "btnGuestSave";
            btnGuestSave.Size = new Size(222, 52);
            btnGuestSave.TabIndex = 12;
            btnGuestSave.Text = "Listeye Ekle";
            btnGuestSave.UseVisualStyleBackColor = false;
            btnGuestSave.Click += btnGuestSave_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(143, 163);
            dtpDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(221, 30);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(10, 283);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelNo.Location = new Point(10, 244);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(70, 23);
            lblTelNo.TabIndex = 4;
            lblTelNo.Text = "Tel No :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAdres.Location = new Point(10, 205);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(66, 23);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDogumTarihi.Location = new Point(7, 169);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(130, 23);
            lblDogumTarihi.TabIndex = 2;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoyad.Location = new Point(10, 128);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(69, 23);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIsim.Location = new Point(14, 85);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(53, 23);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "İsim :";
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(194, 101);
            cmbOdaTipi.Margin = new Padding(3, 4, 3, 4);
            cmbOdaTipi.Name = "cmbOdaTipi";
            cmbOdaTipi.Size = new Size(221, 31);
            cmbOdaTipi.TabIndex = 5;
            cmbOdaTipi.SelectedIndexChanged += cmbOdaTipi_SelectedIndexChanged;
            // 
            // lblGecelikUcret
            // 
            lblGecelikUcret.AutoSize = true;
            lblGecelikUcret.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGecelikUcret.Location = new Point(6, 191);
            lblGecelikUcret.Name = "lblGecelikUcret";
            lblGecelikUcret.Size = new Size(131, 23);
            lblGecelikUcret.TabIndex = 2;
            lblGecelikUcret.Text = "Gecelik Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // grpRezervasyon
            // 
            grpRezervasyon.Controls.Add(cmbOdaNo);
            grpRezervasyon.Controls.Add(label4);
            grpRezervasyon.Controls.Add(lblGuestNum);
            grpRezervasyon.Controls.Add(nmrGuestNumber);
            grpRezervasyon.Controls.Add(lblGun);
            grpRezervasyon.Controls.Add(cmbPaymentMethod);
            grpRezervasyon.Controls.Add(lblPaymentMethod);
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
            grpRezervasyon.Controls.Add(btnOlustur);
            grpRezervasyon.Controls.Add(label1);
            grpRezervasyon.Controls.Add(lblGecelikUcret);
            grpRezervasyon.Font = new Font("Segoe UI", 10.2F);
            grpRezervasyon.Location = new Point(21, 16);
            grpRezervasyon.Margin = new Padding(3, 4, 3, 4);
            grpRezervasyon.Name = "grpRezervasyon";
            grpRezervasyon.Padding = new Padding(3, 4, 3, 4);
            grpRezervasyon.Size = new Size(487, 501);
            grpRezervasyon.TabIndex = 7;
            grpRezervasyon.TabStop = false;
            grpRezervasyon.Text = "Rezervasyon";
            // 
            // cmbOdaNo
            // 
            cmbOdaNo.FormattingEnabled = true;
            cmbOdaNo.Location = new Point(194, 147);
            cmbOdaNo.Margin = new Padding(3, 4, 3, 4);
            cmbOdaNo.Name = "cmbOdaNo";
            cmbOdaNo.Size = new Size(221, 31);
            cmbOdaNo.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(8, 155);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 28;
            label4.Text = "Oda No :";
            // 
            // lblGuestNum
            // 
            lblGuestNum.AutoSize = true;
            lblGuestNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGuestNum.Location = new Point(6, 33);
            lblGuestNum.Name = "lblGuestNum";
            lblGuestNum.Size = new Size(126, 23);
            lblGuestNum.TabIndex = 16;
            lblGuestNum.Text = "Misafir Sayısı :";
            // 
            // nmrGuestNumber
            // 
            nmrGuestNumber.Location = new Point(194, 24);
            nmrGuestNumber.Margin = new Padding(3, 4, 3, 4);
            nmrGuestNumber.Name = "nmrGuestNumber";
            nmrGuestNumber.Size = new Size(66, 30);
            nmrGuestNumber.TabIndex = 15;
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.BackColor = Color.Wheat;
            lblGun.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblGun.ForeColor = Color.Black;
            lblGun.Location = new Point(355, 388);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(65, 23);
            lblGun.TabIndex = 25;
            lblGun.Text = "           ";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(138, 445);
            cmbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(158, 31);
            cmbPaymentMethod.TabIndex = 24;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPaymentMethod.Location = new Point(10, 449);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(122, 23);
            lblPaymentMethod.TabIndex = 23;
            lblPaymentMethod.Text = "Ödeme Şekli :";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.BackColor = Color.Wheat;
            lblCapacity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblCapacity.ForeColor = Color.Black;
            lblCapacity.Location = new Point(195, 273);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(150, 23);
            lblCapacity.TabIndex = 22;
            lblCapacity.Text = "                            ";
            // 
            // lbllabelDescription
            // 
            lbllabelDescription.AutoSize = true;
            lbllabelDescription.BackColor = Color.Wheat;
            lbllabelDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lbllabelDescription.ForeColor = Color.Black;
            lbllabelDescription.Location = new Point(182, 235);
            lbllabelDescription.Name = "lbllabelDescription";
            lbllabelDescription.Size = new Size(150, 23);
            lbllabelDescription.TabIndex = 21;
            lbllabelDescription.Text = "                            ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(8, 273);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 20;
            label3.Text = "Kapasite :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(8, 235);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 19;
            label2.Text = "Açıklama :";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Wheat;
            lblTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(194, 401);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(115, 23);
            lblTotalPrice.TabIndex = 18;
            lblTotalPrice.Text = "                     ";
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.BackColor = Color.Wheat;
            lblPricePerNight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            lblPricePerNight.ForeColor = Color.Black;
            lblPricePerNight.Location = new Point(194, 191);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(150, 23);
            lblPricePerNight.TabIndex = 18;
            lblPricePerNight.Text = "                            ";
            // 
            // lblGrsTarih
            // 
            lblGrsTarih.AutoSize = true;
            lblGrsTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGrsTarih.Location = new Point(8, 311);
            lblGrsTarih.Name = "lblGrsTarih";
            lblGrsTarih.Size = new Size(106, 23);
            lblGrsTarih.TabIndex = 17;
            lblGrsTarih.Text = "Giriş Tarihi :";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRoomType.Location = new Point(6, 109);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(89, 23);
            lblRoomType.TabIndex = 16;
            lblRoomType.Text = "Oda Tipi :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTutar.Location = new Point(10, 401);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(62, 23);
            lblTutar.TabIndex = 15;
            lblTutar.Text = "Tutar :";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(194, 348);
            dtpCikisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(221, 30);
            dtpCikisTarihi.TabIndex = 13;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // cmbHName
            // 
            cmbHName.FormattingEnabled = true;
            cmbHName.Location = new Point(194, 61);
            cmbHName.Margin = new Padding(3, 4, 3, 4);
            cmbHName.Name = "cmbHName";
            cmbHName.Size = new Size(221, 31);
            cmbHName.TabIndex = 12;
            cmbHName.SelectedIndexChanged += cmbHName_SelectedIndexChanged;
            // 
            // lblCksTarih
            // 
            lblCksTarih.AutoSize = true;
            lblCksTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCksTarih.Location = new Point(8, 351);
            lblCksTarih.Name = "lblCksTarih";
            lblCksTarih.Size = new Size(108, 23);
            lblCksTarih.TabIndex = 6;
            lblCksTarih.Text = "Çıkış Tarihi :";
            // 
            // lblHName
            // 
            lblHName.AutoSize = true;
            lblHName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHName.Location = new Point(6, 69);
            lblHName.Name = "lblHName";
            lblHName.Size = new Size(87, 23);
            lblHName.TabIndex = 11;
            lblHName.Text = "Otel Adı :";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(194, 309);
            dtpGirisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(222, 30);
            dtpGirisTarihi.TabIndex = 10;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.LimeGreen;
            btnOlustur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnOlustur.Location = new Point(323, 435);
            btnOlustur.Margin = new Padding(3, 4, 3, 4);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(157, 57);
            btnOlustur.TabIndex = 9;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Orange;
            btnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuncelle.Location = new Point(923, 128);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(222, 65);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Turquoise;
            btnListele.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnListele.Location = new Point(923, 231);
            btnListele.Margin = new Padding(3, 4, 3, 4);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(222, 63);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSil.Location = new Point(923, 329);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(222, 68);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvList);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            groupBox4.Location = new Point(21, 545);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(1135, 351);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rezervasyon Listesi";
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(11, 33);
            dgvList.Margin = new Padding(3, 4, 3, 4);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(1113, 311);
            dgvList.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSearch.Location = new Point(720, 516);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(152, 23);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Rezervasyon Ara :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(903, 511);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 255);
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClear.Location = new Point(923, 425);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(222, 65);
            btnClear.TabIndex = 19;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1182, 908);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(groupBox4);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(grpRezervasyon);
            Controls.Add(grpGuest);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Rezervasyon";
            Text = "Rezervasyon";
            Load += Frm_Rezervasyon_Load;
            grpGuest.ResumeLayout(false);
            grpGuest.PerformLayout();
            grpRezervasyon.ResumeLayout(false);
            grpRezervasyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
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
        private Button btnOlustur;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private GroupBox groupBox4;
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
        private Label lblCapacity;
        private Label lbllabelDescription;
        private Label label3;
        private Label label2;
        private DataGridView dgvList;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Button btnClear;
        private Label lblGun;
        private ComboBox cmbOdaNo;
        private Label label4;
        private Button btnSaveAllGuests;
    }
}
