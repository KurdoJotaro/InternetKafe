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
}
