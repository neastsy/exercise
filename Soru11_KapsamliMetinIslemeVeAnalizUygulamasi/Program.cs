/*
 * Harika! Öğrenme şevkinizi ve pekiştirme isteğinizi takdir ediyorum. Önceki Aşama 1 konularının çoğunu bir araya getirecek ve yeni bir problem çözme senaryosu sunacak kapsamlı bir soru hazırladım. Bu soru, temel döngüler, diziler, metotlar, string işlemleri ve hata yönetimi becerilerinizi zorlayacak.

Soru 11: Kapsamlı Metin İşleme ve Analiz Uygulaması
Kullanıcının girdiği bir metni çeşitli şekillerde işleyen ve analiz eden, menü tabanlı bir program yazın. Programınız, metin üzerinde aşağıdaki işlemleri yapabilmelidir:

Metin Girişi ve Doğrulama:

Kullanıcıdan bir metin (cümle veya paragraf) girmesini isteyin.
Metin boş veya sadece boşluklardan oluşuyorsa hata mesajı verin ve tekrar isteyin.
Menü Sistemi:

Kullanıcıya aşağıdaki seçenekleri sunan bir menü gösterin:
Metindeki Harf Türü Dağılımını Göster (Büyük/Küçük Harf, Rakam, Sembol)
En Uzun ve En Kısa Kelimeleri Bul
Belirli Bir Kelimenin Metinde Geçtiği Yerleri Göster
Metindeki Sesli ve Sessiz Harfleri Say
Çıkış
Kullanıcı geçerli bir sayı girene kadar (1-5 arası) hata yönetimi yapın.
Kullanıcı "Çıkış" seçeneğini seçene kadar program menüyü tekrar göstermeye devam etmelidir.
Metotlar ve İşlevsellikler:

MetinGirisAl() Metodu:

Kullanıcıdan metin girmesini isteyen ve geçerli bir metin alana kadar tekrar eden metot.
Aldığı metni string olarak geri döndürsün.
HarfTuruDagitimi(string metin) Metodu:

Metindeki büyük harf, küçük harf, rakam ve diğer karakter (sembol) sayılarını bulup konsola ayrı ayrı yazdırın.
İpucu: char.IsUpper(), char.IsLower(), char.IsDigit() metotlarını kullanın. Geriye kalanlar sembol veya boşluk olarak kabul edilebilir.
KelimeAnalizi(string metin) Metodu:

Metindeki en uzun kelimeyi ve en kısa kelimeyi bulun ve konsola yazdırın.
Eğer birden fazla en uzun/kısa kelime varsa, ilk bulunanı yazdırın.
İpucu: Metni kelimelere ayırmak için string.Split() metodunu StringSplitOptions.RemoveEmptyEntries ile kullanın. Noktalama işaretlerini temizlemeyi unutmayın (string.Replace() ile boşlukla değiştirerek).
KelimeYeriBul(string metin, string arananKelime) Metodu:

Kullanıcıdan aranacak kelimeyi alın (boş olmamalı, hata yönetimi).
Aranan kelimenin metin içinde geçtiği tüm başlangıç indekslerini (konumlarını) bulun ve konsola yazdırın.
Büyük/küçük harf duyarsız arama yapın.
Eğer kelime bulunamazsa "Belirtilen kelime metinde bulunamadı." mesajı yazdırın.
İpucu: metin.ToLower().IndexOf(arananKelime.ToLower(), startIndex) metodunu döngü içinde kullanabilirsiniz.
SesliSessizHarfSayimi(string metin) Metodu:

Metindeki toplam sesli (a, e, ı, i, o, ö, u, ü) ve sessiz harf sayılarını bulun.
Türkçe karakterleri (ç, ğ, ş gibi) de dikkate alarak sadece harf olanları sayın.
Sonuçları konsola yazdırın.
İpucu: char.IsLetter() ile sadece harfleri filtreleyebilirsiniz. Ardından bir switch-case veya if-else if yapısı ile sesli/sessiz ayrımı yapın.
*/

public class Program
{
    static void Main(string[] args)
    {
        string metin = MetinGirisAl();
        Console.WriteLine();
        int sayi = 0;
        do
        {
            MenuSistemi();
            Console.WriteLine();
            sayi = KullaniciGirisi();
            Console.WriteLine();
            if (sayi == 5)
            {
                Console.WriteLine("Çıkış Yapılıyor!");
                break;
            }
            switch (sayi)
            {
                case 1: HarfTuruDagitimi(metin); Console.WriteLine(); break;
                case 2: KelimeAnalizi(metin); Console.WriteLine(); break;
                case 3:
                    {
                        string arananKelime;
                        bool arananBasariliMi = false;
                        do
                        {
                            Console.Write("Aranan Kelimeyi Girin: ");
                            arananKelime = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(arananKelime))

                            {
                                Console.WriteLine("Metin boş veya boşluklarla dolu olamaz!");
                            }
                            else
                            {
                                arananBasariliMi = true;
                            }
                        } while (!arananBasariliMi);

                        KelimeYeriBul(metin, arananKelime);
                    }
                    Console.WriteLine();
                    break;
                case 4: SesliSessizHarfSayimi(metin); Console.WriteLine(); break;
            }
            Console.WriteLine();
        } while (true);

    }

    public static string MetinGirisAl()
    {
        string metin;
        bool girisBasariliMi = false;
        do
        {
            Console.Write("Bir metin girin(cümle veya paragraf): ");

            metin = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(metin))

            {
                Console.WriteLine("Metin boş veya boşluklarla dolu olamaz!");
            }
            else
            {
                girisBasariliMi = true;
            }
        } while (!girisBasariliMi);
        return metin;
    }

    public static void MenuSistemi()
    {
        Console.WriteLine("İşlem Menüsü");
        Console.WriteLine();
        Console.WriteLine("1 - Metindeki Harf Türü Dağılımını Göster (Büyük/Küçük Harf, Rakam, Sembol)");
        Console.WriteLine("2 - En Uzun ve En Kısa Kelimeleri Bul");
        Console.WriteLine("3 - Belirli Bir Kelimenin Metinde Geçtiği Yerleri Göster");
        Console.WriteLine("4 - Metindeki Sesli ve Sessiz Harfleri Say");
        Console.WriteLine("5 - Çıkış");
    }

    public static int KullaniciGirisi()
    {
        int tamsayi;
        bool donusum = false;
        do
        {
            Console.Write("İşlem için bir tam sayı girin: ");
            string strSayi = Console.ReadLine();
            donusum = int.TryParse(strSayi, out tamsayi);
            if (!donusum)
            {
                Console.WriteLine("Tam Sayı Girin!");
            }
            else if (tamsayi > 5 || tamsayi < 1)
            {
                Console.WriteLine("1-5 Arasında bir sayı girin!");
                donusum = false;
            }
        } while (!donusum);
        return tamsayi;
    }

    public static void HarfTuruDagitimi(string metin)
    {
        int buyukHarfSayisi = 0; 
        int kucukHarfSayisi = 0;
        int rakamSayisi = 0;
        int digerKarakterSayisi = 0; 

        for (int i = 0; i < metin.Length; i++)
        {
            if (char.IsUpper(metin[i]))
            {
                buyukHarfSayisi++;
            }
            else if (char.IsLower(metin[i]))
            {
                kucukHarfSayisi++;
            }
            else if (char.IsDigit(metin[i]))
            {
                rakamSayisi++;
            }
            else
            {
                digerKarakterSayisi++;
            }
        }

        Console.WriteLine($"Büyük Harf Sayısı: {buyukHarfSayisi}");
        Console.WriteLine($"Küçük Harf Sayısı: {kucukHarfSayisi}");
        Console.WriteLine($"Rakam Sayısı: {rakamSayisi}");
        Console.WriteLine($"Diğer Karakter Sayısı (Semboller, Boşluklar vb.): {digerKarakterSayisi}");
    }


    public static void KelimeAnalizi(string metin)
    {
        string temizlenmisMetin = metin.ToLower();
        char[] tumAyiricilarVeNoktalama = { ' ', '"', ',', '.', '+', '-', '/', '*', '%', ';', '?', '!', '=', '(', ')', '\t', '\n', '\r' };


        string[] kelimeDizisi = temizlenmisMetin.Split(tumAyiricilarVeNoktalama, StringSplitOptions.RemoveEmptyEntries);

        if (kelimeDizisi.Length == 0)
        {
            Console.WriteLine("Metinde analiz edilecek kelime bulunamadı.");
            return;
        }

        string enUzunKelime = kelimeDizisi[0];
        string enKisaKelime = kelimeDizisi[0];

        for (int i = 1; i < kelimeDizisi.Length; i++)
        {
            if (kelimeDizisi[i].Length > enUzunKelime.Length)
            {
                enUzunKelime = kelimeDizisi[i];
            }
            if (kelimeDizisi[i].Length < enKisaKelime.Length)
            {
                enKisaKelime = kelimeDizisi[i];
            }
        }
        Console.WriteLine($"En Kısa Kelime: {enKisaKelime}");
        Console.WriteLine($"En Uzun Kelime: {enUzunKelime}");
    }

    public static void KelimeYeriBul(string metin, string arananKelime)
    {
        string kucukMetin = metin.ToLower();
        string kucukArananKelime = arananKelime.ToLower();

        int baslangicIndex = 0;
        int bulunanIndex;
        int bulunanKelimeSayisi = 0;

        Console.WriteLine($"\n--- '{arananKelime}' kelimesi aranıyor ---");

        while (true)
        {
            bulunanIndex = kucukMetin.IndexOf(kucukArananKelime, baslangicIndex);

            if (bulunanIndex == -1)
            {
                break;
            }
            Console.WriteLine($"'{arananKelime}' kelimesi {bulunanIndex} indeksinde bulundu.");
            bulunanKelimeSayisi++;

            baslangicIndex = bulunanIndex + kucukArananKelime.Length;

            if (baslangicIndex >= kucukMetin.Length)
            {
                break;
            }
        }

        if (bulunanKelimeSayisi == 0)
        {
            Console.WriteLine("Belirtilen kelime metinde bulunamadı.");
        }
        else
        {
            Console.WriteLine($"'{arananKelime}' kelimesi toplam {bulunanKelimeSayisi} kez bulundu.");
        }


    }

    public static void SesliSessizHarfSayimi(string metin)
    {
        int sesliHarfler = 0;
        int sessizHarfler = 0;

        string kucukMetin = metin.ToLower(new System.Globalization.CultureInfo("tr-TR")); // Türkçe kültüre göre küçük harfe çevir

        char[] sesliHarfKarakterleri = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        for (int i = 0; i < kucukMetin.Length; i++)
        {
            char karakter = kucukMetin[i];

            if (char.IsLetter(karakter))
            {
                bool isSesli = false;
                foreach (char sesli in sesliHarfKarakterleri)
                {
                    if (karakter == sesli)
                    {
                        isSesli = true;
                        break;
                    }
                }

                if (isSesli)
                {
                    sesliHarfler++;
                }
                else
                {
                    sessizHarfler++;
                }
            }
        }

        Console.WriteLine($"Sesli Harf Sayısı: {sesliHarfler}");
        Console.WriteLine($"Sessiz Harf Sayısı: {sessizHarfler}");
    }

}
