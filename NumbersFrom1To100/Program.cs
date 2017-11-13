using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                Console.WriteLine("The number is: " + n);
            }
            else
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                int a = int.Parse(Console.ReadLine());

                while (a < 1 || a > 100)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter a number in the range [1...100]: ");
                    a = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The number is: " + a);
            }

        }
    }
}
