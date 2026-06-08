namespace InternetKafe;

public class Bilgisayar : IUcretlendirilebilir
{
    private int _islemciPuani;
    private int _ekranKartiPuani;

    public int Numara { get; set; }
    public int RamGB { get; set; }

    public int IslemciPuani
    {
        get => _islemciPuani;
        set
        {
            if (value < 1 || value > 4)
                throw new ArgumentException("İşlemci puanı 1-4 arası olmalı.");
            _islemciPuani = value;
        }
    }

    public int EkranKartiPuani
    {
        get => _ekranKartiPuani;
        set
        {
            if (value < 1 || value > 4)
                throw new ArgumentException("Ekran kartı puanı 1-4 arası olmalı.");
            _ekranKartiPuani = value;
        }
    }

    public bool DoluMu { get; set; }

    public int PerformansPuani => (RamGB / 8) + IslemciPuani + EkranKartiPuani;

    public string Kategori
    {
        get
        {
            if (PerformansPuani >= 8) return "Turnuva";
            if (PerformansPuani >= 5) return "VIP";
            return "Standart";
        }
    }

    public decimal SaatlikUcret
    {
        get
        {
            return Kategori switch
            {
                "Turnuva" => 30m,
                "VIP" => 20m,
                _ => 10m
            };
        }
        set { } // interface gereği bulunmak zorunda
    }

    public decimal ToplamUcretHesapla(int dakika)
    {
        return SaatlikUcret * dakika / 60m;
    }

    public string UcretBilgisi()
    {
        return $"PC-{Numara} ({Kategori}) - {SaatlikUcret:C2}/saat";
    }

    public override string ToString() => $"PC-{Numara} ({Kategori})";
}