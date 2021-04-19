using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many kilometers is the journey? ");
            double kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many passengers will there be? ");
            int people = Convert.ToInt32(Console.ReadLine());
            kilo = 2*(kilo - 1)+3;
            if (people > 4)
            {
                kilo = kilo + (0.5 * kilo);
            }
            Console.WriteLine("The cost of the journey is £" + kilo);
            Console.ReadKey();
        }
    }
}
