using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        private int maxFloor = 5;
        private int minFloor = 1;

        private int maxfloor, minfloor, floor;
        public int Floor
        {
            get
            {
                return Floor;
            }
            set
            {
                if (value <= maxfloor && value >= minfloor) floor = value;
                else
                {
                    Console.WriteLine("Kerros on salainen, et pääse sinne!");
                    floor = Floor;
                }
            }
        }
    }

}
