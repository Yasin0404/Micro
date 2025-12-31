using System;
using System.IO.Ports;
using System.Threading;

namespace EvOtomasyonu 
{
    // --- ANA BAĞLANTI SINIFI (PDF Şekil 17) ---
    public class HomeAutomationSystemConnection
    {
        protected SerialPort serialPort;
        public int comPort;
        public int baudRate;

        public HomeAutomationSystemConnection()
        {
            serialPort = new SerialPort();
        }

        public bool Open()
        {
            try
            {
                if (serialPort.IsOpen) serialPort.Close();

                serialPort.PortName = "COM" + comPort; 
                serialPort.BaudRate = baudRate;        
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;

                serialPort.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                return true;
            }
            return false;
        }

        public void SetComPort(int port) { this.comPort = port; }
        public void SetBaudRate(int rate) { this.baudRate = rate; }

        // Yardımcı Fonksiyon: Veri gönderip cevap bekleme
        protected int SendAndReceive(byte command)
        {
            if (!serialPort.IsOpen) return -1;
            try
            {
                byte[] buffer = { command };
                serialPort.Write(buffer, 0, 1);
                Thread.Sleep(50); // PIC cevabı için bekleme süresi
                if (serialPort.BytesToRead > 0) return serialPort.ReadByte();
                return -1;
            }
            catch { return -1; }
        }
    }

    // --- KLİMA SİSTEMİ SINIFI (PDF Şekil 17) ---
    public class AirConditionerSystemConnection : HomeAutomationSystemConnection
    {
        // Değişkenler (Fields)
        private float desiredTemperature;
        private float ambientTemperature;
        private int fanSpeed;

        public float GetAmbientTemp() { return ambientTemperature; }
        public float GetDesiredTemp() { return desiredTemperature; }
        public int GetFanSpeed() { return fanSpeed; }

        // Verileri PIC'ten Okuma Fonksiyonu
        public virtual void update()
        {
            if (serialPort == null || !serialPort.IsOpen) return;

            try
            {
                serialPort.ReadTimeout = 500;

                // --- 1. İstenen Sıcaklık (Ondalık Kısım) ---
                byte[] cmd = { 0b00000001 }; // PDF Tablo R2.1.4-1
                serialPort.Write(cmd, 0, 1);
                int frac = serialPort.ReadByte(); 

                // --- 2. İstenen Sıcaklık (Tam Kısım) ---
                cmd[0] = 0b00000010;
                serialPort.Write(cmd, 0, 1);
                int integral = serialPort.ReadByte();

                this.desiredTemperature = integral + (frac / 10.0f);

                // --- 3. Ortam Sıcaklığı (Benzer mantık) ---
                cmd[0] = 0b00000011; 
                serialPort.Write(cmd, 0, 1);
                int ambFrac = serialPort.ReadByte();

                cmd[0] = 0b00000100; 
                serialPort.Write(cmd, 0, 1);
                int ambInt = serialPort.ReadByte();

                this.ambientTemperature = ambInt + (ambFrac / 10.0f);

                // --- 4. Fan Hızı ---
                cmd[0] = 0b00000101;
                serialPort.Write(cmd, 0, 1);
                this.fanSpeed = serialPort.ReadByte();
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Board 1 cevap vermedi (Timeout).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        public bool setDesiredTemp(float temp)
        {
            if (serialPort == null || !serialPort.IsOpen) return false;


            int intPart = (int)temp;
            int fracPart = (int)((temp - intPart) * 10);

            try
            {
                byte cmdFrac = (byte)(0b10000000 | (fracPart & 0x3F));
                serialPort.Write(new byte[] { cmdFrac }, 0, 1);

                System.Threading.Thread.Sleep(50);
                byte cmdInt = (byte)(0b11000000 | (intPart & 0x3F));
                serialPort.Write(new byte[] { cmdInt }, 0, 1);

                return true;
            }
            catch { return false; }
        }

        public float getAmbientTemp() { return ambientTemperature; }
        public int getFanSpeed() { return fanSpeed; }
        public float getDesiredTemp() { return desiredTemperature; }
    }

    // --- PERDE SİSTEMİ SINIFI (PDF Şekil 17) ---
    public class CurtainControlSystemConnection : HomeAutomationSystemConnection
    {
        public float curtainStatus;
        private float outdoorTemperature;
        private float outdoorPressure;
        private double lightIntensity;

        public float GetOutdoorTemp() { return outdoorTemperature; }
        public float GetOutdoorPress() { return outdoorPressure; }
        public double GetLightIntensity() { return lightIntensity; }
        public float GetCurtainStatus() { return curtainStatus; }

        public virtual void update()
        {
            if (serialPort == null || !serialPort.IsOpen) return;

            try
            {
                serialPort.ReadTimeout = 500;

                // --- 1. Perde Durumu (İstenen) ---
                serialPort.Write(new byte[] { 0b00000001 }, 0, 1);
                int curFrac = serialPort.ReadByte();
                serialPort.Write(new byte[] { 0b00000010 }, 0, 1);
                int curInt = serialPort.ReadByte();

                this.curtainStatus = curInt + (curFrac / 10.0f);

                // --- 2. Dış Ortam Sıcaklığı ---
                serialPort.Write(new byte[] { 0b00000011 }, 0, 1);
                int outTempFrac = serialPort.ReadByte();
                serialPort.Write(new byte[] { 0b00000100 }, 0, 1);
                int outTempInt = serialPort.ReadByte();

                this.outdoorTemperature = outTempInt + (outTempFrac / 10.0f);

                // --- 3. Basınç (Pressure) ---
                serialPort.Write(new byte[] { 0b00000101 }, 0, 1); // Low Byte
                int pressLow = serialPort.ReadByte();
                serialPort.Write(new byte[] { 0b00000110 }, 0, 1); // High Byte
                int pressHigh = serialPort.ReadByte();

                this.outdoorPressure = pressHigh;

                // --- 4. Işık Şiddeti (Light Intensity) ---
                serialPort.Write(new byte[] { 0b00000111 }, 0, 1);
                int lightLow = serialPort.ReadByte();
                serialPort.Write(new byte[] { 0b00001000 }, 0, 1); 
                int lightHigh = serialPort.ReadByte();

                this.lightIntensity = (lightHigh * 256) + lightLow;
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Board 2 cevap vermedi.");
            }
            catch (Exception ex)
            {
                // Hata yönetimi
            }
        }

        public bool setCurtainStatus(float status)
        {
            if (serialPort == null || !serialPort.IsOpen) return false;

            int intPart = (int)status;
            int fracPart = (int)((status - intPart) * 10);

            try
            {
                byte cmdFrac = (byte)(0b10000000 | (fracPart & 0x3F));
                serialPort.Write(new byte[] { cmdFrac }, 0, 1);

                System.Threading.Thread.Sleep(50);

                byte cmdInt = (byte)(0b11000000 | (intPart & 0x3F));
                serialPort.Write(new byte[] { cmdInt }, 0, 1);

                return true;
            }
            catch { return false; }
        }

        public float getOutdoorTemp() { return outdoorTemperature; }
        public float getOutdoorPress() { return outdoorPressure; }
        public double getLightIntensity() { return lightIntensity; }
    }
}