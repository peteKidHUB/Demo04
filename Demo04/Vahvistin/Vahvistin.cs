using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Vahvistin
    {
        private readonly int maxVol = 100;
        private readonly int minVol = 0;

        private int vol;

        public int Volume
        {
            get
            {
                return vol;
            }
            set
            {
                if (value <= maxVol) vol = value;
                if (value < minVol)
                {
                    Console.WriteLine("Liian hiljasellaan, naapuri ei kuule! ");
                }
                if (value > maxVol)
                {
                    Console.WriteLine("Tärykalvot rähähtää! ");
                }
            }
        }

        public void PrintVolume()
        {
            Console.WriteLine("Äänen voimakkuus: " + Volume);

        }
    }
}
