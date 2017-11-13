using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopByStep31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            for (int i = 1; i <= n; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i+1);
                }
            }
        }
    }
}
