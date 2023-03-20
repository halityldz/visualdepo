using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Sin(Math.PI * 2);
            double y = 30;
            double z = x + 3 * 10 ^ 2;
            if (x < 0 && Math.Log(z) < 6 * Math.Exp(x) || x < 1 - Math.PI)
            {
                Console.WriteLine("in if, x=", x);
            }
            else
            {
                Console.WriteLine("in else, x=", x);
            }
            Console.ReadKey();

        }
    }
}
