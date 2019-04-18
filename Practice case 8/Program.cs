using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_case_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter years of long service for employeer: ");
            int service = int.Parse(Console.ReadLine());
            if (service < 5)
            {
                Console.WriteLine("Premium 10% from salary");
            }
            if ((service < 10) && (service >=5))
            {
                Console.WriteLine("Premium 15% from salary");
            }
            if ((service < 15) && (service >= 10))
            {
                Console.WriteLine("Premium 25% from salary");
            }
            if ((service < 20) && (service >= 15))
            {
                Console.WriteLine("Premium 35% from salary");
            }
            if ((service < 25) && (service >= 20))
            {
                Console.WriteLine("Premium 45% from salary");
            }
            if (service >= 25)
            {
                Console.WriteLine("Premium 50% from salary");
            }
            Console.ReadKey();
        }
    }
}
