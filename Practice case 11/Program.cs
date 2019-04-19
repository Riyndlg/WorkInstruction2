using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //строка
            for (int i = 0; i < 15; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            //прямоугольник
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            //прямоугольный треугольник
            int temp = 19;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j >= temp)
                        {
                            Console.Write(" ");
                        }
                    else Console.Write("*");
                }
                Console.Write("\n");
                temp--;
            }
            Console.Write("\n");
            //равносторонний треугольник
            temp = 10;
            int temp1 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((j > temp1) && (j < temp))
                        {
                            Console.Write("*");
                        }
                    else Console.Write(" ");
                }
                Console.Write("\n");
                temp--;
                temp1++;
            }
            Console.WriteLine();
            //ромб
            temp = 10;
            temp1 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((j < temp1) && (j > temp))
                        {
                            Console.Write("*");
                        }
                    else Console.Write(" ");
                }
                Console.Write("\n");
                temp--;
                temp1++;
            }
            temp = 10;
            temp1 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((j > temp1) && (j < temp))
                        {
                            Console.Write("*");
                        }
                    else Console.Write(" ");
                }
                Console.Write("\n");
                temp--;
                temp1++;
            }
            Console.ReadKey();
        }
    }
}
