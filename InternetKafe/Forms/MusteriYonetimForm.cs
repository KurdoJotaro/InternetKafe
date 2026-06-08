namespace InternetKafe;

public partial class MusteriYonetimForm : Form
{
    private readonly KafeYonetici _yonetici;

    public MusteriYonetimForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        _yonetici = yonetici;
    }

    private void MusteriYonetimForm_Load(object sender, EventArgs e)
    {
        GridGuncelle();
    }

    private void GridGuncelle()
    {
        dgvMusteriler.Rows.Clear();
        foreach (var m in _yonetici.Musteriler)
        {
            dgvMusteriler.Rows.Add(
                m.Ad,
                m.Yas,
                m.UyelikVar ? "Evet" : "Hayır",
                m.ToplamHarcama.ToString("C2"),
                $"%{m.IndirimOrani * 100:0}"
            );
        }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var musteri = new Musteri
            {
                Ad = txtAd.Text.Trim(),
                Yas = (int)numYas.Value,
                UyelikVar = chkUyelik.Checked
            };

            _yonetici.MusteriEkle(musteri);
            GridGuncelle();
            FormuTemizle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return;

        try
        {
            // Güncelleme işlemi artık senin tasarladığın mimariye uygun olarak index üzerinden yapılıyor.
            int index = dgvMusteriler.SelectedRows[0].Index;

            _yonetici.MusteriGuncelle(index, txtAd.Text.Trim(), (int)numYas.Value, chkUyelik.Checked);

            GridGuncelle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return;

        int index = dgvMusteriler.SelectedRows[0].Index;
        var musteri = _yonetici.Musteriler[index];

        var sonuc = MessageBox.Show("Bu müşteriyi silmek istiyor musunuz?", "Onay",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (sonuc == DialogResult.Yes)
        {
            _yonetici.MusteriSil(musteri);
            GridGuncelle();
            FormuTemizle();
        }
    }

    private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return;

        int index = dgvMusteriler.SelectedRows[0].Index;
        if (index >= _yonetici.Musteriler.Count) return;

        var m = _yonetici.Musteriler[index];
        txtAd.Text = m.Ad;
        numYas.Value = m.Yas;
        chkUyelik.Checked = m.UyelikVar;
    }

    private void FormuTemizle()
    {
        txtAd.Clear();
        numYas.Value = 18;
        chkUyelik.Checked = false;
    }
}