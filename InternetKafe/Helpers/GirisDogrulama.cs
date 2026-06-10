namespace InternetKafe;

public static class GirisDogrulama
{
    public static bool BosVeyaSadeceRakam(string deger)
    {
        string temizDeger = deger.Trim();
        return string.IsNullOrWhiteSpace(temizDeger) || temizDeger.All(char.IsDigit);
    }

    public static bool SadeceRakam(string deger)
    {
        string temizDeger = deger.Trim();
        return !string.IsNullOrWhiteSpace(temizDeger) && temizDeger.All(char.IsDigit);
    }

    public static void SadeceRakamKeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }
}
