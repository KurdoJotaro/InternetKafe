using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetKafe;

public class Musteri : Kisi
{
    public decimal ToplamHarcama { get; set; }
    public bool UyelikVar { get; set; }

    public decimal IndirimOrani
    {
        get
        {
            if (!UyelikVar) return 0;
            if (ToplamHarcama >= 500) return 0.15m;
            if (ToplamHarcama >= 200) return 0.10m;
            return 0.05m;
        }
    }

    public override string BilgiGetir()
    {
        return $"Müşteri: {Ad}, Yaş: {Yas}, Üyelik: {(UyelikVar ? "Var" : "Yok")}, " +
               $"Toplam Harcama: {ToplamHarcama:C2}, İndirim: %{IndirimOrani * 100}";
    }

    public override string ToString()
    {
        return $"{Ad} ({Yas})";
    }
}
