namespace YB_MutluArdaBetülRezervasyonApp.UI
{
    partial class Frm_RezervasyonBilgi
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
            btnKapat = new Button();
            label1 = new Label();
            lstRezervasyon = new ListBox();
            SuspendLayout();
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(0, 192, 0);
            btnKapat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKapat.Location = new Point(75, 476);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(217, 44);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 2;
            label1.Text = "REZERVASYON BİLGİLERİ";
            // 
            // lstRezervasyon
            // 
            lstRezervasyon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lstRezervasyon.FormattingEnabled = true;
            lstRezervasyon.ItemHeight = 23;
            lstRezervasyon.Location = new Point(35, 46);
            lstRezervasyon.Name = "lstRezervasyon";
            lstRezervasyon.Size = new Size(301, 418);
            lstRezervasyon.TabIndex = 3;
            // 
            // Frm_RezervasyonBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(363, 542);
            Controls.Add(lstRezervasyon);
            Controls.Add(label1);
            Controls.Add(btnKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_RezervasyonBilgi";
            Text = "Frm_RezervasyonBilgi";
            Load += Frm_RezervasyonBilgi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKapat;
        private Label label1;
        private ListBox lstRezervasyon;
    }
}