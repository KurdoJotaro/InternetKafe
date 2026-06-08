namespace InternetKafe
{
    public class KafeYonetici
    {
        private readonly List<Musteri> _musteriler = new();
        private readonly List<Bilgisayar> _bilgisayarlar = new();

        public IReadOnlyList<Musteri> Musteriler => _musteriler;
        public IReadOnlyList<Bilgisayar> Bilgisayarlar => _bilgisayarlar;

        public void MusteriEkle(Musteri musteri)
        {
            if (musteri == null)
                throw new ArgumentNullException(nameof(musteri), "Müşteri verisi boş olamaz.");

            if (_musteriler.Contains(musteri))
                throw new InvalidOperationException("Bu müşteri zaten listede mevcut.");

            _musteriler.Add(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            if (musteri == null)
                throw new ArgumentNullException(nameof(musteri));

            _musteriler.Remove(musteri);
        }

        public void MusteriGuncelle(int index, string ad, int yas, bool uyelikVar)
        {
            if (index < 0 || index >= _musteriler.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Geçersiz müşteri indeksi.");

            var musteri = _musteriler[index];
            musteri.Ad = ad;
            musteri.Yas = yas;
            musteri.UyelikVar = uyelikVar;
        }


        public void BilgisayarEkle(Bilgisayar bilgisayar)
        {
            if (bilgisayar == null)
                throw new ArgumentNullException(nameof(bilgisayar), "Bilgisayar verisi boş olamaz.");

            // Aynı numaraya sahip bilgisayar eklenmesini engelle
            if (_bilgisayarlar.Any(b => b.Numara == bilgisayar.Numara))
                throw new InvalidOperationException("Bu numaraya sahip bir bilgisayar zaten kayıtlı.");

            _bilgisayarlar.Add(bilgisayar);
        }

        public void BilgisayarSil(Bilgisayar bilgisayar)
        {
            if (bilgisayar == null)
                throw new ArgumentNullException(nameof(bilgisayar));

            _bilgisayarlar.Remove(bilgisayar);
        }

        public void BilgisayarGuncelle(int index, int numara, int ramGB, int islemciPuani, int ekranKartiPuani)
        {
            if (index < 0 || index >= _bilgisayarlar.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Geçersiz bilgisayar indeksi.");

            var pc = _bilgisayarlar[index];

            if (pc.Numara != numara && _bilgisayarlar.Any(b => b.Numara == numara))
                throw new InvalidOperationException("Bu numaraya sahip başka bir bilgisayar var.");

            pc.Numara = numara;
            pc.RamGB = ramGB;
            pc.IslemciPuani = islemciPuani;
            pc.EkranKartiPuani = ekranKartiPuani;
        }

        public int BosBilgisayarSayisi()
        {
            return _bilgisayarlar.Count(b => !b.DoluMu);
        }
    }
}