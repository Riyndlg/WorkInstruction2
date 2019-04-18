using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word about weather in Russian to translate: ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "ветер":
                    Console.WriteLine("wind");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "гололед":
                    Console.WriteLine("ice");
                    break;
                case "ливень":
                    Console.WriteLine("shower");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                case "пасмурно":
                    Console.WriteLine("mainly cloudy");
                    break;
                case "ветрено":
                    Console.WriteLine("windy");
                    break;
                case "ясно":
                    Console.WriteLine("clear");
                    break;
                default:
                    Console.WriteLine("No translation avaivable");
                    break;
            }
            Console.ReadKey();
        }
    }
}
