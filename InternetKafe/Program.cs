namespace InternetKafe;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var yonetici = new KafeYonetici();
        var eskiVeri = DosyaIslemleri.VerileriYukle();

        if (eskiVeri != null)
        {
            yonetici.VerileriIceAktar(eskiVeri);
        }
        else
        {
            yonetici.VarsayilanVerileriYukle();
        }

        Application.Run(new AnaForm(yonetici));
    }
}
