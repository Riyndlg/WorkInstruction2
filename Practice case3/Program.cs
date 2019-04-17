using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0 && n > 99 && n < 1000)
            {
                Console.Write("True");
            }
            else Console.Write("False");
            Console.ReadKey();
        }
    }
}
