//Dosyadan Okuma
StreamReader sr = new StreamReader("data.txt");
/*Console.WriteLine(sr.ReadToEnd());*/ //Okuma metodu

while (!sr.EndOfStream) //dosyanın sonuna geldikmi ?
{
    Console.WriteLine(sr.ReadLine()); //Teker teker okuma yöntemi
}
sr.Close();