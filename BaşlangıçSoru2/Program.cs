/*
 
  Soru 2: Mevsim Belirleyici Program
Kullanıcıdan bir ayın sıra numarasını (1 ile 12 arasında bir tam sayı) alarak, o ayın hangi mevsime ait olduğunu ekrana yazdıran bir C# konsol uygulaması yazın.

Beklenen Çıktı Örnekleri:

Senaryo 1:
Lütfen bir ay numarası girin (1-12): 3
Mart ayı İlkbahar mevsimindedir.
Senaryo 2:
Lütfen bir ay numarası girin (1-12): 7
Temmuz ayı Yaz mevsimindedir.
Senaryo 3:
Lütfen bir ay numarası girin (1-12): 15
Hata: Geçersiz ay numarası! Lütfen 1 ile 12 arasında bir sayı girin.
Senaryo 4:
Lütfen bir ay numarası girin (1-12): abc
Hata: Geçersiz giriş! Lütfen sadece tam sayı girin.
Bu soruda, aşağıdaki konuları kullanmanı bekliyorum:

Konsol Giriş/Çıkış (Console.WriteLine, Console.ReadLine)
Temel Veri Tipleri (int, string) ve Değişkenler
Tür Dönüşümleri (int.TryParse() önerilir!)
Karar Yapıları (if-else if-else veya switch ifadesi)
Hata Yönetimi (try-catch veya int.TryParse() ile if-else kontrolü)

*/

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir ay numarası girin (1-12): ");
        string stringAyNumarası = Console.ReadLine();
        bool donusum = int.TryParse(stringAyNumarası, out int ayNumarası);

        if (!donusum)
        {
            Console.WriteLine("Hata: Geçersiz giriş! Lütfen sadece tam sayı girin.");
            return; 
        }

        if (ayNumarası < 1 || ayNumarası > 12)
        {
            Console.WriteLine("Hata: Geçersiz ay numarası! Lütfen 1 ile 12 arasında bir sayı girin.");
            return; 
        }

        string ayAdi = "";
        string mevsim = "";

        switch (ayNumarası)
        {
            case 1: ayAdi = "Ocak"; break;
            case 2: ayAdi = "Şubat"; break;
            case 3: ayAdi = "Mart"; break;
            case 4: ayAdi = "Nisan"; break;
            case 5: ayAdi = "Mayıs"; break;
            case 6: ayAdi = "Haziran"; break;
            case 7: ayAdi = "Temmuz"; break;
            case 8: ayAdi = "Ağustos"; break;
            case 9: ayAdi = "Eylül"; break;
            case 10: ayAdi = "Ekim"; break;
            case 11: ayAdi = "Kasım"; break;
            case 12: ayAdi = "Aralık"; break;
        }

        if (ayNumarası >= 3 && ayNumarası <= 5) 
        {
            mevsim = "İlkbahar";
        }
        else if (ayNumarası >= 6 && ayNumarası <= 8) 
        {
            mevsim = "Yaz";
        }
        else if (ayNumarası >= 9 && ayNumarası <= 11)
        {
            mevsim = "Sonbahar";
        }
        else 
        {
            mevsim = "Kış";
        }

        Console.WriteLine($"{ayAdi} ayı {mevsim} mevsimindedir.");
    }
}
