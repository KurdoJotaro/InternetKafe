namespace InternetKafe;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var yonetici = new KafeYonetici();

        // Örnek müþteriler
        yonetici.MusteriEkle(new Musteri { Ad = "Ahmet Yýlmaz", Yas = 22, UyelikVar = true });
        yonetici.MusteriEkle(new Musteri { Ad = "Mehmet Kaya", Yas = 19, UyelikVar = false });

        // Örnek bilgisayarlar
        yonetici.BilgisayarEkle(new Bilgisayar { Numara = 1, RamGB = 8, IslemciPuani = 2, EkranKartiPuani = 2 });
        yonetici.BilgisayarEkle(new Bilgisayar { Numara = 2, RamGB = 16, IslemciPuani = 3, EkranKartiPuani = 3 });
        yonetici.BilgisayarEkle(new Bilgisayar { Numara = 3, RamGB = 32, IslemciPuani = 4, EkranKartiPuani = 4 });


        // Örnek Toptancý ve Ýkram
        yonetici.ToptanciEkle(new Toptanci { Ad = "Ahmet Toptan", Yas = 45, FirmaAdi = "Ahmet Gýda", VergiNo = "1234567890" });
        var kola = new Ikram { Ad = "Kutu Kola", Fiyat = 25m, StokMiktari = 50 };
        yonetici.IkramEkle(kola);

        Application.Run(new AnaForm(yonetici));
    }
}