using System;
using EvOtomasyonu;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- API TEST PROGRAMI ---");

        EvOtomasyonu.AirConditionerSystemConnection klima = new EvOtomasyonu.AirConditionerSystemConnection();


        klima.SetComPort(1);
        klima.SetBaudRate(9600);

        Console.WriteLine("Bağlantı deneniyor...");
        if (klima.Open())
        {
            Console.WriteLine("BAŞARILI: Port açıldı.");

            Console.WriteLine("Sıcaklık 25.5 olarak ayarlanıyor...");

            bool sonuc = klima.setDesiredTemp(25.5f);

            if (sonuc) Console.WriteLine("BAŞARILI: Veri gönderildi.");
            else Console.WriteLine("HATA: Veri gönderilemedi.");

            klima.Close();
        }
        else
        {
            Console.WriteLine("HATA: Port açılamadı");
        }

        Console.ReadLine();
    }
}