using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            double result;

            Console.WriteLine("y=x1-√x2+2");

            Console.Write("x1=");
            string X1 = Console.ReadLine();
            double.TryParse(X1, out x1);

            Console.Write("x2=");
            string X2 = Console.ReadLine();
            double.TryParse(X2, out x2);

            result = x1 - Math.Sqrt(x2 + 2);

            Console.WriteLine("Результат =" + result);

            Console.WriteLine("Продожим?\nYes/No\tYes=y|n=No");
            string Out = Console.ReadLine();

            string Y = Out;
            bool i = Y == "y";
            
            

            if (i)
            {
                Console.WriteLine("H W");
            }
            else
            {
               Environment.Exit(0); 
            }

        }

    }
}
