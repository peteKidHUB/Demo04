using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();

         
            Console.WriteLine("Anna Jytä taso (0-100): ");
            vahvistin.Volume = int.Parse(Console.ReadLine());
            vahvistin.PrintVolume();
            
        }
    }
}
