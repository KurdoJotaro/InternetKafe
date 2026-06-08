using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetKafe
{
    public class KafeYonetici
    {
        private readonly List<Musteri> _musteriler = new();

        public IReadOnlyList<Musteri> Musteriler => _musteriler;

        public void MusteriEkle(Musteri musteri)
        {
            if (musteri == null)
                throw new ArgumentNullException(nameof(musteri), "Müşteri verisi boş olamaz. Müşteri verisi gircen.");

            if (_musteriler.Contains(musteri))
                throw new InvalidOperationException("Bu müşteri zaten listede mevcut. Bi daha ekleyemezsin.");

            _musteriler.Add(musteri);
        }

        public void MusteriSil(Musteri musteri)
        {
            if (musteri == null)
                throw new ArgumentNullException(nameof(musteri), "Müşteri bilgisi yok. Silmek istiyorsan verisini gönder.");

            _musteriler.Remove(musteri);
        }

        public void MusteriGuncelle(int index, string ad, int yas, bool uyelikVar)
        {
            if (index < 0 || index >= _musteriler.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Geçersiz müşteri indeksi. Müşteri aralığında değil.");

            var musteri = _musteriler[index];
            musteri.Ad = ad;
            musteri.Yas = yas;
            musteri.UyelikVar = uyelikVar;
        }
    }
}
