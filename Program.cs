namespace InternetKafe;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var yonetici = new KafeYonetici();

        yonetici.MusteriEkle(new Musteri { Ad = "Ahmett Yýlmazz", Yas = 22, UyelikVar = true });
        yonetici.MusteriEkle(new Musteri { Ad = "Mehmet Kaya", Yas = 19, UyelikVar = false });

        Application.Run(new AnaForm(yonetici));
    }
}