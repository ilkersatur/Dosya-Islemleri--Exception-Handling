//Exception Handling (İstisnaların yakalanması)
//1-try -- istisnanın oluşabilceği yerler try bloğuna alınır
//2-catch --- sadece istisna olduğunda çalışır
//3-finally --- istisna olmasına rağgmen kodu çalıştırır
//4-trow --- istisna oluşturmak için kullanılır

using _09._11._2022;

int sayi1=12, sayi2=0, sonuc=0;
//sonuc = sayi1 / sayi2;
Console.WriteLine(sonuc);
Console.WriteLine("Merhaba");
//istisnaları şart ile engellenebiliyorsa şart tercih edilmelidir.

try
{
    sonuc = sayi1 / sayi2;
}
//catch
//{
//    Console.WriteLine("İstisna oluştu");

//}
//exception a göre yapılacakları belirleme
catch(DivideByZeroException ex) { }   
catch(IndexOutOfRangeException ex) { }  

catch(Exception ex)
{
    Console.WriteLine(ex.Message); //istisnanon ne olduğunu söyler
}
finally
{
    //istisna olsada olmasada çalışır
    Console.WriteLine("Her Durumda Çalış");
}
Console.WriteLine(sonuc);
Console.WriteLine("Merhaba");

//throw kullanımı

throw new Exception(); //exception oluşturduk

throw new BesOlamaz(); //exception sınıfından türetip istisna yarattık