namespace InternetKafe;

public partial class KasaForm : Form
{
    private readonly KafeYonetici _yonetici;

    public KasaForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
        _yonetici = yonetici;
    }

    private void KasaForm_Load(object sender, EventArgs e)
    {
        ListeyiDoldur();
        FinansalDurumGuncelle();
    }

    private void ListeyiDoldur()
    {
        lstIslemler.Items.Clear();
        // İşlemleri kronolojik sırayla listelemek için döngüye alıyoruz
        foreach (var islem in _yonetici.Islemler)
        {
            lstIslemler.Items.Add(islem);
        }
    }

    private void FinansalDurumGuncelle()
    {
        decimal gelir = _yonetici.ToplamGelir();
        decimal gider = _yonetici.ToplamGider();
        decimal netKar = _yonetici.NetKar();

        lblToplamGelir.Text = $"Toplam Gelir: {gelir:C2}";
        lblToplamGider.Text = $"Toplam Gider: {gider:C2}";
        lblNetKar.Text = $"Net Kar: {netKar:C2}";
    }

    private void btnTamReset_Click(object sender, EventArgs e)
    {
        var sonuc = MessageBox.Show(
            "Program hazır örnek verilere dönecek. Sonradan eklenen müşteriler, bilgisayarlar, oturumlar, stok hareketleri ve kasa kayıtları silinecek. Devam edilsin mi?",
            "Tam Reset Onayı",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (sonuc != DialogResult.Yes) return;

        try
        {
            _yonetici.VarsayilanVerileriYukle();
            DosyaIslemleri.VerileriKaydet(_yonetici.VerileriDisaAktar());
            ListeyiDoldur();
            FinansalDurumGuncelle();
            (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();
            MessageBox.Show("Program hazır örnek verilere döndürüldü.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Reset sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
