namespace InternetKafe;

public partial class IkramForm : Form
{
    private readonly KafeYonetici _yonetici;

    public IkramForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        _yonetici = yonetici;
    }

    private void CombolariDoldur()
    {
        cmbToptanci.Items.Clear();
        foreach (var t in _yonetici.Toptancilar)
            cmbToptanci.Items.Add(t);

        if (cmbToptanci.Items.Count > 0) cmbToptanci.SelectedIndex = 0;

        cmbIkramAlim.Items.Clear();
        cmbIkramSatis.Items.Clear();
        foreach (var i in _yonetici.Ikramlar)
        {
            cmbIkramAlim.Items.Add(i);
            cmbIkramSatis.Items.Add(i);
        }

        if (cmbIkramAlim.Items.Count > 0) cmbIkramAlim.SelectedIndex = 0;
        if (cmbIkramSatis.Items.Count > 0) cmbIkramSatis.SelectedIndex = 0;
    }

    private void GridGuncelle()
    {
        // Otomatik boyutlandırmayı geçici olarak kapat
        var eskiMod = dgvIkramlar.AutoSizeColumnsMode;
        dgvIkramlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

        dgvIkramlar.Rows.Clear();
        foreach (var i in _yonetici.Ikramlar)
        {
            dgvIkramlar.Rows.Add(i.Ad, i.Fiyat.ToString("C2"), i.StokMiktari);
        }

        // Veriler eklendikten sonra eski moda geri döndür
        dgvIkramlar.AutoSizeColumnsMode = eskiMod;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAd.Text))
        {
            MessageBox.Show("Ürün adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var ikram = new Ikram
        {
            Ad = txtAd.Text,
            Fiyat = numFiyat.Value,
            StokMiktari = 0 // Yeni eklenen ürünün stoku başlangıçta 0'dır
        };

        _yonetici.IkramEkle(ikram);
        CombolariDoldur();
        GridGuncelle();
        txtAd.Clear();
        numFiyat.Value = 0;
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
    }

    private void btnSat_Click(object sender, EventArgs e)
    {
        if (cmbIkramSatis.SelectedItem == null)
        {
            MessageBox.Show("Satılacak ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var ikram = (Ikram)cmbIkramSatis.SelectedItem;
        int adet = (int)numSatisAdet.Value;

        try
        {
            _yonetici.IkramSatis(ikram, adet);
            GridGuncelle();
            MessageBox.Show("Satış yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void IkramForm_Load(object sender, EventArgs e)
    {
        CombolariDoldur();
        GridGuncelle();
    }
}