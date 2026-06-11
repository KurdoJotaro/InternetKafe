using System.Globalization;
namespace InternetKafe;

static class Program
{
    [STAThread]
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

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
