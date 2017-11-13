using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var f = 1;

            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }

            Console.WriteLine(f);
        }
    }
}
