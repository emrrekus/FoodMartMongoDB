# FoodMartMongoDB

FoodMartMongoDB, yiyecek ve içecek ürünlerinin yönetimi için geliştirilmiş modern bir web uygulamasıdır. ASP.NET Core ve MongoDB teknolojilerini kullanarak geliştirilmiş bu proje, restoran ve gıda işletmeleri için kapsamlı bir yönetim sistemi sunar.

## 🚀 Özellikler

- MongoDB veritabanı entegrasyonu
- ASP.NET Core MVC mimarisi
- Ürün yönetimi
- Kategori yönetimi
- Kullanıcı dostu arayüz
- Responsive tasarım
- View Components kullanımı
- DTOs ve AutoMapper implementasyonu
- Service-based mimari

## 🛠 Teknolojiler

- ASP.NET Core
- MongoDB
- HTML5
- CSS3
- JavaScript
- Bootstrap
- AutoMapper
- Docker (opsiyonel)

## 📋 Gereksinimler

- .NET 7.0 veya üzeri
- MongoDB 6.0 veya üzeri
- Visual Studio 2022 veya Visual Studio Code

## 🔧 Kurulum

1. Projeyi klonlayın:

```bash
git clone https://github.com/yourusername/FoodMartMongoDB.git
```

2. Proje dizinine gidin:

```bash
cd FoodMartMongoDB
```

3. Gerekli paketleri yükleyin:

```bash
dotnet restore
```

4. MongoDB bağlantı ayarlarını `appsettings.json` dosyasında yapılandırın.

5. Uygulamayı çalıştırın:

```bash
dotnet run
```

## 📁 Proje Yapısı

```
FoodMartMongoDB/
├── Controllers/     # MVC Controllers
├── Models/         # Model sınıfları
├── Views/          # Razor view dosyaları
├── Services/       # İş mantığı servisleri
├── Entities/       # Veritabanı entity'leri
├── Dtos/          # Data Transfer Objects
├── Mapping/        # AutoMapper profilleri
├── Settings/       # Konfigürasyon ayarları
├── ViewComponents/ # View bileşenleri
└── wwwroot/       # Statik dosyalar
```

## 🔐 Konfigürasyon

`appsettings.json` dosyasında MongoDB bağlantı ayarlarını yapılandırın:

```json
{
  "DatabaseSettings": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "FoodMartDB"
  }
}
```

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Feature branch'i oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje [MIT](LICENSE) lisansı altında lisanslanmıştır.

## 📞 İletişim

Proje Sahibi - [@yourusername](https://github.com/yourusername)

Proje Linki: [https://github.com/yourusername/FoodMartMongoDB](https://github.com/yourusername/FoodMartMongoDB)
