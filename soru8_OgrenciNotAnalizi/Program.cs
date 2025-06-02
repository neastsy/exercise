/*
 * Soru 8: Öğrenci Not Analizi
Bir sınıftaki belirli sayıda öğrencinin sınav notlarını (0-100 arası tam sayı) tutan bir program yazın. Programınızda aşağıdaki metotları kullanarak öğrenci notları üzerinde analiz yapın:

NotlariAl metodu:

Parametre olarak öğrenci sayısını alsın.
Bu sayı kadar notu kullanıcıdan alsın ve bir tam sayı dizisi (array) olarak geri döndürsün.
Not girişlerinde 0-100 aralığı kontrolü ve int.TryParse ile hata yönetimi yapsın.
OrtalamaHesapla metodu:

Parametre olarak bir tam sayı dizisi (notlar) alsın.
Bu dizideki notların aritmetik ortalamasını hesaplayıp double olarak geri döndürsün.
EnYuksekNotuBul metodu:

Parametre olarak bir tam sayı dizisi (notlar) alsın.
Bu dizideki en yüksek notu bulup int olarak geri döndürsün.
EnDusukNotuBul metodu:

Parametre olarak bir tam sayı dizisi (notlar) alsın.
Bu dizideki en düşük notu bulup int olarak geri döndürsün.
Ana program akışı:

Kullanıcıdan sınıfın kaç öğrenciden oluştuğunu alın. (Pozitif tam sayı olmalı ve hata yönetimi yapılmalı.)
NotlariAl metodunu çağırarak öğrenci notlarını alın.
Alınan notlar dizisini kullanarak OrtalamaHesapla, EnYuksekNotuBul ve EnDusukNotuBul metotlarını çağırın.
Sonuçları (Ortalama, En Yüksek Not, En Düşük Not) konsola yazdırın.
*/

public class Program
{
    static void Main(string[] args)
    {
        int ogrenciSayisi;
        string strOgrenciSayisi;
        bool donusumOgrenciSayisi;
        do
        {
            Console.Write("Öğrenci Sayısını Girin: ");
            strOgrenciSayisi = Console.ReadLine();
            donusumOgrenciSayisi = int.TryParse(strOgrenciSayisi, out ogrenciSayisi);
            if (!donusumOgrenciSayisi)
            {
                Console.WriteLine("Lütfen Tamsayı Girin!");
                Console.WriteLine();
            }
            else if (ogrenciSayisi <= 0)
            {
                Console.WriteLine("Öğrenci Sayısı 0 ve Negatif Olamaz!");
                Console.WriteLine();
                donusumOgrenciSayisi = false;
            }
        } while (!donusumOgrenciSayisi);
        Console.WriteLine();

        int[] ogrenciNotlari = new int[ogrenciSayisi];
        ogrenciNotlari = NotlariAl(ogrenciSayisi);

        int sayac = 1;
        foreach (int i in ogrenciNotlari)
        {

            Console.WriteLine($"{sayac}. Öğrenci Notu: {i}");
            sayac++;
        }
        Console.WriteLine();
        Console.WriteLine($"Sınıfın Not Ortalaması: {OrtalamaHesapla(ogrenciNotlari):F2}\n");
        Console.WriteLine($"En Yüksek Not: {EnYuksekNotuBul(ogrenciNotlari)}\n");
        Console.WriteLine($"En Düşük Not: {EnDusukNotuBul(ogrenciNotlari)} \n");


    }

    public static int[] NotlariAl(int ogrenciSayisi)
    {
        int[] not = new int[ogrenciSayisi];

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            int intNot;
            bool donusum;
            do
            {
                Console.Write($"{i + 1}. Öğrenci Notunu Girin: ");
                string strNot = Console.ReadLine();
                donusum = int.TryParse(strNot, out intNot);
                if (!donusum)
                {
                    Console.WriteLine("Lütfen Tam Sayı Girin!\n");
                }
                else if (intNot < 0 || intNot > 100)
                {
                    Console.WriteLine("Lütfen [0-100] Aralığında Bir Sayı Girin!\n");
                    donusum = false;
                }
            } while (!donusum);

            not[i] = intNot;
        }
        Console.WriteLine();
        return not;

    }


    public static double OrtalamaHesapla(int[] not)
    {
        int sayi = not.Length;
        double toplam = 0;
        for (int i = 0; i < not.Length; i++)
        {
            toplam += not[i];
        }
        double notOrtalamasi = toplam / sayi;
        return notOrtalamasi;
    }

    public static int EnYuksekNotuBul(int[] not)
    {
        int EnYuksek = not[0];
        foreach (int i in not)
        {
            if (i > EnYuksek)
            {
                EnYuksek = i;

            }
        }
        return EnYuksek;
    }
    public static int EnDusukNotuBul(int[] not)
    {
        int EnDusuk = not[0];
        foreach (int i in not)
        {
            if (i < EnDusuk)
            {
                EnDusuk = i;

            }
        }
        return EnDusuk;
    }

}