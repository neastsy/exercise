/*
Kullanıcıdan girdiği ders sayısını alarak, her bir dersin notunu girmesini isteyin. 
Girilen tüm notları bir dizide saklayın. Not girişleri tamamlandıktan sonra, tüm notların ortalamasını hesaplayıp ekrana yazdırın. 
Not girişi sırasında, geçersiz (sayısal olmayan) bir değer girildiğinde hata mesajı verip tekrar not girmesini isteyin ve notun 0 ile 100 arasında olması gerektiğini kontrol edin. 
Eğer not bu aralık dışındaysa da hata mesajı verip tekrar girmesini isteyin.

Beklenen Çıktı Örnekleri:

Senaryo 1:

Kaç adet ders notu gireceksiniz?: 3
1. dersin notunu girin (0-100 arasında): 85
2. dersin notunu girin (0-100 arasında): 90
3. dersin notunu girin (0-100 arasında): 75
Not ortalaması: 83.33
Senaryo 2:

Kaç adet ders notu gireceksiniz?: 2
1. dersin notunu girin (0-100 arasında): abc
Hata: Geçersiz giriş! Lütfen 0-100 arasında bir tam sayı girin.
1. dersin notunu girin (0-100 arasında): 120
Hata: Not 0 ile 100 arasında olmalıdır. Lütfen tekrar girin.
1. dersin notunu girin (0-100 arasında): 70
2. dersin notunu girin (0-100 arasında): 95
Not ortalaması: 82.50
Senaryo 3:

Kaç adet ders notu gireceksiniz?: xyz
Hata: Geçersiz ders sayısı! Lütfen bir tam sayı girin.
Bu soruda, aşağıdaki konuları kullanmanı bekliyorum:

Konsol Giriş/Çıkış (Console.WriteLine, Console.ReadLine)
Temel Veri Tipleri (int, string, double) ve Değişkenler
Tür Dönüşümleri (int.TryParse())
Döngüler (for veya while, özellikle notları doğru alana kadar tekrar ettirmek için)
Diziler (int[] veya List<int>)
Karar Yapıları (if-else if-else)
Hata Yönetimi (int.TryParse() ile if-else kontrolü ve mantıksal aralık kontrolü)

*/

public class Program
{
    static void Main(string[] args)
    {
        int dersSayisi;
        string strDersSayisi;
        bool donusumDersSayisi;
        do
        {
            Console.Write("Kaç adet ders notu gireceksiniz?: ");
            strDersSayisi = Console.ReadLine();
            donusumDersSayisi = int.TryParse(strDersSayisi, out dersSayisi);

            if (!donusumDersSayisi)
            {
                Console.WriteLine("Hata: Geçersiz ders sayısı! Lütfen bir tam sayı girin.");
            }
            else if (dersSayisi <= 0) 
            {
                Console.WriteLine("Hata: Ders sayısı pozitif bir tam sayı olmalıdır. Lütfen tekrar girin.");
                donusumDersSayisi = false;
            }

        } while (!donusumDersSayisi);

        int[] notlar = new int[dersSayisi];

        bool donusumNot;
        int toplam = 0;

        for (int i = 0; i < dersSayisi; i++)
        {
            do
            {
                Console.Write($"{i + 1}. dersin notunu girin (0-100 arasında): ");
                string strNot = Console.ReadLine();
                donusumNot = int.TryParse(strNot, out int dersNot);
                if (!donusumNot)
                {
                    Console.WriteLine("Hata: Geçersiz giriş! Lütfen 0-100 arasında bir tam sayı girin.");
                }
                else if (dersNot < 0 || dersNot > 100)
                {
                    Console.WriteLine("Hata: Not 0 ile 100 arasında olmalıdır. Lütfen tekrar girin.");
                    donusumNot = false; 
                }
                else
                {
                    notlar[i] = dersNot;
                    toplam += dersNot;
                }
            } while (!donusumNot);

        }
        double ortalama = (double)toplam / dersSayisi;
        Console.WriteLine($"Not ortalaması: {ortalama:F2}");

    }

}