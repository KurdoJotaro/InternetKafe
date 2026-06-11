namespace InternetKafe;

public partial class OturumForm : Form
{
    private readonly KafeYonetici _yonetici;

    public OturumForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        FormStili.Uygula(this);
        _yonetici = yonetici;
    }

    private void CombolariDoldur()
    {
        // 1. Müşteri ComboBox doldurma
        cmbMusteri.Items.Clear();
        foreach (var m in _yonetici.Musteriler)
            cmbMusteri.Items.Add(m);

        if (cmbMusteri.Items.Count > 0) cmbMusteri.SelectedIndex = 0;

        // 2. Boş Bilgisayarlar ComboBox doldurma
        cmbBilgisayar.Items.Clear();
        foreach (var pc in _yonetici.Bilgisayarlar.Where(b => !b.DoluMu))
            cmbBilgisayar.Items.Add(pc);

        if (cmbBilgisayar.Items.Count > 0) cmbBilgisayar.SelectedIndex = 0;

        // 3. Yeni Eklenen Alan: İkramlar ComboBox doldurma
        cmbIkram.Items.Clear();
        foreach (var i in _yonetici.Ikramlar)
            cmbIkram.Items.Add(i);

        if (cmbIkram.Items.Count > 0) cmbIkram.SelectedIndex = 0;
    }

    private void AktifOturumlariGuncelle()
    {
        lstAktifOturumlar.Items.Clear();
        foreach (var oturum in _yonetici.Oturumlar.Where(o => o.AktifMi))
            lstAktifOturumlar.Items.Add(oturum);

        if (lstAktifOturumlar.Items.Count == 0)
            OturumBilgileriniTemizle();
    }

    private void btnOturumBaslat_Click(object sender, EventArgs e)
    {
        if (cmbMusteri.SelectedItem == null || cmbBilgisayar.SelectedItem == null)
        {
            MessageBox.Show("Müşteri ve boş bilgisayar seçimi zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var musteri = (Musteri)cmbMusteri.SelectedItem;
            var pc = (Bilgisayar)cmbBilgisayar.SelectedItem;

            _yonetici.OturumBaslat(musteri, pc);

            CombolariDoldur();
            AktifOturumlariGuncelle();
            MessageBox.Show($"{musteri.Ad} → PC-{pc.Numara} oturumu başlatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();
    }

    // Yeni Eklenen Metot: Seçili Masaya İkram Siparişi Satma
    private void btnIkramSat_Click(object sender, EventArgs e)
    {
        if (lstAktifOturumlar.SelectedItem == null)
        {
            MessageBox.Show("Sipariş eklemek için önce sol listeden aktif bir oturum (masa) seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbIkram.SelectedItem == null)
        {
            MessageBox.Show("Satılacak ürünü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var oturum = (Oturum)lstAktifOturumlar.SelectedItem;
        var ikram = (Ikram)cmbIkram.SelectedItem;
        int adet = (int)numIkramAdet.Value;

        try
        {
            _yonetici.OturumaIkramEkle(oturum, ikram, adet);

            MessageBox.Show($"Sipariş Başarılı!\n{oturum.Bilgisayar.Numara} nolu masadaki {oturum.Musteri.Ad} isimli müşteriye {adet} adet {ikram.Ad} teslim edildi.", "Sipariş Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numIkramAdet.Value = 1;
            UcretHesapla();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();
    }

    private void lstAktifOturumlar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstAktifOturumlar.SelectedItem == null) return;

        var oturum = (Oturum)lstAktifOturumlar.SelectedItem;
        lblMusteriAdi.Text = $"Müşteri: {oturum.Musteri.Ad}";
        lblPCNo.Text = $"PC: {oturum.Bilgisayar.Numara} ({oturum.Bilgisayar.Kategori})";
        lblBaslangic.Text = $"Başlangıç: {oturum.BaslangicZamani:HH:mm}";
        lblUcretBilgisi.Text = oturum.UcretBilgisi();

        UcretHesapla();
    }

    private void numDakika_ValueChanged(object sender, EventArgs e)
    {
        UcretHesapla();
    }

    private void UcretHesapla()
    {
        if (lstAktifOturumlar.SelectedItem == null) return;

        var oturum = (Oturum)lstAktifOturumlar.SelectedItem;
        int dakika = (int)numDakika.Value;
        int faturalanacakDk = Math.Max(dakika, 30);

        decimal pcUcret = oturum.Bilgisayar.SaatlikUcret * faturalanacakDk / 60m;
        decimal indirim = pcUcret * oturum.Musteri.IndirimOrani;
        decimal toplam = pcUcret - indirim + oturum.IkramTutari;

        lblBilgisayarUcreti.Text = $"PC Ücreti: {pcUcret:C2}";
        lblIndirim.Text = $"İndirim (%{oturum.Musteri.IndirimOrani * 100:0}): -{indirim:C2}";
        lblIkramTutari.Text = $"İkram: {oturum.IkramTutari:C2}";
        lblToplamTutar.Text = $"TOPLAM: {toplam:C2}";
    }

    private void btnOturumBitir_Click(object sender, EventArgs e)
    {
        if (lstAktifOturumlar.SelectedItem == null)
        {
            MessageBox.Show("Kapatılacak oturumu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var oturum = (Oturum)lstAktifOturumlar.SelectedItem;
            int dakika = (int)numDakika.Value;

            var sonuc = MessageBox.Show(
                $"Oturumu kapatmak istiyor musunuz?\n{oturum.Musteri.Ad} - PC-{oturum.Bilgisayar.Numara}\nSüre: {dakika} dk",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                _yonetici.OturumBitir(oturum, dakika);
                CombolariDoldur();
                AktifOturumlariGuncelle();
                OturumBilgileriniTemizle();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        (Application.OpenForms["AnaForm"] as AnaForm)?.DashboardGuncelle();
    }

    private void OturumBilgileriniTemizle()
    {
        lblMusteriAdi.Text = "Müşteri: -";
        lblPCNo.Text = "PC: -";
        lblBaslangic.Text = "Başlangıç: -";
        lblUcretBilgisi.Text = "Seçili ücret bilgisi: -";
        lblBilgisayarUcreti.Text = "PC Ücreti: -";
        lblIndirim.Text = "İndirim: -";
        lblIkramTutari.Text = "İkram: -";
        lblToplamTutar.Text = "TOPLAM: -";
    }

    private void OturumForm_Load(object sender, EventArgs e)
    {
        CombolariDoldur();
        AktifOturumlariGuncelle();
    }
}
