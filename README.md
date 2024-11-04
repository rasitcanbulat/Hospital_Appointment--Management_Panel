# Giriş Paneli -- Login Panel

![Ekran görüntüsü 2024-11-03 233300](https://github.com/user-attachments/assets/83c96f7b-0e2c-4310-b05e-f2466bd92907)

#  Hasta Giriş Paneli -- Patient Login Panel

![Ekran görüntüsü 2024-11-03 233312](https://github.com/user-attachments/assets/cff3c0e7-a202-4db4-9141-fd55173024dd)

# Hasta Detay Paneli -- Patient Details Panel

![Ekran görüntüsü 2024-11-03 233342](https://github.com/user-attachments/assets/501680d0-9c96-49be-b1c8-e0daaaf573f8)

# Hasta Bilgi Düzenleme Paneli -- Patient Information Edit Panel 

![Ekran görüntüsü 2024-11-03 233407](https://github.com/user-attachments/assets/6e2bd24e-1ca5-4e03-97c1-ad0f7fc1eefd)

# Doktor Giriş Paneli -- Doctor Login Panel

![Ekran görüntüsü 2024-11-03 233429](https://github.com/user-attachments/assets/957dff2a-086d-4f51-bd8f-3021d121cbb0)

# Doktor Kontrol Paneli -- Doctor Control Panel

![Ekran görüntüsü 2024-11-03 233439](https://github.com/user-attachments/assets/bd3be397-5cfa-4a9e-9e22-98279dc8a2c2)

# Doktor Bilgi Düzenleme Paneli -- Doctor Information Edit Panel

![Ekran görüntüsü 2024-11-03 233448](https://github.com/user-attachments/assets/293845c0-30fd-4ff9-b865-9d408427f335)

# Duyuru Paneli -- Announcement Panel

![Ekran görüntüsü 2024-11-03 233605](https://github.com/user-attachments/assets/edd5ca5a-1514-4400-bf13-d094b2d45055)

# Sekreter Giriş Paneli -- Secretary Login Panel

![Ekran görüntüsü 2024-11-03 233619](https://github.com/user-attachments/assets/84a12a54-45ef-44f2-a7ce-de6ceba23023)

# Sekreter Kontrol Paneli -- Secretary Control Panel

![Ekran görüntüsü 2024-11-03 233653](https://github.com/user-attachments/assets/b259e4b0-bcb1-4b5f-acc8-b103e6babcd2)

# Doktor Ekle/Çıkar Paneli -- Add/Remove Doctor Panel

![Ekran görüntüsü 2024-11-03 233704](https://github.com/user-attachments/assets/997d54b3-aa76-49a8-9137-50ad0b2fddd7)

# Branş Ekle/Çıkar Paneli -- Add/Remove Department Panel

![Ekran görüntüsü 2024-11-03 233726](https://github.com/user-attachments/assets/cf1980b3-8672-40d6-87b1-4550daa27f8e)

# Randevu Görünteleme Paneli -- Appointment Viewing Panel

![Ekran görüntüsü 2024-11-03 233747](https://github.com/user-attachments/assets/edc2a832-2566-45db-a037-8d9d4502a898)

# TR
**Hastane Randevu Yönetim Paneli**
Bu proje, bir hastane için randevu yönetim paneli sağlayan bir C# uygulamasıdır. Uygulama, hastalar, doktorlar ve sekreterler için farklı giriş ve işlem özelliklerine sahiptir.

**Özellikler**
1. Hasta Girişi
Üye Olma ve Giriş: Hastalar üye olabilir ve hesaplarına giriş yapabilir.
Randevu Alma: Hastalar, istediği branştan ve istediği doktordan sekreterlerin belirlediği saatlerde randevu alabilir.
Bilgi Güncelleme: Kendi bilgilerini güncelleyebilirler.
Geçmiş Randevuları Görüntüleme: Daha önce aldıkları randevuların listesini görebilirler.
2. Doktor Girişi
Giriş: Doktorlar, kendilerine verilen TC kimlik numarası ve şifre ile sisteme giriş yapar.
Duyurular: Sekreterlerin kendilerine özel duyurularını görebilirler.
Randevuları Görüntüleme: Kendilerine gelen randevuları görüntüleyebilirler.
Bilgi Güncelleme: Kişisel bilgilerini güncelleyebilirler.
3. Sekreter Girişi
Giriş: Sekreterler, verilen TC kimlik numarası ve şifre ile giriş yapar.
Doktor ve Branş İşlemleri: Doktor ekleyip/silebilir, branş ekleyip/silebilir.
Randevu Yönetimi: Randevuları görüntüleyebilir, yeni randevu ekleyebilir.
Duyuru Yapma: Doktorların görebileceği şekilde duyurular atabilir.

**Gereksinimler:**

.NET Framework
Visual Studio

**Kurulum**
Kurulum Adımları:

setup.rar dosyasını klasöre ayıklayın.
Debug klasörüne giriş yapın.
Kurulum exe yi çalıştırın.
Kurulumu tamamlayın.

Veritabanı Yapılandırması:

Veritabanını yapılandırmak için SQL dosyasına giriş yapın.
Veritabanını Kendi SQL tablolarınıza ekleyin.
Programı Çalıştırın.

**Kullanım**
Hasta, doktor veya sekreter girişi ekranlarından uygun bilgileri girerek sisteme giriş yapılabilir.
Detaylı kullanım için yukarıda özellikler bölümünde belirtilen işlemler yapılabilir.

**Katkıda Bulunma**
Katkı sağlamak için lütfen bir pull request gönderin veya iletişime geçin.

# ENG

**Hospital Appointment Management Panel**
This project is a C# application that provides an appointment management panel for a hospital. The application includes unique login and function features for patients, doctors, and secretaries.

**Features**
1. **Patient Login**
   - **Sign-Up and Login:** Patients can create an account and log in.
   - **Appointment Booking:** Patients can book appointments with their chosen department and doctor, based on the times set by secretaries.
   - **Information Update:** Patients can update their personal information.
   - **View Past Appointments:** Patients can view a list of their previous appointments.

2. **Doctor Login**
   - **Login:** Doctors can log in using their provided ID number and password.
   - **Announcements:** Doctors can view announcements posted specifically for them by secretaries.
   - **View Appointments:** Doctors can see the appointments scheduled with them.
   - **Information Update:** Doctors can update their personal information.

3. **Secretary Login**
   - **Login:** Secretaries can log in using their assigned ID number and password.
   - **Doctor and Department Management:** Secretaries can add or remove doctors and departments.
   - **Appointment Management:** Secretaries can view, add, or manage appointments.
   - **Announcements:** Secretaries can post announcements that doctors can view.

**Requirements:**
- .NET Framework
- Visual Studio

**Installation**
Installation Steps:

1. Extract the `setup.rar` file to a folder.
2. Enter the Debug folder.
3. Run the setup `.exe` file.
4. Complete the installation.

Database Configuration:

1. Access the SQL file to set up the database.
2. Add the database to your own SQL tables.
3. Run the application.

**Usage**
Users can log in as a patient, doctor, or secretary by entering the appropriate information on their respective login screens. Detailed instructions for usage are covered in the features section above.

**Contributing**
To contribute, please submit a pull request or contact us.
