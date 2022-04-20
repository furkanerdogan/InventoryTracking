use master

create table Urunler(
Urun_Id  int identity(1,1) primary key,
Urun_Adi varchar(255),
Urun_Marka varchar(255),
Urun_Fiyat int,
Aciklama varchar(max)

)

create table Depo(
Depo_Id int identity(1,1) primary key,
Urun_Id  int  foreign key references Urunler(Urun_Id),
Seri_No varchar(255),
Adet int default 1,
Tarih date,
Aciklama varchar(max),
Gonderildi BIT  default 0,
)

create table Istasyonlar(
Istasyon_Id int identity(1,1) primary key,
Istasyon_Adi varchar(255),Seri_No varchar(255),
Istasyon_No varchar(255),
Istasyon_Bayi_No varchar(255),

)

create table DepoCikis(
DepoCikis_Id  int identity(1,1) primary key,
Depo_Id  int  foreign key references Depo(Depo_Id),
Istasyon_Id  int  foreign key references Istasyonlar(Istasyon_Id),
Tarih date,
Aciklama varchar(max),
Adet int default 1,

)
SELECT Urunler.Urun_Adi,Depo.Depo_Id, Depo.Urun_Id, Depo.Seri_No, Depo.Adet, Depo.Tarih, Depo.Aciklama, Depo.Gonderildi FROM Depo,Urunler where Urunler.Urun_Id=Depo.Urun_Id and Depo.Gonderildi=1
SELECT Urunler.Urun_Adi,Depo.Depo_Id  ,Depo.Seri_No, Depo.Adet, Depo.Tarih, Depo.Aciklama, Depo.Gonderildi FROM Depo,Urunler where Urunler.Urun_Id=Depo.Urun_Id and Depo.Gonderildi=1
SELECT Istasyonlar.Istasyon_Id,Istasyonlar.Istasyon_Adi,Urunler.Urun_Adi,Depo.Depo_Id, Depo.Urun_Id, Depo.Seri_No, DepoCikis.Adet, DepoCikis.Tarih, DepoCikis.Aciklama FROM Depo,Urunler,DepoCikis,Istasyonlar where Urunler.Urun_Id=Depo.Urun_Id and Depo.Depo_Id=DepoCikis.Depo_Id and Istasyonlar.Istasyon_Id=DepoCikis.Istasyon_Id 
select * from Istasyonlar
