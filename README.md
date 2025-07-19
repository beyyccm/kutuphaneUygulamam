# 📚 Patika Kütüphane – Kitap Kayıt Uygulaması

Bu uygulama, bir kütüphane sisteminde kitapların kaydını tutmak amacıyla geliştirilmiştir. Kitap nesneleri `Ad`, `Yazar Adı`, `Yazar Soyadı`, `Sayfa Sayısı`, `Yayınevi` ve otomatik olarak oluşturulan `Kayıt Tarihi` bilgileri ile oluşturulur.

---

## 🔧 Kullanılan Teknolojiler

- Dil: **C#**
- Ortam: **.NET Console Application**
- IDE: Visual Studio / Rider / VS Code (isteğe bağlı)

---

## 🎯 Amaç

Bu pratik uygulama ile aşağıdaki OOP (Nesne Tabanlı Programlama) kavramları öğrenilmektedir:

- `Class` (Sınıf) tanımlama
- `Property` (Özellik) oluşturma
- `Constructor` (Yapıcı metot) kullanımı (Default ve Parametreli)
- `new` anahtar kelimesi ile nesne üretimi
- `DateTime.Now` ile sistem zamanını alma

---

## 🚀 Nasıl Çalıştırılır?

1. Proje dosyasını bir C# Console uygulaması olarak açın.
2. `Program.cs` dosyasına aşağıdaki kodları yapıştırın.
3. `Ctrl + F5` tuşlarıyla çalıştırın.
4. Konsolda örnek kitap bilgileri listelenecektir.

---

## 🧪 Örnek Kullanım

Programda iki adet kitap nesnesi oluşturulmaktadır:

1. **Parametreli constructor** kullanılarak:
   - Kitap Adı: `Adı Aylin`
   - Yazar: `Ayşe Kulin`
   - Sayfa Sayısı: `398`
   - Yayınevi: `Remzi Kitabevi`

2. **Default constructor** ile oluşturulup, bilgileri sonradan atanarak:
   - Kitap Adı: `Tutunamayanlar`
   - Yazar: `Oğuz Atay`
   - Sayfa Sayısı: `724`
   - Yayınevi: `İletişim Yayınları`

Her iki kitap için `Kayıt Tarihi`, sistemin o anki zamanı olarak otomatik atanır.

---

## 💡 Kavram Açıklamaları

- **Class**: Kitapları temsil eden `Kitap` adında bir sınıf tanımlanmıştır.
- **Property**: Her kitap için gerekli bilgiler (`Ad`, `YazarAdi`, vs.) özellik olarak tanımlanmıştır.
- **Constructor**: Nesne oluşturulurken çalıştırılan özel metotlardır. Biri parametresiz, diğeri parametreli olarak yazılmıştır.
- **New**: Yeni bir kitap nesnesi oluşturmak için kullanılmıştır. Örn: `new Kitap(...)`

---

## 🧑‍🎓 Hazırlayan

> **Ad Soyad**: [Buraya kendi adını yaz]  
> **Sınıf / Öğrenci No**: [İsteğe bağlı]  
> **Ders**: Programlama / Nesne Tabanlı Programlama  
> **Eğitmen**: [Ödevin verildiği hocanın adı]

---

