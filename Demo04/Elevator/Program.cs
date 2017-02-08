using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int floor;
            elevator.Floor = 1;

            Console.Write("Mihinkä kerrokseen menään? (1-5) > ");
            string line = Console.ReadLine();

            bool result = int.TryParse(line, out floor);
            elevator.Floor = floor;

            if (result)
            {
                Console.WriteLine("Olet saapunut kerrokseen : " + elevator.Floor);
            }
        }
    }
}
