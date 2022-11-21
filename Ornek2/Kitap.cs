using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }

        //Kitap oku ve yaz metodu genellikle modele yazılmaz, yönetici sınıfına yazılmalıdır

        public override string ToString()
        {
            return $"{KitapAdi} {KitapID} {Fiyat}";
        }
    }
}
