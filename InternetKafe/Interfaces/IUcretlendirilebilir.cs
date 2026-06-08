namespace InternetKafe;

public interface IUcretlendirilebilir
{
    decimal SaatlikUcret { get; set; }
    decimal ToplamUcretHesapla(int dakika);
    string UcretBilgisi();
}