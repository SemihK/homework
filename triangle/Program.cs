using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavCozumler
{
    class BirinciSoru
    {
        static void Main(string[] args)
        {
            Ucgen testUcgen = new Ucgen(4, 4, 4);
            testUcgen.NeTurUcgen();
            Console.Read();
        }
    }

    class Ucgen
    {
        int BirinciKenar { get; set; }
        int İkinciKenar { get; set; }
        int UcuncuKenar { get; set; }

        public Ucgen(int BirinciKenar, int İkinciKenar, int UcuncuKenar)
        {
            this.BirinciKenar = BirinciKenar;
            this.İkinciKenar = İkinciKenar;
            this.UcuncuKenar = UcuncuKenar;
        }

        public void NeTurUcgen()
        {
            if (BirinciKenar == İkinciKenar && İkinciKenar == UcuncuKenar)
            {
                Console.WriteLine("Eşkenar bir üçgendir.");
            }
            else if (BirinciKenar != İkinciKenar && İkinciKenar != UcuncuKenar && BirinciKenar != UcuncuKenar)
            {
                Console.WriteLine("Çeşitkenar bir üçgendir.");
            }
            else
            {
                Console.WriteLine("İkizkenar bir üçgendir.");
            }
        }
    }
}
