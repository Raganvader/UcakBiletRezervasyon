namespace Ucak_bilet_Rez_AI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKimlik = new System.Windows.Forms.TextBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUcusTarihi = new System.Windows.Forms.DateTimePicker();
            this.listBoxKoltuklar = new System.Windows.Forms.ListBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Ad TextBox
            this.txtAd.Location = new System.Drawing.Point(20, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Tag = "Ad"; // Placeholder için Tag ekle

            // Placeholder olayları ekle
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Text = "Ad";
            this.txtAd.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.txtAd.Leave += new System.EventHandler(this.SetPlaceholder);

            // Soyad TextBox
            this.txtSoyad.Location = new System.Drawing.Point(20, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Tag = "Soyad"; // Placeholder için Tag ekle
            this.txtSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.txtSoyad.Leave += new System.EventHandler(this.SetPlaceholder);

            // TCKimlik TextBox
            this.txtTCKimlik.Location = new System.Drawing.Point(20, 100);
            this.txtTCKimlik.Name = "txtTCKimlik";
            this.txtTCKimlik.Size = new System.Drawing.Size(200, 22);
            this.txtTCKimlik.TabIndex = 2;
            this.txtTCKimlik.Tag = "TC Kimlik No"; // Placeholder için Tag ekle
            this.txtTCKimlik.ForeColor = System.Drawing.Color.Gray;
            this.txtTCKimlik.Text = "TC Kimlik No";
            this.txtTCKimlik.Enter += new System.EventHandler(this.RemovePlaceholder);
            this.txtTCKimlik.Leave += new System.EventHandler(this.SetPlaceholder);

            // Nereden ComboBox
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Antalya" });
            this.cmbNereden.Location = new System.Drawing.Point(250, 20);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(200, 24);
            this.cmbNereden.TabIndex = 3;
            this.cmbNereden.Text = "Nereden";

            // Nereye ComboBox
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Antalya" });
            this.cmbNereye.Location = new System.Drawing.Point(250, 60);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(200, 24);
            this.cmbNereye.TabIndex = 4;
            this.cmbNereye.Text = "Nereye";

            // Uçuş Tarihi DateTimePicker
            this.dateTimePickerUcusTarihi.Location = new System.Drawing.Point(250, 100);
            this.dateTimePickerUcusTarihi.Name = "dateTimePickerUcusTarihi";
            this.dateTimePickerUcusTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerUcusTarihi.TabIndex = 5;

            // Koltuk ListBox
            this.listBoxKoltuklar.FormattingEnabled = true;
            this.listBoxKoltuklar.ItemHeight = 16;
            this.listBoxKoltuklar.Location = new System.Drawing.Point(20, 150);
            this.listBoxKoltuklar.Name = "listBoxKoltuklar";
            this.listBoxKoltuklar.Size = new System.Drawing.Size(200, 180);
            this.listBoxKoltuklar.TabIndex = 6;

            // Rezervasyon Yap Button
            this.btnRezervasyonYap.Location = new System.Drawing.Point(250, 150);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(200, 30);
            this.btnRezervasyonYap.TabIndex = 7;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTCKimlik);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.dateTimePickerUcusTarihi);
            this.Controls.Add(this.listBoxKoltuklar);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Name = "Form1";
            this.Text = "Uçak Bileti Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCKimlik;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.DateTimePicker dateTimePickerUcusTarihi;
        private System.Windows.Forms.ListBox listBoxKoltuklar;
        private System.Windows.Forms.Button btnRezervasyonYap;
    }
}
