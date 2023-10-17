using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_given_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter first integer: ");
            int x= Convert.ToInt32(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
                Console.ReadLine();
            }

        }
    }
}
