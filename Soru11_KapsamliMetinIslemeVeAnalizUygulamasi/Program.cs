/*
 * Harika! Öğrenme şevkinizi ve pekiştirme isteğinizi takdir ediyorum. Önceki Aşama 1 konularının çoğunu bir araya getirecek ve yeni bir problem çözme senaryosu sunacak kapsamlı bir soru hazırladım. Bu soru, temel döngüler, diziler, metotlar, string işlemleri ve hata yönetimi becerilerinizi zorlayacak.

Soru 11: Kapsamlı Metin İşleme ve Analiz Uygulaması
Kullanıcının girdiği bir metni çeşitli şekillerde işleyen ve analiz eden, menü tabanlı bir program yazın. Programınız, metin üzerinde aşağıdaki işlemleri yapabilmelidir:

Metin Girişi ve Doğrulama:

Kullanıcıdan bir metin (cümle veya paragraf) girmesini isteyin.
Metin boş veya sadece boşluklardan oluşuyorsa hata mesajı verin ve tekrar isteyin.
Menü Sistemi:

Kullanıcıya aşağıdaki seçenekleri sunan bir menü gösterin:
Metindeki Harf Türü Dağılımını Göster (Büyük/Küçük Harf, Rakam, Sembol)
En Uzun ve En Kısa Kelimeleri Bul
Belirli Bir Kelimenin Metinde Geçtiği Yerleri Göster
Metindeki Sesli ve Sessiz Harfleri Say
Çıkış
Kullanıcı geçerli bir sayı girene kadar (1-5 arası) hata yönetimi yapın.
Kullanıcı "Çıkış" seçeneğini seçene kadar program menüyü tekrar göstermeye devam etmelidir.
Metotlar ve İşlevsellikler:

MetinGirisAl() Metodu:

Kullanıcıdan metin girmesini isteyen ve geçerli bir metin alana kadar tekrar eden metot.
Aldığı metni string olarak geri döndürsün.
HarfTuruDagitimi(string metin) Metodu:

Metindeki büyük harf, küçük harf, rakam ve diğer karakter (sembol) sayılarını bulup konsola ayrı ayrı yazdırın.
İpucu: char.IsUpper(), char.IsLower(), char.IsDigit() metotlarını kullanın. Geriye kalanlar sembol veya boşluk olarak kabul edilebilir.
KelimeAnalizi(string metin) Metodu:

Metindeki en uzun kelimeyi ve en kısa kelimeyi bulun ve konsola yazdırın.
Eğer birden fazla en uzun/kısa kelime varsa, ilk bulunanı yazdırın.
İpucu: Metni kelimelere ayırmak için string.Split() metodunu StringSplitOptions.RemoveEmptyEntries ile kullanın. Noktalama işaretlerini temizlemeyi unutmayın (string.Replace() ile boşlukla değiştirerek).
KelimeYeriBul(string metin, string arananKelime) Metodu:

Kullanıcıdan aranacak kelimeyi alın (boş olmamalı, hata yönetimi).
Aranan kelimenin metin içinde geçtiği tüm başlangıç indekslerini (konumlarını) bulun ve konsola yazdırın.
Büyük/küçük harf duyarsız arama yapın.
Eğer kelime bulunamazsa "Belirtilen kelime metinde bulunamadı." mesajı yazdırın.
İpucu: metin.ToLower().IndexOf(arananKelime.ToLower(), startIndex) metodunu döngü içinde kullanabilirsiniz.
SesliSessizHarfSayimi(string metin) Metodu:

Metindeki toplam sesli (a, e, ı, i, o, ö, u, ü) ve sessiz harf sayılarını bulun.
Türkçe karakterleri (ç, ğ, ş gibi) de dikkate alarak sadece harf olanları sayın.
Sonuçları konsola yazdırın.
İpucu: char.IsLetter() ile sadece harfleri filtreleyebilirsiniz. Ardından bir switch-case veya if-else if yapısı ile sesli/sessiz ayrımı yapın.
*/
