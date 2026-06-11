namespace InternetKafe;

public partial class MusteriYonetimForm : Form
{
    private readonly KafeYonetici _yonetici;

    public MusteriYonetimForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
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
            int rowIndex = dgvMusteriler.Rows.Add(
                m.Ad,
                m.Yas,
                m.UyelikVar ? "Evet" : "Hayır",
                m.ToplamHarcama.ToString("C2"),
                $"%{m.IndirimOrani * 100:0}"
            );
            dgvMusteriler.Rows[rowIndex].Tag = m;
        }
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (GirisDogrulama.BosVeyaSadeceRakam(txtAd.Text))
            {
                MessageBox.Show("Müşteri adı boş bırakılamaz ve sadece rakamlardan oluşamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();// Üst paneldeki bilgileri güncelle.
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return;

        try
        {
            if (GirisDogrulama.BosVeyaSadeceRakam(txtAd.Text))
            {
                MessageBox.Show("Müşteri adı boş bırakılamaz ve sadece rakamlardan oluşamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var musteri = SeciliMusteriGetir();
            if (musteri == null) return;

            _yonetici.MusteriGuncelle(musteri, txtAd.Text.Trim(), (int)numYas.Value, chkUyelik.Checked);

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

        var musteri = SeciliMusteriGetir();
        if (musteri == null) return;

        var sonuc = MessageBox.Show("Bu müşteriyi silmek istiyor musunuz?", "Onay",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (sonuc == DialogResult.Yes)
        {
            _yonetici.MusteriSil(musteri);
            GridGuncelle();
            FormuTemizle();
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();// Üst paneldeki bilgileri güncelle.
    }

    private void dgvMusteriler_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return;

        var m = SeciliMusteriGetir();
        if (m == null) return;

        txtAd.Text = m.Ad;
        numYas.Value = m.Yas;
        chkUyelik.Checked = m.UyelikVar;
        lblKisiBilgisi.Text = m.BilgiGetir();
    }

    private Musteri? SeciliMusteriGetir()
    {
        if (dgvMusteriler.SelectedRows.Count == 0) return null;
        return dgvMusteriler.SelectedRows[0].Tag as Musteri;
    }

    private void FormuTemizle()
    {
        txtAd.Clear();
        numYas.Value = 18;
        chkUyelik.Checked = false;
        lblKisiBilgisi.Text = "Seçili kişi bilgisi: -";
    }
}
