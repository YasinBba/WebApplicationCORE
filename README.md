# WebApplicationCORE - E-Ticaret Altyapısı

Bu proje, ASP.NET Core tabanlı modüler ve genişletilebilir bir **e-ticaret web uygulaması altyapısı**dır. Proje katmanlı mimari prensibine göre yapılandırılmıştır ve domain odaklı geliştirilmektedir.

---

## 📦 Proje Yapısı

WebApplicationCORE/
│
├── CORE/ → Domain katmanı (Entity, Repository, Interface)
│ ├── Entities/ → Varlık sınıfları (henüz tamamlanmadı)
│ ├── Interfaces/ → Arayüz tanımları
│ └── Data/ → Ortak soyut sınıflar, base entity vb.
│
├── APP/ → Uygulama servis katmanı (Business Logic)
│
├── WebApplicationCORE/ → UI/Web katmanı (MVC veya API)
│
├── APP.cs → Ana yapılandırma bileşeni
├── WebApplicationCORE.sln → Solution dosyası

---

## 🧱 Planlanan Entity'ler

Aşağıda ileride projeye eklenecek başlıca domain entity'leri listelenmiştir:

### ✅ Temel Entity'ler
- `Product`: Ürün bilgileri (ad, açıklama, fiyat, stok, kategori vs.)
- `Category`: Kategori yapısı, hiyerarşik destekli
- `ProductImage`: Ürün görselleri
- `Brand`: Marka bilgileri

### 🛒 Sipariş Entity'leri
- `Order`: Sipariş bilgileri
- `OrderItem`: Siparişteki ürün satırları

### 👤 Kullanıcı Entity'si
- `Customer`: Müşteri ya da sistem kullanıcı bilgisi

---

## 🧩 Planlanan Geliştirmeler

- [ ] Entity sınıflarının oluşturulması
- [ ] Generic Repository altyapısının genişletilmesi
- [ ] Unit of Work deseni entegrasyonu
- [ ] EF Core ile veri erişimi (Code First)
- [ ] JWT Authentication (isteğe bağlı)
- [ ] Swagger / OpenAPI desteği
- [ ] Test altyapısının kurulması

---

## 🛠️ Teknolojiler

- **.NET 6/7+**
- **Entity Framework Core**
- **C# 10+**
- Katmanlı Mimari (Layered Architecture)
- SOLID Prensipleri

---

## 📌 Notlar

Bu repo, henüz entity katmanı tam olarak tamamlanmamış bir altyapıdır. Katmanlı yapıya uygun olarak geliştirilmeye açıktır. Pull request ve katkılar memnuniyetle karşılanır.

---

## 🧑‍💻 Katkıda Bulun

Eğer projeye katkı sağlamak isterseniz:
1. Fork yapın
2. Geliştirme dalınızı oluşturun (`feature/EntityProduct`)
3. Commit yapın
4. Push edin
5. Pull request gönderin

---

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır.
