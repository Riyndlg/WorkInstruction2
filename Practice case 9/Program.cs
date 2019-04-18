using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1, operand2;
            string sign;
            string choice = "N";
            do
            {
                Console.WriteLine("Enter value for operands:");
                operand1 = int.Parse(Console.ReadLine());
                operand2 = int.Parse(Console.ReadLine());
                Console.Write("Enter sign for operation: ");
                sign = Console.ReadLine();
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
                        else
                        {
                            Console.WriteLine("Operation was cancelled, error in value of operands. Do you want to try again? Y/N:");
                            choice = Console.ReadLine();
                            choice = choice.ToUpper();
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong value, this operation not exist. Do you want to try again? Y/N:");
                        choice = Console.ReadLine();
                        choice = choice.ToUpper();
                        break;
                }
            }
            while (choice == "Y");
            Console.ReadKey();
        }
    }
}
