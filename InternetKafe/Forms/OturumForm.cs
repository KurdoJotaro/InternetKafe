namespace InternetKafe;

public partial class OturumForm : Form
{
    private readonly KafeYonetici _yonetici;

    public OturumForm(KafeYonetici yonetici)
    {
        InitializeComponent();
        _yonetici = yonetici;
    }

    private void CombolariDoldur()
    {
        cmbMusteri.Items.Clear();
        foreach (var m in _yonetici.Musteriler)
            cmbMusteri.Items.Add(m);

        if (cmbMusteri.Items.Count > 0) cmbMusteri.SelectedIndex = 0;

        cmbBilgisayar.Items.Clear();
        // Sadece boş olan bilgisayarları listeliyoruz
        foreach (var pc in _yonetici.Bilgisayarlar.Where(b => !b.DoluMu))
            cmbBilgisayar.Items.Add(pc);

        if (cmbBilgisayar.Items.Count > 0) cmbBilgisayar.SelectedIndex = 0;
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
        if (cmbMusteri.SelectedItem == null)
        {
            MessageBox.Show("Müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (cmbBilgisayar.SelectedItem == null)
        {
            MessageBox.Show("Boş bilgisayar seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }

    private void lstAktifOturumlar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstAktifOturumlar.SelectedItem == null) return;

        var oturum = (Oturum)lstAktifOturumlar.SelectedItem;
        lblMusteriAdi.Text = $"Müşteri: {oturum.Musteri.Ad}";
        lblPCNo.Text = $"PC: {oturum.Bilgisayar.Numara} ({oturum.Bilgisayar.Kategori})";
        lblBaslangic.Text = $"Başlangıç: {oturum.BaslangicZamani:HH:mm}";

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

        // İş Kuralı: Minimum 30 dakika ücretlendirilir
        int faturalanacakDk = Math.Max(dakika, 30);

        decimal pcUcret = oturum.Bilgisayar.SaatlikUcret * faturalanacakDk / 60m;
        decimal indirim = pcUcret * oturum.Musteri.IndirimOrani;
        decimal toplam = pcUcret - indirim;

        lblBilgisayarUcreti.Text = $"PC Ücreti: {pcUcret:C2}";
        lblIndirim.Text = $"İndirim (%{oturum.Musteri.IndirimOrani * 100:0}): -{indirim:C2}";
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
    }

    private void OturumBilgileriniTemizle()
    {
        lblMusteriAdi.Text = "Müşteri: -";
        lblPCNo.Text = "PC: -";
        lblBaslangic.Text = "Başlangıç: -";
        lblBilgisayarUcreti.Text = "PC Ücreti: -";
        lblIndirim.Text = "İndirim: -";
        lblToplamTutar.Text = "TOPLAM: -";
    }

    private void OturumForm_Load(object sender, EventArgs e)
    {
        CombolariDoldur();
        AktifOturumlariGuncelle();
    }
}