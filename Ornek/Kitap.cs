using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    internal class Kitap
    {
       
        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }

        public void Kaydet()
        {
            StreamWriter kayıt = new StreamWriter("data.dat", true);

            kayıt.WriteLine(KitapID+" "+KitapAd+" "+Yazar);
            kayıt.Close();
        }

        public void Oku()
        {
            StreamReader okuma = new StreamReader("data.dat");
            while (!okuma.EndOfStream) //dosyanın sonuna geldikmi ?
            {
                Console.WriteLine(okuma.ReadLine()); //Teker teker okuma yöntemi
            }
            okuma.Close();
        }
    }
}
