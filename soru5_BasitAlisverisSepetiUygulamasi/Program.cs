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