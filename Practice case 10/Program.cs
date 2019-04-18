using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive number:");
            int number = int.Parse(Console.ReadLine());
            int factorial = number;
            if (number > 0)
            {
                for (int i = number; i > 1;)
                {
                    factorial = factorial * (i - 1);
                    i--;
                }
                Console.WriteLine($"{number}!={factorial}");
            }
            else Console.WriteLine("You have enter wrong number");
        }
    }
}
