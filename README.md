# 📚 Kütüphane Yönetim Sistemi (Library Management System)

Bu proje, bir kütüphanenin günlük operasyonlarını (kitap kayıt, üye takibi, ödünç alma/verme) kolayca yönetmek için geliştirilmiş, **Python** tabanlı bir masaüstü uygulamasıdır. Yazılım mimarisi olarak nesne yönelimli programlama (OOP) prensipleri kullanılarak inşa edilmiştir.

## ✨ Temel Özellikler

* **Kapsamlı Kitap Yönetimi:** Kitap ekleme, silme, güncelleme ve detaylı arama özellikleri.
* **Üye Takip Sistemi:** Kütüphane üyelerinin kayıtlarını tutma ve iletişim bilgilerini yönetme.
* **Ödünç Alma & İade Modülü:** Hangi kitabın hangi üyede olduğunu, iade tarihlerini ve geçmiş işlemleri takip eden dinamik yapı.
* **Durum Kontrolü:** Kitapların anlık olarak "Mevcut" veya "Ödünç Verildi" durumlarının otomatik güncellenmesi.
* **Kullanıcı Dostu Arayüz:** Hem yönetici hem de personel için hızlı işlem yapmaya olanak sağlayan sade tasarım.

## 🛠️ Teknolojik Altyapı

* **Programlama Dili:** Python
* **Veritabanı:** SQLite (Hafif, taşınabilir ve hızlı veri saklama için)
* **Arayüz (GUI):** Tkinter / CustomTkinter (Modern ve şık bir görünüm için)
* **Mimari:** Clean Code ve Nesne Yönelimli Programlama (OOP) prensipleri.

## 📂 Proje Yapısı

```text
├── database/           # SQLite veritabanı dosyaları ve tablolar
├── models/             # Kitap, Üye ve İşlem sınıfları (OOP)
├── ui/                 # Arayüz pencereleri ve tasarım bileşenleri
├── utils/              # Yardımcı fonksiyonlar ve doğrulama araçları
└── main.py             # Uygulamanın giriş noktası
