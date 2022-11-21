//Bir kitap nesnesi için kullanıcı tarafından girilen verileri dosyaya yazan daha listeleyen uygulmayı menü oluşturarak yazma
using Ornek;
Kitap kitap = new Kitap();
while (true)
{
    Console.WriteLine("Veri girişi için 1, veri okumak için 2, çıkmak için herhangi bir tuşa basınız");
    int val = int.Parse(Console.ReadLine());
    switch (val)
    {
        case 1:
            {
                Console.Write("Kitap ID giriniz");
                kitap.KitapID = int.Parse(Console.ReadLine());
                Console.Write("Kitap Adı giriniz");
                kitap.KitapAd = Console.ReadLine();
                Console.Write("Yazarı giriniz");
                kitap.Yazar = Console.ReadLine();
                kitap.Kaydet();
                Console.WriteLine("kaydeldildi...");
                break;
            }
        case 2:
            {
                kitap.Oku();
                break;
            }
        default:
            break;
    }
}