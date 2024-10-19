using System;
using System.Collections.Generic;
using System.Drawing; // Color için
using System.Windows.Forms;

namespace Ucak_bilet_Rez_AI
{
    public partial class Form1 : Form
    {
        // Koltuk durumu için Dictionary
        Dictionary<int, bool> koltuklar = new Dictionary<int, bool>();

        public Form1()
        {
            InitializeComponent();
            // Yer tutucu (Placeholder) ekleme
            AddPlaceholders();
        }

        // Form yüklendiğinde çalışacak
        private void Form1_Load(object sender, EventArgs e)
        {
            // Koltukları başlat (1'den 30'a kadar tüm koltuklar boş)
            for (int i = 1; i <= 30; i++)
            {
                koltuklar.Add(i, true); // Başlangıçta tüm koltuklar boş
                listBoxKoltuklar.Items.Add($"Koltuk {i} (Boş)");
            }
        }

        // Rezervasyon yap butonuna tıklandığında çalışacak
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            // Girdi kontrolleri (Boş giriş varsa hata ver)
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTCKimlik.Text == "" || cmbNereden.SelectedItem == null || cmbNereye.SelectedItem == null || listBoxKoltuklar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun ve bir koltuk seçin.");
                return;
            }

            // Kullanıcı bilgilerini al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tcKimlik = txtTCKimlik.Text;
            string nereden = cmbNereden.SelectedItem.ToString();
            string nereye = cmbNereye.SelectedItem.ToString();
            DateTime ucusTarihi = dateTimePickerUcusTarihi.Value;

            // Seçilen koltuk numarasını al
            int seciliKoltuk = listBoxKoltuklar.SelectedIndex + 1;

            // Koltuk dolu mu kontrolü
            if (koltuklar[seciliKoltuk])
            {
                // Rezervasyonu kaydet ve koltuğu dolu olarak işaretle
                koltuklar[seciliKoltuk] = false;
                MessageBox.Show($"{ad} {soyad}, rezervasyonunuz başarıyla tamamlandı. Koltuk Numaranız: {seciliKoltuk}");

                // ListBox'taki koltuğun durumunu güncelle
                listBoxKoltuklar.Items[seciliKoltuk - 1] = $"Koltuk {seciliKoltuk} (Dolu)";
            }
            else
            {
                // Eğer koltuk doluysa kullanıcıyı bilgilendir
                MessageBox.Show("Seçilen koltuk dolu! Lütfen başka bir koltuk seçin.");
            }
        }

        // Yer tutucu (placeholder) eklemek için metot
        private void AddPlaceholders()
        {
            // Ad TextBox Placeholder
            txtAd.ForeColor = Color.Gray;
            txtAd.Text = "Ad";
            txtAd.Enter += RemovePlaceholder;
            txtAd.Leave += SetPlaceholder;

            // Soyad TextBox Placeholder
            txtSoyad.ForeColor = Color.Gray;
            txtSoyad.Text = "Soyad";
            txtSoyad.Enter += RemovePlaceholder;
            txtSoyad.Leave += SetPlaceholder;

            // TC Kimlik TextBox Placeholder
            txtTCKimlik.ForeColor = Color.Gray;
            txtTCKimlik.Text = "TC Kimlik No";
            txtTCKimlik.Enter += RemovePlaceholder;
            txtTCKimlik.Leave += SetPlaceholder;
        }

        // TextBox üzerine tıklandığında placeholder silinir
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        // TextBox'tan çıkıldığında placeholder eklenir
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
