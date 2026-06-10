namespace InternetKafe
{
    public class KafeYonetici
    {
        // --- Alanlar ---
        private readonly List<Musteri> _musteriler = new();
        private readonly List<Bilgisayar> _bilgisayarlar = new();
        private readonly List<Oturum> _oturumlar = new();
        private readonly List<GelirGider> _islemler = new();

        // --- Özellikler ---
        public IReadOnlyList<Musteri> Musteriler => _musteriler;
        public IReadOnlyList<Bilgisayar> Bilgisayarlar => _bilgisayarlar;
        public IReadOnlyList<Oturum> Oturumlar => _oturumlar;
        public IReadOnlyList<GelirGider> Islemler => _islemler;

        // ==========================================
        // MÜŞTERİ YÖNETİMİ
        // ==========================================
        public void MusteriEkle(Musteri musteri)
        {
            if (musteri == null) throw new ArgumentNullException(nameof(musteri));
            if (_musteriler.Contains(musteri)) throw new InvalidOperationException("Bu müşteri listede mevcut.");
            _musteriler.Add(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            if (musteri == null) throw new ArgumentNullException(nameof(musteri));

            // Aktif oturumu olan müşteri silinemez
            if (_oturumlar.Any(o => o.AktifMi && o.Musteri == musteri))
                throw new InvalidOperationException("Aktif oturumu olan müşteri silinemez!");

            _musteriler.Remove(musteri);
        }

        public void MusteriGuncelle(int index, string ad, int yas, bool uyelikVar)
        {
            if (index < 0 || index >= _musteriler.Count) throw new ArgumentOutOfRangeException(nameof(index));
            MusteriGuncelle(_musteriler[index], ad, yas, uyelikVar);
        }

        public void MusteriGuncelle(Musteri musteri, string ad, int yas, bool uyelikVar)
        {
            if (musteri == null) throw new ArgumentNullException(nameof(musteri));
            if (!_musteriler.Contains(musteri)) throw new InvalidOperationException("Bu müşteri listede bulunamadı.");

            musteri.Ad = ad;
            musteri.Yas = yas;
            musteri.UyelikVar = uyelikVar;
        }

        // ==========================================
        // BİLGİSAYAR YÖNETİMİ
        // ==========================================
        public void BilgisayarEkle(Bilgisayar bilgisayar)
        {
            if (bilgisayar == null) throw new ArgumentNullException(nameof(bilgisayar));
            if (_bilgisayarlar.Any(b => b.Numara == bilgisayar.Numara)) throw new InvalidOperationException("Bu numara zaten kayıtlı.");
            _bilgisayarlar.Add(bilgisayar);
        }

        public void BilgisayarSil(Bilgisayar bilgisayar)
        {
            if (bilgisayar == null) throw new ArgumentNullException(nameof(bilgisayar));
            if (bilgisayar.DoluMu || _oturumlar.Any(o => o.AktifMi && o.Bilgisayar == bilgisayar))
                throw new InvalidOperationException("Aktif oturumu olan bilgisayar silinemez!");

            _bilgisayarlar.Remove(bilgisayar);
        }

        public void BilgisayarGuncelle(int index, int numara, int ramGB, int islemciPuani, int ekranKartiPuani)
        {
            if (index < 0 || index >= _bilgisayarlar.Count) throw new ArgumentOutOfRangeException(nameof(index));
            BilgisayarGuncelle(_bilgisayarlar[index], numara, ramGB, islemciPuani, ekranKartiPuani);
        }

        public void BilgisayarGuncelle(Bilgisayar pc, int numara, int ramGB, int islemciPuani, int ekranKartiPuani)
        {
            if (pc == null) throw new ArgumentNullException(nameof(pc));
            if (!_bilgisayarlar.Contains(pc)) throw new InvalidOperationException("Bu bilgisayar listede bulunamadı.");
            if (pc.Numara != numara && _bilgisayarlar.Any(b => b.Numara == numara)) throw new InvalidOperationException("Bu numara zaten var.");

            pc.Numara = numara;
            pc.RamGB = ramGB;
            pc.IslemciPuani = islemciPuani;
            pc.EkranKartiPuani = ekranKartiPuani;
        }

        public int BosBilgisayarSayisi()
        {
            return _bilgisayarlar.Count(b => !b.DoluMu);
        }

        // ==========================================
        // OTURUM YÖNETİMİ
        // ==========================================
        public Oturum OturumBaslat(Musteri musteri, Bilgisayar bilgisayar)
        {
            if (musteri == null) throw new ArgumentNullException(nameof(musteri));
            if (bilgisayar == null) throw new ArgumentNullException(nameof(bilgisayar));
            if (bilgisayar.DoluMu) throw new InvalidOperationException("Bu bilgisayar zaten dolu.");

            var oturum = new Oturum
            {
                Musteri = musteri,
                Bilgisayar = bilgisayar,
                BaslangicZamani = DateTime.Now,
                AktifMi = true,
                IkramTutari = 0
            };

            bilgisayar.DoluMu = true;
            _oturumlar.Add(oturum);
            return oturum;
        }

        public void OturumBitir(Oturum oturum, int dakika)
        {
            if (oturum == null) throw new ArgumentNullException(nameof(oturum));
            if (!oturum.AktifMi) throw new InvalidOperationException("Bu oturum zaten kapalı.");

            oturum.KullanilanDakika = dakika;
            oturum.Bilgisayar.DoluMu = false;
            oturum.AktifMi = false;

            oturum.Musteri.ToplamHarcama += oturum.ToplamTutar;

            _islemler.Add(new GelirGider
            {
                Aciklama = $"Oturum - {oturum.Musteri.Ad} PC-{oturum.Bilgisayar.Numara}",
                Tutar = oturum.ToplamTutar,
                GelirMi = true,
                Tarih = DateTime.Now
            });
        }

        public int AktifOturumSayisi()
        {
            return _oturumlar.Count(o => o.AktifMi);
        }

        // ==========================================
        // GELİR/GİDER YÖNETİMİ
        // ==========================================
        public decimal ToplamGelir() => _islemler.Where(i => i.GelirMi).Sum(i => i.Tutar);
        public decimal ToplamGider() => _islemler.Where(i => !i.GelirMi).Sum(i => i.Tutar);
        public decimal NetKar() => ToplamGelir() - ToplamGider();
        public decimal BugunkuGelir() => _islemler.Where(i => i.GelirMi && i.Tarih.Date == DateTime.Today).Sum(i => i.Tutar);

        // ==========================================
        // İKRAM VE TOPTANCI YÖNETİMİ
        // ==========================================
        private readonly List<Ikram> _ikramlar = new();
        private readonly List<Toptanci> _toptancilar = new();

        public IReadOnlyList<Ikram> Ikramlar => _ikramlar;
        public IReadOnlyList<Toptanci> Toptancilar => _toptancilar;

        public void IkramEkle(Ikram ikram)
        {
            if (ikram == null) throw new ArgumentNullException(nameof(ikram));
            if (string.IsNullOrWhiteSpace(ikram.Ad)) throw new ArgumentException("Ürün adı boş olamaz.");
            if (ikram.Fiyat <= 0) throw new ArgumentException("Ürün satış fiyatı 0'dan büyük olmalıdır.");
            if (_ikramlar.Any(i => string.Equals(i.Ad, ikram.Ad, StringComparison.CurrentCultureIgnoreCase)))
                throw new InvalidOperationException("Bu ürün adı zaten kayıtlı.");

            _ikramlar.Add(ikram);
        }

        public void IkramSil(Ikram ikram)
        {
            if (ikram == null) throw new ArgumentNullException(nameof(ikram));
            if (!_ikramlar.Contains(ikram)) throw new InvalidOperationException("Bu ürün listede bulunamadı.");

            _ikramlar.Remove(ikram);
        }

        public void ToptanciEkle(Toptanci toptanci)
        {
            if (toptanci == null) throw new ArgumentNullException(nameof(toptanci));
            _toptancilar.Add(toptanci);
        }

        public void OturumaIkramEkle(Oturum oturum, Ikram ikram, int adet)
        {
            if (oturum == null) throw new ArgumentNullException(nameof(oturum));
            if (ikram == null) throw new ArgumentNullException(nameof(ikram));
            if (!oturum.AktifMi) throw new InvalidOperationException("Kapalı oturuma ikram eklenemez.");
            if (adet <= 0) throw new ArgumentException("Satış adedi 0'dan büyük olmalıdır.");
            if (ikram.StokMiktari < adet)
                throw new InvalidOperationException("Yetersiz stok!");

            ikram.StokMiktari -= adet;
            oturum.IkramTutari += ikram.Fiyat * adet;
        }

        public void StokAlimi(Ikram ikram, Toptanci toptanci, int adet, decimal alisFiyati)
        {
            if (ikram == null) throw new ArgumentNullException(nameof(ikram));
            if (toptanci == null) throw new ArgumentNullException(nameof(toptanci));
            if (adet <= 0) throw new ArgumentException("Alım adedi 0'dan büyük olmalıdır.");
            if (alisFiyati <= 0) throw new ArgumentException("Alış fiyatı 0'dan büyük olmalıdır.");

            ikram.StokMiktari += adet;
            decimal toplamGider = alisFiyati * adet;

            _islemler.Add(new GelirGider
            {
                Aciklama = $"Stok Alımı: {toptanci.FirmaAdi} - {adet}x {ikram.Ad}",
                Tutar = toplamGider,
                GelirMi = false,
                Tarih = DateTime.Now
            });
        }
        // ==========================================
        // VERİ KAYIT VE YÜKLEME
        // ==========================================
        public KafeVerisi VerileriDisaAktar()
        {
            return new KafeVerisi
            {
                Musteriler = _musteriler.ToList(),
                Bilgisayarlar = _bilgisayarlar.ToList(),
                Oturumlar = _oturumlar.ToList(),
                Islemler = _islemler.ToList(),
                Ikramlar = _ikramlar.ToList(),
                Toptancilar = _toptancilar.ToList()
            };
        }

        public void VerileriIceAktar(KafeVerisi veri)
        {
            if (veri == null) return;

            _musteriler.Clear();
            _bilgisayarlar.Clear();
            _oturumlar.Clear();
            _islemler.Clear();
            _ikramlar.Clear();
            _toptancilar.Clear();

            _musteriler.AddRange(veri.Musteriler);
            _bilgisayarlar.AddRange(veri.Bilgisayarlar);
            _oturumlar.AddRange(veri.Oturumlar);
            _islemler.AddRange(veri.Islemler);
            _ikramlar.AddRange(veri.Ikramlar);
            _toptancilar.AddRange(veri.Toptancilar);
        }

        public void VarsayilanVerileriYukle()
        {
            _musteriler.Clear();
            _bilgisayarlar.Clear();
            _oturumlar.Clear();
            _islemler.Clear();
            _ikramlar.Clear();
            _toptancilar.Clear();

            MusteriEkle(new Musteri { Ad = "Ahmet Yılmaz", Yas = 22, UyelikVar = true });
            MusteriEkle(new Musteri { Ad = "Mehmet Kaya", Yas = 19, UyelikVar = false });

            BilgisayarEkle(new Bilgisayar { Numara = 1, RamGB = 8, IslemciPuani = 2, EkranKartiPuani = 2 });
            BilgisayarEkle(new Bilgisayar { Numara = 2, RamGB = 16, IslemciPuani = 3, EkranKartiPuani = 3 });
            BilgisayarEkle(new Bilgisayar { Numara = 3, RamGB = 32, IslemciPuani = 4, EkranKartiPuani = 4 });

            ToptanciEkle(new Toptanci { Ad = "Ahmet Toptan", Yas = 18, FirmaAdi = "Ahmet Gıda", VergiNo = "1234567890" });
            IkramEkle(new Ikram { Ad = "Kutu Kola", Fiyat = 25m, StokMiktari = 50 });
        }
    }
}
