namespace InternetKafe;

public class KafeVerisi
{
    public List<Musteri> Musteriler { get; set; } = new();
    public List<Bilgisayar> Bilgisayarlar { get; set; } = new();
    public List<Oturum> Oturumlar { get; set; } = new();
    public List<GelirGider> Islemler { get; set; } = new();
    public List<Ikram> Ikramlar { get; set; } = new();
    public List<Toptanci> Toptancilar { get; set; } = new();
}