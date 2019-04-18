using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number from 0 to 100: ");
            int number = int.Parse(Console.ReadLine());
            if ((number >= 51) && (number <= 100))
            {
                Console.WriteLine("Number between 51-100");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Number between 15-35");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("Number between 36-50");
            }
            else if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("Number between 0-14");
            }
            else Console.WriteLine("Number is out of range 0-100");
            Console.ReadKey();
        }
    }
}
