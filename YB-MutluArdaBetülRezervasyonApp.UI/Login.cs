using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string gelenAd = txtAd.Text.Trim();
            string gelenSifre = txtSifre.Text;

            if (gelenAd.Equals("admin") && gelenSifre.Equals("admin"))
            {
                MessageBox.Show("Giriş yapıldı.");
                Frm_Rezervasyon rezervasyon = new Frm_Rezervasyon();
                rezervasyon.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void chkGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frm_Rezervasyon rezervasyon = new Frm_Rezervasyon();
            rezervasyon.Show();
            this.Hide();
        }
    }
}
