using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03._09_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
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
            
            Console.WriteLine("Максимальное знаение :" + a.Max());
            Console.ReadKey();
        }
    }
}
