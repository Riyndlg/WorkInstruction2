using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of operation: \n 1: number is positive or negative " +
                "\n 2: number is simple or not \n 3: number divides on 2, 5, 3, 6 or 9 without remainder");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    if (number >= 0)
                    {
                        Console.WriteLine("Number is positive");
                    }
                    else Console.WriteLine("Number is negative");
                    break;
                case "2":
                    bool simple = true;
                    for (int i = 2; i <= number/2; i++)
                    {
                        if (number % i == 0)
                        {
                            simple = false;
                            break;
                        }
                    }
                    if (simple)
                    {
                        Console.WriteLine("Number is simple");
                    }
                    else Console.WriteLine("Number not simple");
                    break;
                case "3":
                    if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 6 == 0) && (number % 9 == 0))
                    {
                        Console.WriteLine("Number divides on 2, 5, 3, 6 or 9 without remainder");
                    }
                    else Console.WriteLine("Number not divides on 2, 5, 3, 6 or 9 without remainder");
                    break;
                default:
                    Console.WriteLine("You enter invalid operation, sorry");
                    break;
            }
            Console.ReadKey();
        }
    }
}
