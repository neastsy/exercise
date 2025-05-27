public class Program
{
    /*
     * Soru 1: Basit Kullanıcı Etkileşimi ve Hesaplama

    Kullanıcıdan iki adet tam sayı alarak, bu sayıların toplamını, farkını, çarpımını ve bölümünü hesaplayıp ekrana yazdıran bir C# konsol uygulaması yazın. 
    Bölme işleminde, eğer ikinci sayı sıfır ise, kullanıcıya uygun bir hata mesajı gösterin ve programın çökmesini engelleyin.

    Beklenen Çıktı Örnekleri:

    Senaryo 1:

    Lütfen birinci sayıyı girin: 10
    Lütfen ikinci sayıyı girin: 5
    Toplam: 15
    Fark: 5
    Çarpım: 50
    Bölüm: 2


    Senaryo 2:

    Lütfen birinci sayıyı girin: 20
    Lütfen ikinci sayıyı girin: 0
    Hata: Bir sayı sıfıra bölünemez!


    Senaryo 3:

    Lütfen birinci sayıyı girin: abc
    Lütfen ikinci sayıyı girin: 5
    Hata: Geçersiz giriş! Lütfen sadece tam sayı girin.

    Bu ilk soruda, aşağıdaki konuları kullanmanızı bekliyorum:

    Konsol Giriş/Çıkış (Console.WriteLine, Console.ReadLine)
    Temel Veri Tipleri (int) ve Değişkenler
    Tür Dönüşümleri (Convert.ToInt32 veya int.Parse, int.TryParse)
    Aritmetik Operatörler (+, -, *, /)
    Temel Hata Yönetimi (try-catch blokları, özellikle FormatException ve DivideByZeroException için)

    */
    static void Main(string[] args)
    {
        Console.Write("Lütfen birinci sayıyı giriniz: ");
        string strsayi1 = Console.ReadLine();
        Console.Write("Lütfen ikinci sayıyı giriniz: ");
        string strsayi2 = Console.ReadLine();
        try
        {
            int sayi1 = int.Parse(strsayi1);
            int sayi2 = Convert.ToInt32(strsayi2);
            int toplam = sayi1 + sayi2;
            int fark = sayi1 - sayi2;
            int carpim = sayi1 * sayi2;
            int bolum = sayi1 / sayi2;
            Console.WriteLine($"Toplam: {toplam}");
            Console.WriteLine($"Fark: {fark}");
            Console.WriteLine($"Çarpım: {carpim}");
            Console.WriteLine($"Bölüm: {bolum}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: Geçersiz giriş! Lütfen sadece tam sayı girin.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Hata : Bir sayı sıfıra bölünemez!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: Genel Bir Hata. {ex.Message}");
        }

    }

}

