namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    partial class Login
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
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            chkGoster = new CheckBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(8, 40);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(79, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(8, 82);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(84, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Kullanıcı Sifre :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(196, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(119, 79);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(196, 23);
            txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(119, 131);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(196, 30);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // chkGoster
            // 
            chkGoster.AutoSize = true;
            chkGoster.Location = new Point(321, 83);
            chkGoster.Name = "chkGoster";
            chkGoster.Size = new Size(60, 19);
            chkGoster.TabIndex = 5;
            chkGoster.Text = "Göster";
            chkGoster.UseVisualStyleBackColor = true;
            chkGoster.CheckedChanged += chkGoster_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(chkGoster);
            groupBox1.Controls.Add(lblKullaniciAdi);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(lblSifre);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Location = new Point(12, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Girişi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 113);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 6;
            label1.Text = "Üyeliğin yoksa buraya tıkla!!";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(411, 400);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtAd;
        private TextBox txtSifre;
        private Button btnGiris;
        private CheckBox chkGoster;
        private GroupBox groupBox1;
        private Label label1;
    }
}