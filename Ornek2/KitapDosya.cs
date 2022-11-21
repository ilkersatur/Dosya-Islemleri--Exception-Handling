using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ornek2
{
    internal static class KitapDosya
    {
        public static void KitapEkle(Kitap kitap)
        {
            StreamWriter sw = new StreamWriter("kitap.txt",true);
            sw.WriteLine(kitap); //polimorfizim uyguladık
            sw.Close();
        }
        public static string KitapOku()
        {
            string data = "";
            StreamReader sr = new StreamReader("kitap.txt");
            
            data=sr.ReadToEnd();
            sr.Close();
            return data;

        }
    }
}
