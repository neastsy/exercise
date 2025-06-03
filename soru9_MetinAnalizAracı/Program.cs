/*
 * Soru 9: Metin Analiz Aracı
Kullanıcıdan bir metin (cümle) girmesini isteyin. Girdiği metin üzerinde aşağıdaki analizleri yapıp sonuçları konsola yazdıran bir program yazın:

Metindeki toplam karakter sayısı. (Boşluklar dahil)
Metindeki kelime sayısı. (Kelime araları tek boşluk varsayılsın ve noktalama işaretleri kelimeye dahil edilmesin.)
Metnin tüm harflerini küçük harfe çevirerek yazdırın.
Metindeki belirli bir karakterin (kullanıcıdan alınacak) kaç kez geçtiğini bulun ve yazdırın. (Büyük/küçük harf duyarlılığı olmadan arama yapın.)
Metinde belirli bir kelimenin (kullanıcıdan alınacak) bulunup bulunmadığını kontrol edin ve sonucunu yazdırın. (Büyük/küçük harf duyarlılığı olmadan arama yapın.)
*/

using System.Diagnostics.Metrics;
public class Program
{
    static void Main(string[] args)
    {

        string metin = MetinKontrol();
        int topKarakterSayisi = ToplamKarakterSayisi(metin);
        Console.WriteLine($"Toplam Karakter Sayısı: {topKarakterSayisi}");
        int topKelimeSayisi = KelimeSayisi(metin);
        Console.WriteLine($"Metindeki Kelime Sayısı: {topKelimeSayisi}");
        Console.WriteLine($"Metnin küçük harfli hali: {KucukHarfeCevir(metin)}");
        char arananKarakter = CharKontrol();
        int kacKereVar = KacKereKarakterVar(metin, arananKarakter);
        Console.WriteLine($"Aranan karakter '{arananKarakter}' metinde {kacKereVar} kere geçiyor.");
        string arananKelime = KelimeKontrol();
        KelimeVarMi(metin, arananKelime);
    }
   
    public static string MetinKontrol()
    {
        bool metinKontrol;
        string metinMetin;
        do
        {
            Console.Write("Bir metin (cümle) girin: ");
            metinKontrol = true;
            metinMetin = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(metinMetin))
            {
                Console.WriteLine("Lütfen boş bırakmayın!");
                metinKontrol = false;
            }

        } while (!metinKontrol);
        return metinMetin;
    }

    public static string KelimeKontrol()
    {
        bool kelimeKontrol;
        string kelimeMetin;

        do
        {
            Console.Write("Kontrol Edilecek Kelimeyi girin: ");
            kelimeKontrol = true;
            kelimeMetin = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(kelimeMetin))

            {
                Console.WriteLine("Lütfen boş bırakmayın!");
                kelimeKontrol = false;
            }

        } while (!kelimeKontrol);
        return kelimeMetin;
    }

    public static char CharKontrol()
    {
        bool charKontrol;
        string charKarakter;
        char karakter;
        do
        {
            Console.Write("Metinde aranacak karakteri girin: ");
            charKontrol = true;
            charKarakter = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(charKarakter))

            {
                Console.WriteLine("Lütfen boş bırakmayın!");
                charKontrol = false;
            }
            charKontrol = char.TryParse(charKarakter, out karakter);
            if (!charKontrol)
            {
                Console.WriteLine("Sadece Karakter Girişi Yapın!");
                charKontrol = false;
            }
        } while (!charKontrol);

        return karakter;
    }
    public static int ToplamKarakterSayisi(string metin)
    {
        int sayi = metin.Length;
        return sayi;
    }
    public static int KelimeSayisi(string metin)
    {

        string temizlenmisMetin = metin.ToLower();
        char[] noktalamaIsaretleri = { '!', '"', ',', '.', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '/', '\\', '@', '#', '$', '%', '^', '&', '*', '_', '+', '=' };

        foreach (char punc in noktalamaIsaretleri)
        {
            temizlenmisMetin = temizlenmisMetin.Replace(punc, ' ');
        }
        char[] ayirici = new char[] { ' ' };
        string[] kelimeDizisi = temizlenmisMetin.Split(ayirici, StringSplitOptions.RemoveEmptyEntries);

        return kelimeDizisi.Length;

    }

    public static string KucukHarfeCevir(string metin) 
    {
        return metin.ToLower();
    }

    public static int KacKereKarakterVar(string metin, char karakter)
    {
        int sayac = 0;
        char arananKarakterKucuk = Char.ToLower(karakter);
        string kucukMetin = metin.ToLower();

        for (int i = 0; i < kucukMetin.Length; i++)
        {
            if (kucukMetin[i] == arananKarakterKucuk) 
            {
                sayac++;
            }
        }

        return sayac;

    }

    public static void KelimeVarMi(string metin, string kelime)
    {

        string kucukMetin = metin.ToLower();
        string kucukKelime = kelime.ToLower();
        bool kelimeVarMi = kucukMetin.Contains(kucukKelime);

        if (kelimeVarMi)
        {
            Console.WriteLine("Kelime Cümlede Var");
        }
        else
        {
            Console.WriteLine("Kelime Cümlede Yok");
        }
    }
}


