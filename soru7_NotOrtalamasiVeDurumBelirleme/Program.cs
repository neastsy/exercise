/*
 * Harika! O zaman Aşama 1 konularınızı pekiştirmeye devam edelim. İkinci sorumuz geliyor:

Soru 7: Not Ortalaması ve Durum Belirleme
Bir öğrencinin 3 farklı dersten aldığı notları (0-100 arası tam sayılar) ve bu derslerin kredilerini (1-5 arası tam sayılar) kullanıcıdan alın. Bu notlar ve kredilerle öğrencinin ağırlıklı not ortalamasını hesaplayın.

Ortalama hesaplandıktan sonra, öğrencinin durumunu aşağıdaki kurallara göre belirleyip konsola yazdırın:

Ortalama 85 ve üzeri ise: "Takdir Belgesi"
Ortalama 70-84 arası ise: "Teşekkür Belgesi"
Ortalama 50-69 arası ise: "Geçti"
Ortalama 0-49 arası ise: "Kaldı"

*/

Console.WriteLine("--- DERS ORTALAMASI HESAPLAMA ---\n");

bool donusumDers, donusum;
int dersSayisi;
int dersNotu;
int dersKredisi;

do
{
    Console.Write("Ders sayısını girin: ");
string strDers = Console.ReadLine();
donusumDers = int.TryParse(strDers, out dersSayisi);
if (!donusumDers || dersSayisi <= 0)
{
    Console.WriteLine("Lütfen Pozitif Tam Sayı Girin!");
    donusumDers = false;
}
} while (!donusumDers) ;

int[] dersler = new int[dersSayisi];

Console.WriteLine();

for (int i = 0; i < dersSayisi; i++)
{
    do
    {
        Console.Write($"{i + 1}. ders notunu girin(0-100): ");
        donusum = int.TryParse(Console.ReadLine(), out dersNotu);

        if (!donusum || dersNotu < 0 || dersNotu > 100)
        {
            Console.WriteLine("Lütfen geçerli ve 0-100 arası tam sayı girin !");

            donusum = false;
        }
    } while (!donusum);


    dersler[i] = dersNotu;
}

Console.WriteLine();

int[] kredi = new int[dersSayisi];
int krediToplam = 0;
for (int i = 0; i < dersSayisi; i++)
{
    do
    {
        Console.Write($"{i + 1}. ders kredisini girin(1-5): ");
        donusum = int.TryParse(Console.ReadLine(), out dersKredisi);

        if (!donusum || dersKredisi < 1 || dersKredisi > 5)
        {
            Console.WriteLine("Lütfen geçerli ve 1-5 arası tam sayı girin !");

            donusum = false;
        }
    } while (!donusum);

    krediToplam += dersKredisi;
    kredi[i] = dersKredisi;
}

Console.WriteLine("\nDersler\n");

double ortalama = 0;

for (int i = 0; i < dersSayisi; i++)
{
    Console.WriteLine($"{i + 1}. ders notu : {dersler[i]} ve kredisi : {kredi[i]}");
    ortalama += (dersler[i] * kredi[i]) / (double)krediToplam;
}

Console.WriteLine($"\nAğırlıklı Not Ortalaması: {ortalama:F2}\n");

if (ortalama >= 85) 
{
    Console.WriteLine("Takdir Belgesi");
}
else if (ortalama >= 70) 
{
    Console.WriteLine("Teşekkür Belgesi");
}
else if (ortalama >= 50) 
{
    Console.WriteLine("Geçti");
}
else 
{
    Console.WriteLine("Kaldı");
}