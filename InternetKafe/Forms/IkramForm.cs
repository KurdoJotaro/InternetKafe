namespace InternetKafe;

public partial class IkramForm : Form
{
    private readonly KafeYonetici _yonetici;

    public IkramForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
        _yonetici = yonetici;
    }

    private void CombolariDoldur()
    {
        cmbToptanci.Items.Clear();
        foreach (var t in _yonetici.Toptancilar)
            cmbToptanci.Items.Add(t);

        if (cmbToptanci.Items.Count > 0) cmbToptanci.SelectedIndex = 0;

        cmbIkramAlim.Items.Clear();
        foreach (var i in _yonetici.Ikramlar)
        {
            cmbIkramAlim.Items.Add(i);
        }

        if (cmbIkramAlim.Items.Count > 0) cmbIkramAlim.SelectedIndex = 0;
    }

    private void GridGuncelle()
    {
        // Otomatik boyutlandırmayı geçici olarak kapat
        var eskiMod = dgvIkramlar.AutoSizeColumnsMode;
        dgvIkramlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        dgvIkramlar.Rows.Clear();
        foreach (var i in _yonetici.Ikramlar)
        {
            int rowIndex = dgvIkramlar.Rows.Add(i.Ad, i.Fiyat.ToString("C2"), i.StokMiktari);
            dgvIkramlar.Rows[rowIndex].Tag = i;
        }

        // Veriler eklendikten sonra eski moda geri döndür
        dgvIkramlar.AutoSizeColumnsMode = eskiMod;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (GirisDogrulama.BosVeyaSadeceRakam(txtAd.Text))
        {
            MessageBox.Show("Ürün adı boş bırakılamaz ve sadece rakamlardan oluşamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (numFiyat.Value <= 0)
        {
            MessageBox.Show("Ürün satış fiyatı 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var ikram = new Ikram
            {
                Ad = txtAd.Text.Trim(),
                Fiyat = numFiyat.Value,
                StokMiktari = 0
            };

            _yonetici.IkramEkle(ikram);
            CombolariDoldur();
            GridGuncelle();
            txtAd.Clear();
            numFiyat.Value = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnStokAl_Click(object sender, EventArgs e)
    {
        if (cmbToptanci.SelectedItem == null || cmbIkramAlim.SelectedItem == null)
        {
            MessageBox.Show("Toptancı ve ürün seçilmeli.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var toptanci = (Toptanci)cmbToptanci.SelectedItem;
        var ikram = (Ikram)cmbIkramAlim.SelectedItem;
        int adet = (int)numAlimAdet.Value;
        decimal fiyat = numAlimFiyati.Value;

        if (fiyat <= 0)
        {
            MessageBox.Show("Alış fiyatı 0'dan büyük olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            _yonetici.StokAlimi(ikram, toptanci, adet, fiyat);
            GridGuncelle();
            MessageBox.Show("Stok alımı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();// Üst paneldeki bilgileri güncelle.
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        var ikram = SeciliIkramGetir();
        if (ikram == null)
        {
            MessageBox.Show("Silinecek ürünü listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var sonuc = MessageBox.Show(
            $"{ikram.Ad} ürününü silmek istiyor musunuz?",
            "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (sonuc != DialogResult.Yes) return;

        try
        {
            _yonetici.IkramSil(ikram);
            CombolariDoldur();
            GridGuncelle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private Ikram? SeciliIkramGetir()
    {
        if (dgvIkramlar.SelectedRows.Count == 0) return null;
        return dgvIkramlar.SelectedRows[0].Tag as Ikram;
    }

    private void IkramForm_Load(object sender, EventArgs e)
    {
        CombolariDoldur();
        GridGuncelle();
    }
}
