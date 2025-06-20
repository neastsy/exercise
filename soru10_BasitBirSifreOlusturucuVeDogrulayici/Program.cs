﻿/*
 * Soru 5: Basit Bir Şifre Oluşturucu ve Doğrulayıcı
Kullanıcıdan belirli kriterlere göre bir şifre oluşturmasını isteyen ve ardından bu şifreyi doğrulamaya çalışan basit bir program yazın.

Gereksinimler:

Şifre Oluşturma Metodu (SifreOlustur):

Kullanıcıdan en az 8 karakter uzunluğunda bir şifre girmesini isteyin. (Hata yönetimi: Boş olmamalı, uzunluk kontrolü).
Şifre, büyük harf, küçük harf ve rakam içermelidir. (Hata yönetimi: Bu kriterler sağlanana kadar tekrar isteyin).
string olarak şifreyi geri döndürün.
Şifre Kontrol Metotları (SifreKriterKontrol):

SifreKriterKontrol adında bir metot tanımlayın.
Bu metot, parametre olarak bir string şifre alsın.
Şifrenin en az bir büyük harf, en az bir küçük harf ve en az bir rakam içerip içermediğini kontrol etsin.
Eğer tüm kriterler sağlanıyorsa true, aksi takdirde false döndürsün.
İpucu: char.IsUpper(), char.IsLower(), char.IsDigit() metotlarını kullanabilirsiniz. Bir string'i karakterlerine ayırmak için bir for döngüsü kullanabilirsiniz (sifre[i]).
Ana Program Akışı (Main metodu içinde):

SifreOlustur metodunu çağırarak kullanıcıdan geçerli bir şifre oluşturmasını isteyin. Oluşturulan şifreyi bir değişkende saklayın.
Kullanıcıya oluşturduğu şifreyi tekrar girmesini isteyin (SifreDogrula).
Eğer girilen şifre, oluşturulan şifre ile tamamen aynıysa (büyük/küçük harf duyarlı olarak), "Şifre doğru! Giriş başarılı." mesajı yazdırın.
Eğer girilen şifre oluşturulan şifre ile aynı değilse, "Hatalı şifre! Tekrar deneyin." mesajı yazdırın ve kullanıcı doğru şifreyi girene kadar tekrar tekrar şifre girmesini isteyin. (Bunun için bir do-while veya while döngüsü kullanabilirsiniz).
*/

using System.Drawing;

public class Program
{
    static void Main(string[] args)
    {


        string sifre = SifreOlustur();
        SifreDogrula(sifre);



    }

    public static string SifreOlustur()
    {
        string sifre;
        bool gecerliSifre;
        do
        {
            Console.Write("En az 8 karakter uzunluğunda şifre girin (Büyük harf, küçük harf ve rakam içermelidir.): ");
            sifre = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(sifre) || sifre.Length < 8)
            {
                Console.WriteLine("Şifre boş veya 8 karakterden az olmamalı!");
                gecerliSifre = false;
            }
            else
            {
                gecerliSifre = SifreKriterKontrol(sifre);
                if (!gecerliSifre)
                {
                    Console.WriteLine("Şifre büyük harf, küçük harf ve rakam içermelidir!");
                }
            }
            Console.WriteLine();
        } while (!gecerliSifre);

        return sifre;
    }

    public static bool SifreKriterKontrol(string sifre)
    {
        bool kucukHarf = false;
        bool buyukHarf = false;
        bool sayi = false;

        for (int i = 0; i < sifre.Length; i++)
        {
            if (char.IsUpper(sifre[i]))
            {
                buyukHarf = true;
            }
            else if (char.IsLower(sifre[i]))
            {
                kucukHarf = true;
            }
            else if (char.IsDigit(sifre[i]))
            {
                sayi = true;
            }

            if (kucukHarf && buyukHarf && sayi)
            {
                return true;
            }
        }

        return kucukHarf && buyukHarf && sayi;
    }

    public static bool SifreDogrula(string orjinalSifre)
    {
        string girilenSifre;
        bool eslestiMi;

        do
        {
            Console.Write("Şifrenizi Tekrar Girin: ");
            girilenSifre = Console.ReadLine();
            eslestiMi = (orjinalSifre == girilenSifre);

            if (!eslestiMi)
            {
                Console.WriteLine("Hatalı şifre! Tekrar deneyin.");
            }
            Console.WriteLine();

        } while (!eslestiMi);

        Console.WriteLine("Şifre doğru! Giriş başarılı.");
        return true;
    }

}
