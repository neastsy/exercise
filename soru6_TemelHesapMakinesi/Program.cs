/*
 * Soru 1: Temel Hesap Makinesi

Kullanıcıdan iki tam sayı alıp bu sayılar üzerinde toplama, çıkarma, çarpma ve bölme işlemlerini gerçekleştiren basit bir hesap makinesi programı yazın. 
Kullanıcıya hangi işlemi yapmak istediğini sorun ve seçtiği işlemi gerçekleştirip sonucu konsola yazdırın. 
Bölme işleminde ikinci sayının sıfır olma durumunu kontrol edin ve kullanıcıya uygun bir mesaj gösterin.

*/
int sayi1, sayi2;
string strSayi1, strSayi2, strİslem;
char islem;
bool donusum1, donusum2, donusum3;
double sonuc = 0;

Console.WriteLine("Hesap Makinesi");
Console.WriteLine();

do
{
    Console.Write("İlk tam sayıyı girin: ");
    strSayi1 = Console.ReadLine();
    donusum1 = int.TryParse(strSayi1, out sayi1);
    if (!donusum1)
    {
        Console.WriteLine("Hata: Lütfen Tam Sayı Girin!");
    }
} while (!donusum1);


do
{
    Console.Write("Yapılacak işlemi seçin (+ , - , * , /): ");
    strİslem = Console.ReadLine();
    donusum2 = char.TryParse(strİslem, out islem);
    if (!donusum2)
    {
        Console.WriteLine("Tek bir işlem girişi yapın");
    }
    else if (islem != '+' && islem != '-' && islem != '*' && islem != '/')
    {
        Console.WriteLine("Basit işlem girişi yapın!");
        donusum2 = false;
    }
} while (!donusum2);


do
{
    Console.Write("İkinci tam sayıyı girin: ");
    strSayi2 = Console.ReadLine();
    donusum3 = int.TryParse(strSayi2, out sayi2);
    if (!donusum3)
    {
        Console.WriteLine("Hata: Lütfen Tam Sayı Girin!");
    }
    else if (sayi2 == 0 && islem == '/')
    {
        Console.WriteLine("Hata: 0'a bölme işlemi yapılamaz!");
        donusum3 = false;
    }
} while (!donusum3);

switch (islem)
{
    case '+': sonuc = sayi1 + sayi2; break;
    case '-': sonuc = sayi1 - sayi2; break;
    case '*': sonuc = sayi1 * sayi2; break;
    case '/': sonuc = (double)sayi1 / sayi2; break;
}

Console.WriteLine();
Console.WriteLine("Hesaplama Yapılıyor ...");
Console.WriteLine($" {sayi1} {islem} {sayi2} = {sonuc:f2} ");
