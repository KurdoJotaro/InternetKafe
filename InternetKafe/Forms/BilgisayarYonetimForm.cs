namespace InternetKafe;

public partial class BilgisayarYonetimForm : Form
{
    private readonly KafeYonetici _yonetici;

    public BilgisayarYonetimForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
        _yonetici = yonetici;
    }

    private void BilgisayarYonetimForm_Load(object sender, EventArgs e)
    {
        cmbRamGB.SelectedIndex = 1;
        cmbIslemci.SelectedIndex = 1;
        cmbEkranKarti.SelectedIndex = 1;
        GridGuncelle();
    }

    private void GridGuncelle()
    {
        dgvBilgisayarlar.Rows.Clear();
        foreach (var pc in _yonetici.Bilgisayarlar)
        {
            int rowIndex = dgvBilgisayarlar.Rows.Add(
                pc.Numara,
                pc.RamGB + " GB",
                pc.IslemciPuani,
                pc.EkranKartiPuani,
                pc.PerformansPuani,
                pc.Kategori,
                pc.SaatlikUcret.ToString("C2"),
                pc.DoluMu ? "Dolu" : "Boş"
            );
            dgvBilgisayarlar.Rows[rowIndex].Tag = pc;
        }
    }

    private void PuanHesapla()
    {
        try
        {
            if (cmbRamGB.SelectedItem == null || cmbIslemci.SelectedItem == null || cmbEkranKarti.SelectedItem == null)
                return;

            int ram = int.Parse(cmbRamGB.SelectedItem.ToString()!);
            int islemci = cmbIslemci.SelectedIndex + 1; // İndeks 0'dan başlar, puan 1'den
            int gpu = cmbEkranKarti.SelectedIndex + 1;
            int puan = (ram / 8) + islemci + gpu;

            string kategori = puan >= 8 ? "Turnuva" : (puan >= 5 ? "VIP" : "Standart");
            decimal ucret = kategori switch
            {
                "Turnuva" => 30m,
                "VIP" => 20m,
                _ => 10m
            };

            lblPerformansPuani.Text = $"Performans: {puan}";
            lblKategori.Text = $"Kategori: {kategori}";
            lblSaatlikUcret.Text = $"Ücret: {ucret:C2}/saat";
        }
        catch { }
    }

    private void cmbRamGB_SelectedIndexChanged(object sender, EventArgs e) => PuanHesapla();
    private void cmbIslemci_SelectedIndexChanged(object sender, EventArgs e) => PuanHesapla();
    private void cmbEkranKarti_SelectedIndexChanged(object sender, EventArgs e) => PuanHesapla();

    private void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Numara giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pc = new Bilgisayar
            {
                Numara = int.Parse(txtNumara.Text),
                RamGB = int.Parse(cmbRamGB.SelectedItem!.ToString()!),
                IslemciPuani = cmbIslemci.SelectedIndex + 1,
                EkranKartiPuani = cmbEkranKarti.SelectedIndex + 1
            };

            _yonetici.BilgisayarEkle(pc);
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
        if (dgvBilgisayarlar.SelectedRows.Count == 0) return;

        try
        {
            var pc = SeciliBilgisayarGetir();
            if (pc == null) return;

            _yonetici.BilgisayarGuncelle(
                pc,
                int.Parse(txtNumara.Text),
                int.Parse(cmbRamGB.SelectedItem!.ToString()!),
                cmbIslemci.SelectedIndex + 1,
                cmbEkranKarti.SelectedIndex + 1
            );

            GridGuncelle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
        
    private void btnSil_Click(object sender, EventArgs e)
    {
        if (dgvBilgisayarlar.SelectedRows.Count == 0) return;

        var pc = SeciliBilgisayarGetir();
        if (pc == null) return;

        if (pc.DoluMu)
        {
            MessageBox.Show("Dolu bilgisayar silinemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var sonuc = MessageBox.Show("Bu bilgisayarı silmek istiyor musunuz?", "Onay",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (sonuc == DialogResult.Yes)
        {
            _yonetici.BilgisayarSil(pc);
            GridGuncelle();
            FormuTemizle();
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();// Üst paneldeki bilgileri güncelle.
    }

    private void dgvBilgisayarlar_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvBilgisayarlar.SelectedRows.Count == 0) return;

        var pc = SeciliBilgisayarGetir();
        if (pc == null) return;

        txtNumara.Text = pc.Numara.ToString();
        cmbRamGB.SelectedItem = pc.RamGB.ToString();
        cmbIslemci.SelectedIndex = pc.IslemciPuani - 1;
        cmbEkranKarti.SelectedIndex = pc.EkranKartiPuani - 1;
    }

    private Bilgisayar? SeciliBilgisayarGetir()
    {
        if (dgvBilgisayarlar.SelectedRows.Count == 0) return null;
        return dgvBilgisayarlar.SelectedRows[0].Tag as Bilgisayar;
    }

    private void FormuTemizle()
    {
        txtNumara.Clear();
        cmbRamGB.SelectedIndex = 1;
        cmbIslemci.SelectedIndex = 1;
        cmbEkranKarti.SelectedIndex = 1;
    }
}
