using System;

namespace PatikaKutuphane
{
    // Kitap sınıfı oluşturuluyor
    class Kitap
    {
        // Kitap sınıfı için gerekli property'ler tanımlanıyor
        public string Ad { get; set; }             // Kitabın adı
        public string YazarAdi { get; set; }       // Yazarın adı
        public string YazarSoyadi { get; set; }    // Yazarın soyadı
        public int SayfaSayisi { get; set; }       // Kitabın sayfa sayısı
        public string YayinEvi { get; set; }       // Kitabın yayınevi
        public DateTime KayitTarihi { get; set; }  // Sisteme kayıt tarihi

        // Parametresiz constructor (default constructor)
        public Kitap()
        {
            // Kayıt tarihi nesne oluşturulduğu anda sistem saatiyle atanır
            KayitTarihi = DateTime.Now;
        }

        // Parametreli constructor: bazı bilgileri nesne oluşturulurken alır
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinEvi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayinEvi;
            KayitTarihi = DateTime.Now; // Her iki constructor'da da otomatik atanır
        }

        // Kitap bilgilerini ekrana yazdıran metot
        public void BilgileriGoster()
        {
            Console.WriteLine("Kitap Bilgileri:");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Yazar: {YazarAdi} {YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {YayinEvi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
        }
    }

    // Program sınıfı: uygulamanın başlangıç noktası
    class Program
    {
        static void Main(string[] args)
        {
            // Parametreli constructor kullanılarak örnek kitap oluşturuluyor
            Kitap ornekKitap = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            ornekKitap.BilgileriGoster(); // Bilgiler ekrana yazdırılıyor

            Console.WriteLine(); // Boşluk bırak

            // Default constructor kullanılarak ikinci bir kitap oluşturuluyor
            Kitap ikinciKitap = new Kitap();
            ikinciKitap.Ad = "Tutunamayanlar";
            ikinciKitap.YazarAdi = "Oğuz";
            ikinciKitap.YazarSoyadi = "Atay";
            ikinciKitap.SayfaSayisi = 724;
            ikinciKitap.YayinEvi = "İletişim Yayınları";
            ikinciKitap.BilgileriGoster(); // Bilgiler ekrana yazdırılıyor
        }
    }
}
// class => Kitap bilgilerini modellemek için bir sınıf (class) tanımladık.
// property => Kitabın adı, yazarı, yayınevi gibi bilgileri saklamak için property'ler tanımladık.
// new => Nesne üretmek için new anahtar kelimesini kullandık.
// constructor => Kitap sınıfına ait 2 adet constructor oluşturduk:
// 1. Default Constructor => Parametre almaz, sadece kayıt tarihini atar.
// 2. Parametreli Constructor => Kitapla ilgili bilgileri nesne oluştururken doğrudan alır ve atar.

