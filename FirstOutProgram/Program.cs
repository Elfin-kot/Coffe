using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOutProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax^2 + bx + c = 0
            // d = b^2 - 4ac
            // x1/2 = (-b +- sqrt(d))/(2a)
            double a , b; 
            double c = 4;

            Console.Write("a =");
            var firstKoef = Console.ReadLine();
            double.TryParse(firstKoef, out a);

            Console.Write("b =");
            var secondKoef = Console.ReadLine();
            double.TryParse(secondKoef, out b);
              
            var d = (b * b) - 4 * a * c; 

            var x1 = (-b + Math.Sqrt(d)) / (2 * a);
            var x2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("x1=" + x1);
            Console.WriteLine("x2=" + x2);

            Console.ReadKey();
        }
    }
}
