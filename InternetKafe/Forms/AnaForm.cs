namespace InternetKafe;

public partial class AnaForm : Form
{
    private readonly KafeYonetici _yonetici;
    private Form? _aktifAltForm = null;

    public AnaForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        _yonetici = yonetici;
    }

    private void AnaForm_Load(object sender, EventArgs e)
    {
        DashboardGuncelle();
        MenuyuVurgula(btnKasaRapor);
        FormuPaneleGetir(new KasaForm(_yonetici));
    }

    // Alt formlardan da erişilip anlık güncellenebilmesi için 'public' yapıldı
    public void DashboardGuncelle()
    {
        lblMusteriSayisi.Text = $"Müşteri Sayısı: {_yonetici.Musteriler.Count}";
        lblToplamPC.Text = $"Toplam PC: {_yonetici.Bilgisayarlar.Count}";
        lblBosPC.Text = $"Boş PC: {_yonetici.BosBilgisayarSayisi()}";

        lblAktifOturum.Text = $"Aktif Oturum: {_yonetici.AktifOturumSayisi()}";
        lblBugunkuGelir.Text = $"Bugünkü Gelir: {_yonetici.BugunkuGelir():C2}";
    }

    private void FormuPaneleGetir(Form altForm)
    {
        // Eğer halihazırda açık bir alt form varsa kapat
        _aktifAltForm?.Close();
        _aktifAltForm = altForm;

        // Alt formun pencere özelliklerini kapat ve panele göm
        altForm.TopLevel = false;
        altForm.FormBorderStyle = FormBorderStyle.None;
        altForm.Dock = DockStyle.Fill;

        // Paneli temizle ve yeni formu ekle
        pnlIcerik.Controls.Clear();
        pnlIcerik.Controls.Add(altForm);
        altForm.Show();

        // Menü geçişlerinde üst paneli güncelle
        DashboardGuncelle();
    }
    private void MenuyuVurgula(Button aktifButon)
    {
        // Önce pnlMenu içindeki TableLayoutPanel'i bul ve içindeki tüm butonları varsayılan renge döndür
        foreach (Control ctrl in tableLayoutPanel1.Controls) // TableLayoutPanel ismin farklıysa burayı düzelt
        {
            if (ctrl is Button btn)
            {
                btn.BackColor = Color.Transparent; // Veya pnlMenu'nün kendi arka plan rengi (örn: Color.FromArgb(44, 62, 80))
                btn.ForeColor = Color.White;
            }
        }

        // Tıklanan butonu vurgula (Arkaplan beyaz, Yazı lacivert)
        aktifButon.BackColor = Color.White;
        aktifButon.ForeColor = Color.FromArgb(44, 62, 80); // Sol panelinin arka plan rengi neyse o kodu yaz
    }


    // Buton Click Olayları
    private void btnMusteriler_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new MusteriYonetimForm(_yonetici));
    }

    private void btnBilgisayarlar_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new BilgisayarYonetimForm(_yonetici));
    }

    private void btnOturumlar_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new OturumForm(_yonetici));
    }

    private void btnToptancilar_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new ToptanciForm(_yonetici));
    }

    private void btnIkramlar_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new IkramForm(_yonetici));
    }

    private void btnKasaRapor_Click(object sender, EventArgs e)
    {
        MenuyuVurgula((Button)sender);
        FormuPaneleGetir(new KasaForm(_yonetici));
    }

    private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            var güncelVeri = _yonetici.VerileriDisaAktar();
            DosyaIslemleri.VerileriKaydet(güncelVeri);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Veriler kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}