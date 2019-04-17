using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many seconds pass fron start of day: ");
            int n = int.Parse(Console.ReadLine());
            int hours = n / 3600;
            Console.Write($"Hours pass from start of day: {hours}");
            Console.ReadKey();
        }
    }
}
