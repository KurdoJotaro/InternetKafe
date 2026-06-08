namespace InternetKafe;

public class Oturum : IUcretlendirilebilir
{
    private int _kullanilanDakika;

    public Musteri Musteri { get; set; } = null!;
    public Bilgisayar Bilgisayar { get; set; } = null!;
    public DateTime BaslangicZamani { get; set; }

    public int KullanilanDakika
    {
        get => _kullanilanDakika;
        set
        {
            if (value < 30)
                _kullanilanDakika = 30; // Minimum 30 dakika kuralı
            else
                _kullanilanDakika = value;
        }
    }

    public decimal IkramTutari { get; set; }

    public decimal SaatlikUcret
    {
        get => Bilgisayar?.SaatlikUcret ?? 0;
        set { }
    }

    public decimal ToplamTutar
    {
        get
        {
            decimal pcUcret = ToplamUcretHesapla(KullanilanDakika);
            decimal indirim = pcUcret * (Musteri?.IndirimOrani ?? 0);
            return pcUcret - indirim + IkramTutari;
        }
    }

    public decimal ToplamUcretHesapla(int dakika)
    {
        return SaatlikUcret * dakika / 60m;
    }

    public string UcretBilgisi()
    {
        return $"{Musteri?.Ad} - PC-{Bilgisayar?.Numara} | {ToplamTutar:C2}";
    }

    public bool AktifMi { get; set; }

    public override string ToString()
    {
        string durum = AktifMi ? "AKTİF" : "Kapandı";
        return $"[{durum}] {Musteri?.Ad} → PC-{Bilgisayar?.Numara} ({BaslangicZamani:HH:mm})";
    }
}   