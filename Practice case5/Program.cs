using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for operands:");
            int operand1 = int.Parse(Console.ReadLine());
            int operand2 = int.Parse(Console.ReadLine());
            Console.Write("Enter sign for operation: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if ((operand1 != 0) && (operand2 != 0))
                        Console.WriteLine(operand1 / operand2);
                    else Console.WriteLine("Operation was cancelled, error in value of operands");
                    break;
                default:
                    Console.WriteLine("Wrong value, this operation not exist");
                    break;
            }
            Console.ReadKey();
        }
    }
}
