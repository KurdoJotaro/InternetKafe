namespace InternetKafe;

public class Ikram
{
    private int _stokMiktari;

    public string Ad { get; set; } = string.Empty;
    public decimal Fiyat { get; set; }

    public int StokMiktari
    {
        get => _stokMiktari;
        set
        {
            if (value < 0)
                throw new ArgumentException("Stok miktarı negatif olamaz.");
            _stokMiktari = value;
        }
    }

    public override string ToString() => $"{Ad} ({Fiyat:C2}) - Stok: {StokMiktari}";
}