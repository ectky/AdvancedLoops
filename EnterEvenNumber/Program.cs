using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.Write("Enter even number: ");
            //    int n = int.Parse(Console.ReadLine());
            //    while (n % 2 != 0)
            //    {
            //        Console.WriteLine("Invalid number!");
            //        Console.Write("Enter even number: ");
            //        n = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Even number entered: "+n);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid number!");
            //    Console.Write("Enter even number: ");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Invalid number!");
            //    Console.Write("Enter even number: ");
            //}


            Console.Write("Enter even number: ");
            int n = 0;
            var isValid = int.TryParse(Console.ReadLine(), out n);
            bool valid = n%2==0;
            while (!isValid || !valid )
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter even number: ");
                isValid = int.TryParse(Console.ReadLine(), out n);
                valid = n % 2 == 0;
            }
            Console.WriteLine("Even number entered: " + n);
        }
    }
}
