// See https://aka.ms/new-console-template for more information


void EkaranaYazdirma()
{
    Console.WriteLine("Hello, World!");
    Console.Write("Ad : ");
    Console.WriteLine("Deniz");
    Console.Write("Soyad : ");
    Console.WriteLine("Vayısoğlu");

}
void FarkliVerileriToplama()
{
    string isim = "Ahmet";
    int yas = 18;
    Console.WriteLine($"İsim : {isim}, Yaş : {yas}");
}
void AyniVerileriToplama()
{
    int a = 10;
    int b = 20;
    Console.WriteLine($"Toplam : {a + b}");
}

void GirilenİlkSayiyiBulma()
{
    Console.Write("Birinci sayıyı giriniz: ");
    int s1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("İkinci sayıyı giriniz: ");
    int s2 = Convert.ToInt32(Console.ReadLine());

    int toplam = s1 + s2;
    Console.WriteLine("Toplam = " + toplam);
}

void DogumTarihleriGirilenBirininYasiniHesaplama()
{
    Console.Write("Doğum Yılınızı Giriniz : ");
    int dogum = Convert.ToInt32(Console.ReadLine());

    int yas = 2025 - dogum;
    Console.WriteLine("Yaşınız : " + yas); 
}

void GirilenUcSinavNotununOrtalamasi()
{
    Console.Write("Sınav 1 : ");
    double sınav1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Sınav 2 : ");
    double sınav2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Sınav 3 : ");
    double sınav3 = Convert.ToDouble(Console.ReadLine());
    double ort = (sınav1 + sınav2 + sınav3) / 3;
    Console.Write($"Ortalamanız : {ort} ");
}



void GirilenIkiSayininAritmetikIslemleri()
{
    Console.Write("Sayı 1 : ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Sayı 2 : ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Toplam = " + (sayi1 + sayi2));
    Console.WriteLine("Fark   = " + (sayi1 - sayi2));
    Console.WriteLine("Çarpım = " + (sayi1 * sayi2));
    Console.WriteLine("Bölüm  = " + (sayi1 / sayi2));
    Console.WriteLine("Kalan  = " + (sayi1 % sayi2));
}


void YasiGirilenKisininResitOlupOlmadiginiKontrolEtme()
{
    Console.Write("Yaşınız = ");
    int yas = Convert.ToInt32(Console.ReadLine());
    if (yas >= 18)
    {
        Console.WriteLine("Reşitsiniz.");
    }
    else
    {
        Console.WriteLine("Reşit Değilsiniz.");
    }
}




// GİRİLEN SAYININ POZİTİF, NEGATİF VEYA NÖTR OLDUĞUNU KONTROL ETME

void SayiPozitifNegatifNötr()

{
    Console.Write("Sayi = ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    
    if (sayi > 0)
    {
        Console.WriteLine("Pozitif");
    }
    else if (sayi < 0)
    {
        Console.WriteLine("Negatif");
    }
    else
    {
        Console.WriteLine("Nötr");
    }
}


// GİRİLEN NOTA GÖRE GEÇME SEVİYESİNİ BELİRLEME
void GirilenNotaGoreGecmeSeviyesi()
{
    Console.Write("Not : ");
    int not = int.Parse(Console.ReadLine());

    if (not >= 85)
    {
        Console.WriteLine("PEKİYİ");
    }
    else if (not >= 70)
    {
        Console.WriteLine("İYİ");
    }
    else if (not >= 50)
    {
        Console.WriteLine("ORTA");
    }
    else
    {
        Console.WriteLine("KALDINIZ");
    }
}


// KULLANICI ADI, ŞİFRE VE AKTİF/PASİF DURUMUNA GÖRE GİRİŞ KONTROLÜ YAPMA

void KullanıcıAdiSifreAktiflikKontrol() {
    Console.Write("Kullanıcı Adınız : ");
    string kullaniciAdi = Console.ReadLine();

    Console.Write("Şifreniz : ");
    string sifre = Console.ReadLine();

    Console.Write("Aktif/Pasif durumunu giriniz : true veya false olarak : ");
    bool aktif = bool.Parse(Console.ReadLine());


    if (kullaniciAdi == "admin")
    {
        if (sifre == "12345")
        {
            if (aktif == true)
            {
                Console.WriteLine("Hoş Geldiniz Admin!");
            }
            else
            {
                Console.WriteLine("Hesabınız Aktif Değil");
            }
        }
        else
        {
            Console.WriteLine($"Hatalı şifre!");
        }
    }
    else
        Console.WriteLine("Hatalı kullanıcı girişi");
}


// YAŞI VE EHLİYET DURUMUNA GÖRE ARAÇ KULLANIP KULLANAMAYACAĞINI BELİRLEME

void YasVeEhliyetDurumu()
{
    Console.Write("Yaşınız : ");
    int yas = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ehliyetiniz var mı : varsa true yoksa false değeriniz giriniz.  :  ");
    bool ehliyet = bool.Parse(Console.ReadLine());

    if (yas >= 18 && ehliyet == true)
    {
        Console.WriteLine("Araç Kullanabilirsiniz.");
    }
    else
    {
        Console.WriteLine("Araç Kullanamazsınız.");
    }
}




void EnBuyukSayi()
{
    Console.Write("1. Sayıyı Giriniz : ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("2 Sayıyı Giriniz : ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("3. Sayıyı Giriniz : ");
    int sayi3 = Convert.ToInt32(Console.ReadLine());

    if (sayi1 > sayi2 && sayi1 > sayi3)
    {
        Console.WriteLine("Sayı 1 en büyüktür");
    }
    else if (sayi2 > sayi1 && sayi2 > sayi3)
    {
        Console.WriteLine("Sayı 2 en büyüktür");
    }
    else
    {
        Console.WriteLine($"{sayi3} en büyüktür");
    }

}






