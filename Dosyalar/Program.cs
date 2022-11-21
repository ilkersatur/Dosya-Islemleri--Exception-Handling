//Dosyalar
//ikiye ayrılır
//1-Binary Dosyalar
//--- Header 
//--- DATA
//2-Text Dosyalar

using System.Data.SqlTypes;

StreamWriter sw = new StreamWriter("data.dat",true); //true modu ekleme yapar, verilerin üzerine ekler
sw.WriteLine("Dosyaya Yaz");
sw.WriteLine("Merhaba");
sw.Close();