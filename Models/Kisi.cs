using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetKafe;

public abstract class Kisi
{
    private int _yas;

    public string Ad { get; set; } = string.Empty;

    public int Yas
    {
        get => _yas;
        set
        {
            if (value < 18)
                throw new ArgumentException("Yaş 18'den küçük olamaz. Thats illegal bro...");
            _yas = value;
        }
    }

    public abstract string BilgiGetir();
}