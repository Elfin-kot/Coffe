using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_03._09
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            double s = 0;

            int[] a = new int[n];

            for (int i = 0; i < n; i++)// введення масиву з клавіатури та обчислення суми

            {

                Console.WriteLine("Ввести {0} елемент масиву", i);

                a[i] = Convert.ToInt32(Console.ReadLine());

                s = s + a[i];

            }

            Console.WriteLine("Даний масив");//виведення даного масиву

            for (int i = 0; i < n; i++)

            {

                Console.Write(a[i] + " ");

            }

            Console.WriteLine();//перехід на початок нового рядка

            IEnumerable<int> numbers = a.Where(x => x > 2.7);
            double sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        
    }
}
