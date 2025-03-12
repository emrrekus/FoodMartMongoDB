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

## 📸 Proje Görselleri
![7](https://github.com/user-attachments/assets/610be138-d5c0-4d55-93d4-095d72fa17a8)
![6](https://github.com/user-attachments/assets/da83248c-67e7-402f-bcc6-92548f2b3041)
![5](https://github.com/user-attachments/assets/47e41ed1-2ad5-44f5-9d1c-a186df7ce35a)
![4](https://github.com/user-attachments/assets/069c0736-9aa6-4dbb-acb8-8cfbbbeea3b1)
![3](https://github.com/user-attachments/assets/97650f7c-f975-4b6a-b240-bbea15fe1d8e)
![2](https://github.com/user-attachments/assets/9870c065-38a7-438c-8d52-46a86a82a3c6)
![1](https://github.com/user-attachments/assets/e7448c8d-4380-4066-94cc-04ccb540caed)


