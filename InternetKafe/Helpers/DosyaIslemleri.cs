using System.Text.Json;
using System.Text.Json.Serialization;

namespace InternetKafe;

public static class DosyaIslemleri
{
    private const string DosyaYolu = "kafe_verileri.json";

    // Nesne referanslarını korumak (ReferenceHandler.Preserve) çok önemlidir, 
    // aksi takdirde Oturum'daki Müşteri ile Ana listedeki Müşteri farklı nesneler olarak algılanır.
    private static readonly JsonSerializerOptions Options = new()
    {
        ReferenceHandler = ReferenceHandler.Preserve,
        WriteIndented = true
    };

    public static void VerileriKaydet(KafeVerisi veri)
    {
        string json = JsonSerializer.Serialize(veri, Options);
        File.WriteAllText(DosyaYolu, json);
    }

    public static KafeVerisi? VerileriYukle()
    {
        if (!File.Exists(DosyaYolu)) return null;

        string json = File.ReadAllText(DosyaYolu);
        return JsonSerializer.Deserialize<KafeVerisi>(json, Options);
    }
}