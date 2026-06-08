namespace InternetKafe;

public partial class AnaForm : Form
{
    private readonly KafeYonetici _yonetici;

    public AnaForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        _yonetici = yonetici;
    }

    private void AnaForm_Load(object sender, EventArgs e)
    {
        DashboardGuncelle();
    }

    private void DashboardGuncelle()
    {
        lblMusteriSayisi.Text = $"Müşteri Sayısı: {_yonetici.Musteriler.Count}";
        lblToplamPC.Text = $"Toplam PC: {_yonetici.Bilgisayarlar.Count}";
        lblBosPC.Text = $"Boş PC: {_yonetici.BosBilgisayarSayisi()}";

        // Yeni eklenen alanlar
        lblAktifOturum.Text = $"Aktif Oturum: {_yonetici.AktifOturumSayisi()}";
        lblBugunkuGelir.Text = $"Bugünkü Gelir: {_yonetici.BugunkuGelir():C2}";
    }

    private void btnMusteriler_Click(object sender, EventArgs e)
    {
        using var form = new MusteriYonetimForm(_yonetici);
        form.ShowDialog();
        DashboardGuncelle();
    }

    private void btnBilgisayarlar_Click(object sender, EventArgs e)
    {
        using var form = new BilgisayarYonetimForm(_yonetici);
        form.ShowDialog();
        DashboardGuncelle();
    }

    private void btnOturumlar_Click(object sender, EventArgs e)
    {
        using var form = new OturumForm(_yonetici);
        form.ShowDialog();
        DashboardGuncelle();
    }
    private void btnToptancilar_Click(object sender, EventArgs e)
    {
        using var form = new ToptanciForm(_yonetici);
        form.ShowDialog();
        DashboardGuncelle();
    }

    private void btnIkramlar_Click(object sender, EventArgs e)
    {
        using var form = new IkramForm(_yonetici);
        form.ShowDialog();
        DashboardGuncelle();
    }
}