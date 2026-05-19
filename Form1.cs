using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CeviriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Dilleri tutmak için basit bir sınıf
        public class DilModeli
        {
            public string Ad { get; set; }
            public string Kod { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Verim odaklı olması için en çok kullanılan dilleri varsayılan olarak ekliyoruz.
            // API'den de çekilebilir ancak hız için statik liste masaüstünde daha iyi bir UX sunar.
            List<DilModeli> diller = new List<DilModeli>
            {
                new DilModeli { Ad = "İngilizce", Kod = "en" },
                new DilModeli { Ad = "Türkçe", Kod = "tr" },
                new DilModeli { Ad = "Almanca", Kod = "de" },
                new DilModeli { Ad = "Fransızca", Kod = "fr" },
                new DilModeli { Ad = "İspanyolca", Kod = "es" },
                new DilModeli { Ad = "İtalyanca", Kod = "it" },
                new DilModeli { Ad = "Rusça", Kod = "ru" },
                new DilModeli { Ad = "Arapça", Kod = "ar" }
            };

            // Kaynak dil ComboBox ayarları
            cmbKaynakDil.DataSource = new List<DilModeli>(diller);
            cmbKaynakDil.DisplayMember = "Ad";
            cmbKaynakDil.ValueMember = "Kod";
            cmbKaynakDil.SelectedIndex = 0; // Varsayılan: İngilizce

            // Hedef dil ComboBox ayarları
            cmbHedefDil.DataSource = new List<DilModeli>(diller);
            cmbHedefDil.DisplayMember = "Ad";
            cmbHedefDil.ValueMember = "Kod";
            cmbHedefDil.SelectedIndex = 1; // Varsayılan: Türkçe
        }

        private async void btnCevir_Click(object sender, EventArgs e)
        {
            string kaynakMetin = txtKaynak.Text.Trim();

            if (string.IsNullOrWhiteSpace(kaynakMetin))
            {
                MessageBox.Show("Lütfen çevrilecek bir metin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kaynakKod = cmbKaynakDil.SelectedValue.ToString();
            string hedefKod = cmbHedefDil.SelectedValue.ToString();

            if (kaynakKod == hedefKod)
            {
                txtHedef.Text = kaynakMetin; // Aynı dil seçiliyse API'yi yormaya gerek yok
                return;
            }

            // UI'ı işlem bitene kadar kilitliyoruz
            btnCevir.Enabled = false;
            btnCevir.Text = "Çevriliyor...";
            lblDurum.Text = "API ile iletişim kuruluyor...";
            lblDurum.ForeColor = System.Drawing.Color.DarkOrange;

            string sonuc = await CeviriYapAsync(kaynakMetin, kaynakKod, hedefKod);

            txtHedef.Text = sonuc;

            // UI'ı eski haline getiriyoruz
            btnCevir.Enabled = true;
            btnCevir.Text = "Çevir";
            lblDurum.Text = "Çeviri tamamlandı.";
            lblDurum.ForeColor = System.Drawing.Color.Green;
        }

        private async Task<string> CeviriYapAsync(string metin, string kaynakDil, string hedefDil)
        {
            // MyMemory API, metni ve dilleri doğrudan URL üzerinden (GET parametresi olarak) alır.
            // Örnek: langpair=en|tr
            string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(metin)}&langpair={kaynakDil}|{hedefDil}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // LibreTranslate gibi POST değil, basit bir GET isteği atıyoruz.
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // API'den dönen metni okuyoruz
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // JObject ile JSON'ı parçalıyoruz
                        JObject data = JObject.Parse(jsonResponse);

                        // MyMemory API, sonucu "responseData" içindeki "translatedText" alanında döndürür
                        return data["responseData"]?["translatedText"]?.ToString() ?? "Sonuç alınamadı.";
                    }
                    else
                    {
                        return $"Sunucu Hatası: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Bağlantı Hatası:\n{ex.Message}";
                }
            }
        }


    }
}