using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_2._09
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firstArray = new int[5] {  1,6,7,3,9};

            for (int i = firstArray.Length - 1; i >  0; i--)
            {
                Console.WriteLine(firstArray[i]);
            }


           

            Console.ReadKey();
        }
    }
}
