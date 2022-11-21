//aynı soru farklı yöntemlerle yapmak
using Ornek2;

int secim;
do
{
    Console.WriteLine("1-Kitap ekle");
    Console.WriteLine("2-Kitap listele");
    Console.WriteLine("3-Çıkış");
    Console.Write("\nSeçiminiz = ");
    secim=int.Parse(Console.ReadLine());
    switch (secim)
    {
        case 1:
            Kitap kitap = new Kitap();
            Console.WriteLine("Kitap ID giriniz");
            kitap.KitapID=int.Parse(Console.ReadLine());
            Console.WriteLine("Kitap Adı giriniz");
            kitap.KitapAdi = Console.ReadLine();
            Console.WriteLine("Kitap Fiyatı giriniz");
            kitap.Fiyat =double.Parse (Console.ReadLine());
            KitapDosya.KitapEkle(kitap);
            break;
        case 2:
            Console.WriteLine(KitapDosya.KitapOku());
            break;
        case 3:
            break;
    }
} while (secim !=3);