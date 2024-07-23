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
            dgvList = new DataGridView();
            lstList = new ListBox();
            lblSearch = new Label();
            nmrGuestNumber = new NumericUpDown();
            lblGuestNum = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            grpGuest.SuspendLayout();
            grpRezervasyon.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrGuestNumber).BeginInit();
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
            grpGuest.Location = new Point(21, 71);
            grpGuest.Margin = new Padding(3, 4, 3, 4);
            grpGuest.Name = "grpGuest";
            grpGuest.Padding = new Padding(3, 4, 3, 4);
            grpGuest.Size = new Size(389, 425);
            grpGuest.TabIndex = 1;
            grpGuest.TabStop = false;
            grpGuest.Text = "Misafir";
            // 
            // txtTCNo
            // 
            txtTCNo.Location = new Point(139, 32);
            txtTCNo.Margin = new Padding(3, 4, 3, 4);
            txtTCNo.Name = "txtTCNo";
            txtTCNo.Size = new Size(221, 30);
            txtTCNo.TabIndex = 19;
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTcNo.Location = new Point(7, 40);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new Size(68, 23);
            lblTcNo.TabIndex = 18;
            lblTcNo.Text = "TC No :";
            // 
            // txtGuestMail
            // 
            txtGuestMail.Location = new Point(139, 276);
            txtGuestMail.Margin = new Padding(3, 4, 3, 4);
            txtGuestMail.Name = "txtGuestMail";
            txtGuestMail.Size = new Size(221, 30);
            txtGuestMail.TabIndex = 17;
            // 
            // txtGuestPhone
            // 
            txtGuestPhone.Location = new Point(139, 237);
            txtGuestPhone.Margin = new Padding(3, 4, 3, 4);
            txtGuestPhone.Name = "txtGuestPhone";
            txtGuestPhone.Size = new Size(221, 30);
            txtGuestPhone.TabIndex = 16;
            // 
            // txtGuestAddress
            // 
            txtGuestAddress.Location = new Point(139, 199);
            txtGuestAddress.Margin = new Padding(3, 4, 3, 4);
            txtGuestAddress.Name = "txtGuestAddress";
            txtGuestAddress.Size = new Size(221, 30);
            txtGuestAddress.TabIndex = 15;
            // 
            // txtGuestSurname
            // 
            txtGuestSurname.Location = new Point(139, 121);
            txtGuestSurname.Margin = new Padding(3, 4, 3, 4);
            txtGuestSurname.Name = "txtGuestSurname";
            txtGuestSurname.Size = new Size(221, 30);
            txtGuestSurname.TabIndex = 14;
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(139, 79);
            txtGuestName.Margin = new Padding(3, 4, 3, 4);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(221, 30);
            txtGuestName.TabIndex = 13;
            // 
            // btnGuestSave
            // 
            btnGuestSave.BackColor = Color.LimeGreen;
            btnGuestSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuestSave.Location = new Point(160, 360);
            btnGuestSave.Margin = new Padding(3, 4, 3, 4);
            btnGuestSave.Name = "btnGuestSave";
            btnGuestSave.Size = new Size(222, 52);
            btnGuestSave.TabIndex = 12;
            btnGuestSave.Text = "Kaydet";
            btnGuestSave.UseVisualStyleBackColor = false;
            btnGuestSave.Click += btnGuestSave_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(139, 160);
            dtpDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(221, 30);
            dtpDogumTarihi.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(7, 280);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelNo.Location = new Point(7, 241);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(70, 23);
            lblTelNo.TabIndex = 4;
            lblTelNo.Text = "Tel No :";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAdres.Location = new Point(7, 203);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(66, 23);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres :";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDogumTarihi.Location = new Point(3, 167);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(130, 23);
            lblDogumTarihi.TabIndex = 2;
            lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSoyad.Location = new Point(7, 125);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(69, 23);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad :";
            // 
            // lblIsim
            // 
            lblIsim.AutoSize = true;
            lblIsim.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIsim.Location = new Point(10, 83);
            lblIsim.Name = "lblIsim";
            lblIsim.Size = new Size(53, 23);
            lblIsim.TabIndex = 0;
            lblIsim.Text = "İsim :";
            // 
            // cmbOdaTipi
            // 
            cmbOdaTipi.FormattingEnabled = true;
            cmbOdaTipi.Location = new Point(165, 83);
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
            lblGecelikUcret.Location = new Point(7, 125);
            lblGecelikUcret.Name = "lblGecelikUcret";
            lblGecelikUcret.Size = new Size(131, 23);
            lblGecelikUcret.TabIndex = 2;
            lblGecelikUcret.Text = "Gecelik Ücreti :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 85);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // grpRezervasyon
            // 
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
            grpRezervasyon.Controls.Add(btnOluştur);
            grpRezervasyon.Controls.Add(label1);
            grpRezervasyon.Controls.Add(lblGecelikUcret);
            grpRezervasyon.Font = new Font("Segoe UI", 10.2F);
            grpRezervasyon.Location = new Point(430, 71);
            grpRezervasyon.Margin = new Padding(3, 4, 3, 4);
            grpRezervasyon.Name = "grpRezervasyon";
            grpRezervasyon.Padding = new Padding(3, 4, 3, 4);
            grpRezervasyon.Size = new Size(487, 425);
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
            lblCapacity.Location = new Point(165, 199);
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
            lbllabelDescription.Location = new Point(165, 160);
            lbllabelDescription.Name = "lbllabelDescription";
            lbllabelDescription.Size = new Size(150, 23);
            lbllabelDescription.TabIndex = 21;
            lbllabelDescription.Text = "                            ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(8, 199);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 20;
            label3.Text = "Kapasite :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(7, 160);
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
            lblTotalPrice.Location = new Point(165, 327);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(115, 23);
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
            lblPricePerNight.Location = new Point(165, 128);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(150, 23);
            lblPricePerNight.TabIndex = 18;
            lblPricePerNight.Text = "                            ";
            // 
            // lblGrsTarih
            // 
            lblGrsTarih.AutoSize = true;
            lblGrsTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGrsTarih.Location = new Point(8, 237);
            lblGrsTarih.Name = "lblGrsTarih";
            lblGrsTarih.Size = new Size(106, 23);
            lblGrsTarih.TabIndex = 17;
            lblGrsTarih.Text = "Giriş Tarihi :";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRoomType.Location = new Point(10, 93);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(89, 23);
            lblRoomType.TabIndex = 16;
            lblRoomType.Text = "Oda Tipi :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTutar.Location = new Point(10, 327);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(62, 23);
            lblTutar.TabIndex = 15;
            lblTutar.Text = "Tutar :";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(165, 272);
            dtpCikisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(221, 30);
            dtpCikisTarihi.TabIndex = 13;
            dtpCikisTarihi.ValueChanged += dtpCikisTarihi_ValueChanged;
            // 
            // cmbHName
            // 
            cmbHName.FormattingEnabled = true;
            cmbHName.Location = new Point(165, 29);
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
            lblCksTarih.Location = new Point(8, 277);
            lblCksTarih.Name = "lblCksTarih";
            lblCksTarih.Size = new Size(108, 23);
            lblCksTarih.TabIndex = 6;
            lblCksTarih.Text = "Çıkış Tarihi :";
            // 
            // lblHName
            // 
            lblHName.AutoSize = true;
            lblHName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblHName.Location = new Point(10, 44);
            lblHName.Name = "lblHName";
            lblHName.Size = new Size(87, 23);
            lblHName.TabIndex = 11;
            lblHName.Text = "Otel Adı :";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(165, 237);
            dtpGirisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(222, 30);
            dtpGirisTarihi.TabIndex = 10;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            // 
            // btnOluştur
            // 
            btnOluştur.BackColor = Color.LimeGreen;
            btnOluştur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnOluştur.Location = new Point(320, 360);
            btnOluştur.Margin = new Padding(3, 4, 3, 4);
            btnOluştur.Name = "btnOluştur";
            btnOluştur.Size = new Size(160, 57);
            btnOluştur.TabIndex = 9;
            btnOluştur.Text = "Oluştur";
            btnOluştur.UseVisualStyleBackColor = false;
            btnOluştur.Click += btnOluştur_Click;
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
            groupBox4.Controls.Add(lstList);
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
            dgvList.Location = new Point(11, 29);
            dgvList.Margin = new Padding(3, 4, 3, 4);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(1113, 315);
            dgvList.TabIndex = 1;
            // 
            // lstList
            // 
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 23;
            lstList.Location = new Point(11, 29);
            lstList.Margin = new Padding(3, 4, 3, 4);
            lstList.Name = "lstList";
            lstList.Size = new Size(1113, 96);
            lstList.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSearch.Location = new Point(192, 509);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(152, 23);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Rezervasyon Ara :";
            // 
            // nmrGuestNumber
            // 
            nmrGuestNumber.Location = new Point(153, 24);
            nmrGuestNumber.Margin = new Padding(3, 4, 3, 4);
            nmrGuestNumber.Name = "nmrGuestNumber";
            nmrGuestNumber.Size = new Size(66, 27);
            nmrGuestNumber.TabIndex = 15;
            nmrGuestNumber.ValueChanged += nmrGuestNumber_ValueChanged;
            // 
            // lblGuestNum
            // 
            lblGuestNum.AutoSize = true;
            lblGuestNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblGuestNum.Location = new Point(21, 24);
            lblGuestNum.Name = "lblGuestNum";
            lblGuestNum.Size = new Size(126, 23);
            lblGuestNum.TabIndex = 16;
            lblGuestNum.Text = "Misafir Sayısı :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(350, 509);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LimeGreen;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSearch.Location = new Point(598, 504);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 37);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPaymentMethod.Location = new Point(5, 375);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(117, 23);
            lblPaymentMethod.TabIndex = 23;
            lblPaymentMethod.Text = "Ödeme Şekli:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(128, 367);
            cmbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(158, 31);
            cmbPaymentMethod.TabIndex = 24;
            // 
            // Frm_Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1182, 908);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Rezervasyon";
            Text = "Rezervasyon";
            Load += Frm_Rezervasyon_Load;
            grpGuest.ResumeLayout(false);
            grpGuest.PerformLayout();
            grpRezervasyon.ResumeLayout(false);
            grpRezervasyon.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
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
        private ListBox lstList;
        private DataGridView dgvList;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
    }
}
