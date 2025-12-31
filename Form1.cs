using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvOtomasyonu
{
    public partial class Form1 : Form
    {
        // Değişkenler
        int mevcutSicaklik = 22;
        int istenenSicaklik = 22;
        int perdeYuzdesi = 65;

        // Bağlantı Sınıfları
        AirConditionerSystemConnection klimaSistemi = new AirConditionerSystemConnection();
        CurtainControlSystemConnection perdeSistemi = new CurtainControlSystemConnection();

        // Verileri sürekli okumak için Timer
        Timer sistemZamanlayici = new Timer();

        public Form1()
        {
            InitializeComponent();

            // --- 2. ZAMANLAYICI (TIMER) KURULUMU ---
            sistemZamanlayici.Interval = 1000; // 1 saniye
            sistemZamanlayici.Tick += new EventHandler(SistemZamanlayici_Tick);

            // Tab Menü Geçişleri
            this.btnKlima.Click += (s, e) => mainTabControl.SelectedIndex = 0;
            this.btnPerde.Click += (s, e) => mainTabControl.SelectedIndex = 1;
            this.btnAyarlar.Click += (s, e) => mainTabControl.SelectedIndex = 2;
            this.btnCikisYap.Click += (s, e) => Application.Exit();

            // Perde Trackbar Olayı
            this.trackBarPerde.Scroll += (s, e) => {
                perdeYuzdesi = trackBarPerde.Value;
                lblPerdeYuzde.Text = perdeYuzdesi + "%";
         
                lblCurtainStatus.Text = "Curtain Status: " + perdeYuzdesi + " %";
            };

            this.btnSicaklikArttir.Click += new EventHandler(btnSicaklikArttir_Click);
            this.btnSicaklikAzalt.Click += new EventHandler(btnSicaklikAzalt_Click);

       
            mainTabControl.SelectedIndex = 0;
            btnKlima.Checked = true;
            GuncelleKlimaEkrani();
        }

        // 3. SÜREKLİ GÜNCELLEME (MONİTÖR) FONKSİYONU 
        private void SistemZamanlayici_Tick(object sender, EventArgs e)
        {
            // A) Verileri API'den çek (Update komutu yolla)
           
            if (klimaSistemi.Open())
                klimaSistemi.update(); 

            if (perdeSistemi.Open())
                perdeSistemi.update();

            // B) Klima Ekranındaki Bilgileri Yazdır
             lblHomeAmbient.Text = "Home Ambient Temp: " + klimaSistemi.getAmbientTemp().ToString("0.0") + " °C";
            lblHomeDesired.Text = "Home Desired Temp: " + klimaSistemi.getDesiredTemp().ToString("0.0") + " °C";
            lblFanSpeed.Text = "Fan Speed: " + klimaSistemi.getFanSpeed() + " rps";

            // C) Perde Ekranındaki Bilgileri Yazdır
            lblOutdoorTemp.Text = "Outdoor Temp: " + perdeSistemi.getOutdoorTemp().ToString("0.0") + " °C";
            lblOutdoorPressure.Text = "Outdoor Pressure: " + perdeSistemi.getOutdoorPress().ToString("0.0") + " hPa";
            lblLightIntensity.Text = "Light Intensity: " + perdeSistemi.getLightIntensity().ToString("0.0") + " Lux";

            lblCurtainStatus.Text = "Curtain Status: " + perdeSistemi.curtainStatus + " %";
        }

        // --- 4. BAĞLAN BUTONU MANTIĞI ---
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (cmbPort.SelectedIndex > -1)
            {
                string secilenPort = cmbPort.SelectedItem.ToString();
                int baudRate = int.Parse(cmbBaud.SelectedItem.ToString());

                // COM1 -> 1 dönüşümü
                int portNum = int.Parse(secilenPort.Replace("COM", ""));

                klimaSistemi.SetComPort(portNum);
                klimaSistemi.SetBaudRate(baudRate);

                perdeSistemi.SetComPort(portNum);
                perdeSistemi.SetBaudRate(baudRate);

                try
                {
                    if (klimaSistemi.Open())
                    {
                        lblBaglantiDurumu.Text = "BAĞLANDI";
                        lblBaglantiDurumu.ForeColor = Color.LightGreen;
                        sistemZamanlayici.Start(); // Veri akışını başlat!
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir COM portu seçiniz.");
            }
        }

        // --- 5. BAĞLANTIYI KES ---
        private void btnBaglantiyiKes_Click(object sender, EventArgs e)
        {
            sistemZamanlayici.Stop(); 
            klimaSistemi.Close();
            perdeSistemi.Close();
            lblBaglantiDurumu.Text = "Bağlı Değil";
            lblBaglantiDurumu.ForeColor = Color.IndianRed;
        }

        private void GuncelleKlimaEkrani()
        {
            
            lblDerece.Text = istenenSicaklik + "°C";
            lblHomeDesired.Text = "Home Desired Temp: " + istenenSicaklik + ".0 °C";

            int progressVal = istenenSicaklik * 2;
            if (progressVal > 100) progressVal = 100;
            if (progressVal < 0) progressVal = 0;
            progressTermostat.Value = progressVal;
        }

        // --- 6. SICAKLIK ARTTIRMA ---
        
        private void btnSicaklikArttir_Click(object sender, EventArgs e)
        {
            
            int yeniHedef = istenenSicaklik + 1;

           
            try
            {
                // KONTROL [R2.1.2-3]: 50'den büyük olamaz
                if (yeniHedef <= 50)
                {
                    
                    istenenSicaklik = yeniHedef;

                    
                    klimaSistemi.setDesiredTemp((float)istenenSicaklik);

                    
                    GuncelleKlimaEkrani();
                }
                else
                {
                    MessageBox.Show("Sıcaklık 50°C'den yüksek olamaz!");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen önce sisteme bağlanın!");
            }
        }

        // --- 7. SICAKLIK AZALTMA ---
        private void btnSicaklikAzalt_Click(object sender, EventArgs e)
        {
           
            
            int yeniHedef = istenenSicaklik - 1;

            try
            {
                // KONTROL: 10'dan küçük olamaz
                if (yeniHedef >= 10)
                {
                    
                    istenenSicaklik = yeniHedef;

                    
                    klimaSistemi.setDesiredTemp((float)istenenSicaklik);

                    
                    GuncelleKlimaEkrani();
                }
                else
                {
                    MessageBox.Show("Sıcaklık 10°C'den düşük olamaz!");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen önce sisteme bağlanın!");
            }
        }

        // --- 8. PERDE AYARLAMA (Set Butonu varsa) ---
        private void btnPerdeAyarla_Click(object sender, EventArgs e)
        {
            
            perdeSistemi.setCurtainStatus((float)perdeYuzdesi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                cmbPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                if (cmbPort.Items.Count > 0) cmbPort.SelectedIndex = 0;
            }
            catch { }
        }
    }
}