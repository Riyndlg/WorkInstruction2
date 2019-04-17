using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integer numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((b > c && b < a) || (b < c && b > a))
            {
                Console.WriteLine("Число B находится между числами A и C");
            }
            else Console.WriteLine("Число B не находится между числами A и C");
            Console.ReadKey();
        }
    }
}
