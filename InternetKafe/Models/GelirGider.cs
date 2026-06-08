namespace InternetKafe;

public class GelirGider
{
    public string Aciklama { get; set; } = string.Empty;
    public decimal Tutar { get; set; }
    public bool GelirMi { get; set; }
    public DateTime Tarih { get; set; }

    public override string ToString()
    {
        return $"{Tarih:dd.MM.yyyy HH:mm} | {(GelirMi ? "GELİR" : "GİDER")} | {Aciklama} | {Tutar:C2}";
    }
}