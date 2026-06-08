namespace InternetKafe;

public class Toptanci : Kisi
{
    public string FirmaAdi { get; set; } = string.Empty;
    public string VergiNo { get; set; } = string.Empty;

    public override string BilgiGetir()
    {
        return $"Toptancı: {Ad}, Firma: {FirmaAdi}, Vergi No: {VergiNo}";
    }

    public override string ToString() => $"{Ad} ({FirmaAdi})";
}