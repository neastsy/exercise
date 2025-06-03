/*
 * Soru 4: Palindrom Kontrolü
Kullanıcıdan bir kelime veya cümle girmesini isteyin. Girdiği metnin bir palindrom olup olmadığını kontrol eden bir C# konsol uygulaması yazın.

Palindrom Nedir?
Palindrom, düzden okunduğunda da tersten okunduğunda da aynı olan kelime veya cümlelere denir. Örneğin: "kabak", "madam", "ey edip adanada pide ye". (Cümleler kontrol edilirken boşluklar ve noktalama işaretleri göz ardı edilmeli, büyük/küçük harf duyarlılığı kaldırılmalıdır.)

Beklenen Çıktı Örnekleri:

Senaryo 1:
Lütfen bir kelime veya cümle girin: kabak
'kabak' bir palindromdur.
Senaryo 2:
Lütfen bir kelime veya cümle girin: bilgisayar
'bilgisayar' bir palindrom değildir.
Senaryo 3:
Lütfen bir kelime veya cümle girin: Ey edip adanada pide ye
'Ey edip adanada pide ye' bir palindromdur.
Senaryo 4:
Lütfen bir kelime veya cümle girin:
Lütfen boş bir metin girmeyin!
Bu soruda, aşağıdaki konuları kullanmanı bekliyorum:

Konsol Giriş/Çıkış (Console.WriteLine, Console.ReadLine)
Temel Veri Tipleri (string, bool) ve Değişkenler
Metotlar (Özellikle palindrom kontrolünü yapan ayrı bir metot yazmalısın.)
Döngüler (Metni kontrol ederken kullanabilirsin)
Dizeler (Strings) ve Metin İşlemleri (ToLower(), Replace(), karakterlere erişim, vb.)
Karar Yapıları (if-else)
*/

public class Program
{
    static void Main(string[] args)
    {
        string metin;
        do
        {
            Console.Write("Lütfen bir kelime veya cümle girin: ");
            metin = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(metin))
            {
                Console.WriteLine("Lütfen boş bir metin girmeyin!");
            }
        } while (string.IsNullOrWhiteSpace(metin));


        bool palindromMu = Palindrom(metin);

        if (palindromMu)
        {
            Console.WriteLine($"'{metin}' bir palindromdur.");
        }
        else
        {
            Console.WriteLine($"'{metin}' bir palindrom değildir.");
        }

    }

    public static bool Palindrom(string girilenMetin)
    {
        string temizlenmisMetin = "";
        girilenMetin = girilenMetin.ToLower();

        for (int i = 0; i < girilenMetin.Length; i++)
        {
            char karakter = girilenMetin[i];

            if ((karakter >= 'a' && karakter <= 'z') || (karakter >= '0' && karakter <= '9'))
            {
                // Sadece harf ve rakamları al
                temizlenmisMetin += karakter;
            }
        }
        /* gelişmiş metin temizleme işlemi
        if (char.IsLetterOrDigit(karakter)) // Sadece harf ve rakamları al
        {
            temizlenmisMetin += karakter;
        }
        */
        string tersCevrilmisMetin = "";
        for (int i = temizlenmisMetin.Length - 1; i >= 0; i--)
        {
            tersCevrilmisMetin += temizlenmisMetin[i];
        }

        return temizlenmisMetin == tersCevrilmisMetin;

    }

}