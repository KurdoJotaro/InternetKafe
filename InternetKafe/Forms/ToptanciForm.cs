namespace InternetKafe;

public partial class ToptanciForm : Form
{
    private readonly KafeYonetici _yonetici;

    public ToptanciForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
        _yonetici = yonetici;
    }

    private void GridGuncelle()
    {
        // Otomatik boyutlandırmayı geçici olarak kapat
        var eskiMod = dgvToptancilar.AutoSizeColumnsMode;
        dgvToptancilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        dgvToptancilar.Rows.Clear();
        foreach (var t in _yonetici.Toptancilar)
        {
            dgvToptancilar.Rows.Add(t.Ad, t.FirmaAdi, t.VergiNo);
        }

        // Veriler eklendikten sonra eski moda geri döndür
        dgvToptancilar.AutoSizeColumnsMode = eskiMod;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtFirmaAdi.Text))
        {
            MessageBox.Show("Ad ve Firma Adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var toptanci = new Toptanci
            {
                Ad = txtAd.Text,
                Yas = 18,
                FirmaAdi = txtFirmaAdi.Text,
                VergiNo = txtVergiNo.Text
            };

            _yonetici.ToptanciEkle(toptanci);
            GridGuncelle();
            FormuTemizle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FormuTemizle()
    {
        txtAd.Clear();
        txtFirmaAdi.Clear();
        txtVergiNo.Clear();
    }

    private void ToptanciForm_Load(object sender, EventArgs e)
    {
        GridGuncelle();
    }
}
