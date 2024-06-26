using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine($"{num} is positive");
            else if (num<0)
                Console.WriteLine($"{num} is negative");
            else
                Console.WriteLine($"{num} is not positive or negative");
            Console.ReadKey();
        }
    }
}
