/*
 * Soru 5: Basit Alışveriş Sepeti Uygulaması
Basit bir konsol tabanlı alışveriş sepeti uygulaması yazın. Uygulama, kullanıcıdan ürünleri ve adetlerini alacak, sepete ekleyecek ve sonunda sepetin toplam tutarını hesaplayıp gösterecektir.

Uygulama Akışı:

Kullanıcıya mevcut ürün listesi ve fiyatları gösterilmelidir.
Ürün 1: Laptop (1200 TL)
Ürün 2: Klavye (150 TL)
Ürün 3: Mouse (75 TL)
Ürün 4: Monitör (800 TL)
Kullanıcıdan satın almak istediği ürün numarasını (1-4 arası) girmesi istenmelidir. Eğer geçersiz bir numara girerse hata mesajı verilmeli ve tekrar istenmelidir.
Kullanıcıdan bu üründen kaç adet almak istediği sorulmalıdır. Geçersiz (sıfır veya negatif) adet veya sayısal olmayan giriş yapılırsa hata mesajı verilmeli ve tekrar istenmelidir.
Kullanıcı "0" (sıfır) ürün numarası girerek alışverişi sonlandırabilir.
Alışveriş sonlandığında, sepetteki tüm ürünlerin toplam tutarı ekrana yazdırılmalıdır.
Beklenen Çıktı Örnekleri:

Senaryo 1 (Başarılı Alışveriş):

----- Ürün Listesi -----
1: Laptop (1200 TL)
2: Klavye (150 TL)
3: Mouse (75 TL)
4: Monitör (800 TL)
-------------------------

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): 1
Kaç adet almak istersiniz?: 2

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): 3
Kaç adet almak istersiniz?: 1

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): 0
Alışverişiniz tamamlandı.
Toplam sepet tutarı: 2475 TL
Senaryo 2 (Hatalı Girişler):

----- Ürün Listesi -----
1: Laptop (1200 TL)
2: Klavye (150 TL)
3: Mouse (75 TL)
4: Monitör (800 TL)
-------------------------

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): 5
Hata: Geçersiz ürün numarası! Lütfen 0 ile 4 arasında bir sayı girin.

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): abc
Hata: Geçersiz giriş! Lütfen bir tam sayı girin.

Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): 2
Kaç adet almak istersiniz?: -3
Hata: Adet pozitif bir tam sayı olmalıdır. Lütfen tekrar girin.

Kaç adet almak istersiniz?: xyz
Hata: Geçersiz giriş! Lütfen bir tam sayı girin.

Kaç adet almak istersiniz?: 1
... (alışveriş devam eder veya sonlanır)
Bu soruda, aşağıdaki konuları kullanmanı bekliyorum:

Konsol Giriş/Çıkış
Temel Veri Tipleri (string, int, double) ve Değişkenler
Tür Dönüşümleri (int.TryParse())
Diziler (Ürün isimlerini ve fiyatlarını saklamak için iki ayrı dizi veya tek bir dizi içinde mantıksal bir yapı kullanabilirsin.)
Döngüler (while döngüsü ana alışveriş akışı için, içeride giriş doğrulamaları için do-while veya while)
Metotlar (Örneğin, ürün listesini yazdırmak veya kullanıcıdan geçerli ürün/adet girişi almak için yardımcı metotlar yazmak kodunu daha düzenli yapar.)
Karar Yapıları (if-else if-else, switch)
Hata Yönetimi (TryParse ve if-else kontrolleri)
*/
public class Program
{

    static string[] urunIsimleri = { "Laptop", "Klavye", "Mouse", "Monitör" };
    static double[] urunFiyatlari = { 1200.0, 150.0, 75.0, 800.0 };

    static void Main(string[] args)
    {

        UrunListesiniGoster();

        int urunNumarasi;
        double toplamSepetTutari = 0;


        do
        {
            Console.Write("Satın almak istediğiniz ürün numarasını girin (1-4, çıkış için 0): ");
            string strUrunNumarasi = Console.ReadLine();


            bool urunNumarasiGecerli = int.TryParse(strUrunNumarasi, out urunNumarasi);

            if (!urunNumarasiGecerli)
            {
                Console.WriteLine("Hata: Geçersiz giriş! Lütfen bir tam sayı girin.");
                Console.WriteLine();
                continue;
            }

            if (urunNumarasi == 0)
            {

                break;
            }


            if (urunNumarasi < 1 || urunNumarasi > urunIsimleri.Length)
            {
                Console.WriteLine($"Hata: Geçersiz ürün numarası! Lütfen 0 ile {urunIsimleri.Length} arasında bir sayı girin.");
                Console.WriteLine();
                continue;
            }


            int adet;
            bool adetGecerli;
            do
            {
                Console.Write("Kaç adet almak istersiniz?: ");
                string strAdet = Console.ReadLine();
                adetGecerli = int.TryParse(strAdet, out adet);

                if (!adetGecerli)
                {
                    Console.WriteLine("Hata: Geçersiz giriş! Lütfen bir tam sayı girin.");
                    Console.WriteLine();
                }
                else if (adet <= 0)
                {
                    Console.WriteLine("Hata: Adet pozitif bir tam sayı olmalıdır. Lütfen tekrar girin.");
                    Console.WriteLine();
                    adetGecerli = false;
                }
            } while (!adetGecerli);

            double urunFiyati = urunFiyatlari[urunNumarasi - 1];
            toplamSepetTutari += urunFiyati * adet;

            Console.WriteLine($"{urunIsimleri[urunNumarasi - 1]} ürününden {adet} adet sepete eklendi.");
            Console.WriteLine();

        } while (true);

        Console.WriteLine("Alışverişiniz tamamlandı.");
        Console.WriteLine($"Toplam sepet tutarı: {toplamSepetTutari:F2} TL");
    }


    public static void UrunListesiniGoster()
    {
        Console.WriteLine("----- Ürün Listesi -----");
        for (int i = 0; i < urunIsimleri.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {urunIsimleri[i]} ({urunFiyatlari[i]:F0} TL)");
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine();
    }
}