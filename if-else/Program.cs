
List<Ogrenci> ogrenciler = new();
List<Ogrenci> siniftaOlmayanlar = new();
List<Ogrenci> siniftaGecenler = new();
List<Ogrenci> siniftaKalanlar = new();
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Adem", SiniftaMi = false, OgrenciNo = 1 , Devamsizlik = 5,SinavNotu = 50,});
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Enes", SiniftaMi = true, OgrenciNo = 2, Devamsizlik = 21, SinavNotu = 45, });
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Burak", SiniftaMi = true, OgrenciNo = 3, Devamsizlik = 8, SinavNotu = 56,});
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Ahmet", SiniftaMi = false, OgrenciNo = 4, Devamsizlik = 11, SinavNotu = 35, });
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Hasan", SiniftaMi = true, OgrenciNo = 5, Devamsizlik = 14, SinavNotu = 78,});
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Fatih", SiniftaMi = false, OgrenciNo = 6, Devamsizlik = 22, SinavNotu = 77,});
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Ali", SiniftaMi = true, OgrenciNo = 7, Devamsizlik = 15, SinavNotu = 22, });
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Samet", SiniftaMi = true, OgrenciNo = 8, Devamsizlik = 3, SinavNotu = 73,  });
ogrenciler.Add(new Ogrenci() { OgrenciAdi = "Taner", SiniftaMi = false, OgrenciNo = 9, Devamsizlik = 7, SinavNotu = 41, });
rtn:;
Console.WriteLine("Merhaba Öğrenci yoklama ve dersi geçip geçemediğini hesaplayan uygulamaya hoş geldiniz");
Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını yazarak seçiniz");
Console.WriteLine("1. Öğrenci listesi");
Console.WriteLine("2. Yoklama al");
Console.WriteLine("3. Gelmeyen öğrenci listesi");
Console.WriteLine("4. Sınıfı Geçip ve Kalanların listesi");
Console.WriteLine("5. Çıkış");
int secim = int.Parse(Console.ReadLine());
if (secim == 1)
{
    Console.WriteLine("Öğrenci bilgileri aşağıda verilmiştir.");
    foreach (var item in ogrenciler)
    {
        Console.WriteLine("Öğrenci Adı : " + item.OgrenciAdi + ", Öğrenci Numarası : " + item.OgrenciNo + ", Devamsızlık Bilgisi : " + item.Devamsizlik + ", Sınav Notu : " + item.SinavNotu);
    }
    goto rtn;
}
else if (secim == 2)
{
    Console.WriteLine("Lütfen Öğrenci numarasını giriniz");
    int no = int.Parse(Console.ReadLine());
    Ogrenci ogrenci = ogrenciler.Where(p => p.OgrenciNo == no).FirstOrDefault();
    Console.WriteLine("Öğrenci Sınıfta ise 'true', öğrenci sınıfta değil ise 'false' yazınız.");
    bool kontrol = bool.Parse(Console.ReadLine());
    ogrenci.SiniftaMi = kontrol;
    goto rtn;
}
else if (secim == 3)
{
    siniftaOlmayanlar = ogrenciler.Where(p => p.SiniftaMi == false).ToList();
    Console.WriteLine("Gelmeyen öğrenci listesi aşağıda verilmiştir");
    foreach (var item in siniftaOlmayanlar)
    {
        Console.WriteLine("Öğrenci Adı : " + item.OgrenciAdi + ", Öğrenci Numarası : " + item.OgrenciNo + ", Devamsızlık Bilgisi : " + item.Devamsizlik + ", Sınav Notu : " + item.SinavNotu);
    }
    goto rtn;
}
else if (secim == 4)
{
    siniftaGecenler = ogrenciler.Where(p => p.Devamsizlik <= 20 && p.SinavNotu >= 50).ToList();
    siniftaKalanlar = ogrenciler.Where(p => p.Devamsizlik >= 20 || p.SinavNotu <= 50).ToList();
    Console.WriteLine("Sınıfı Geçenler Listesi");
    foreach (var item in siniftaGecenler)
    {
        Console.WriteLine("Öğrenci Adı : " + item.OgrenciAdi + ", Öğrenci Numarası : " + item.OgrenciNo + ", Devamsızlık Bilgisi : " + item.Devamsizlik + ", Sınav Notu : " + item.SinavNotu);
    }
    Console.WriteLine("");
    Console.WriteLine("Sınıfta Kalanlar Listesi");
    foreach (var item in siniftaKalanlar)
    {
        Console.WriteLine("Öğrenci Adı : " + item.OgrenciAdi + ", Öğrenci Numarası : " + item.OgrenciNo + ", Devamsızlık Bilgisi : " + item.Devamsizlik + ", Sınav Notu : " + item.SinavNotu);
    }
    goto rtn;
}
else if (secim == 5)
{
    Console.WriteLine("Çıkış Yapıldı");
}
public class Ogrenci
{
    public string OgrenciAdi { get; set; }
    public bool SiniftaMi { get; set; }
    public int OgrenciNo { get; set; }
    public int Devamsizlik { get; set; }
    public int SinavNotu { get; set; }

}

