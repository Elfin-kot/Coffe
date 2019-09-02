using System;

namespace HomeWork_29._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начнём выполнение Домашнего Задания?\nЕсли да, то введить \"y\"");
            string Start = Console.ReadLine();

            int nom = 0;
            bool example = Start == "y";



            if (example)
            {
                Console.WriteLine("Пример №1:\n\ny=√(x^2+5x+8)\n\nПримечание: Расчёт \"х\" слева направо(-->)\n");

                Console.WriteLine("Укажить целое число для х№1");
                string x1 = Console.ReadLine();
                int.TryParse(x1, out int x_1);

                Console.WriteLine("\nУкажить целое число для х№2");
                string x2 = Console.ReadLine();
                int.TryParse(x2, out int x_2);

                double x1_result = (x_1 * x_1);
                double x2_result = (5 * x_2);
                double result = Math.Sqrt(x1_result + x2_result + 8);
                Console.WriteLine("\nРезультат = {0:#.##}", result);


                Console.WriteLine("\nПерейти к Примеру №2?\nЕсли да, то введить \"y\"");
                string Go = Console.ReadLine();
                int.TryParse(Go, out nom);
                bool example_2 = Go == "y";

                if (example_2 || nom == 2)
                {
                    Console.WriteLine("Пример №2:\n\ny=(3x^2-4)/(x+1)\n");

                    Console.WriteLine("Укажить целое число для х№1");
                    x1 = Console.ReadLine();
                    double.TryParse(x1, out double x_1x);

                    Console.WriteLine("\nУкажить целое число для х№2");
                    x2 = Console.ReadLine();
                    double.TryParse(x2, out double x_2x);

                    result = ((3 * x_1x * x_1x) - 4) / (x_2x + 1);
                    Console.WriteLine("\nРезультат = {0:#.##}", result);


                    Console.WriteLine("\nПерейти к Примеру №3?\nЕсли да, то введить \"y\"");
                    string Go_1 = Console.ReadLine();
                    int.TryParse(Go_1, out nom);
                    bool example_3 = Go_1 == "y";

                    if (example_3 || nom == 3)
                    {

                        Console.WriteLine("Пример №3:\n\nny=x-√(x+2)\n");

                        Console.WriteLine("Укажить целое число для х№1");
                        x1 = Console.ReadLine();
                        double.TryParse(x1, out x_1x);

                        Console.WriteLine("\nУкажить целое число для х№2");
                        x2 = Console.ReadLine();
                        double.TryParse(x2, out x_2x);

                        result = x_1x - Math.Sqrt(x_2x + 2);
                        Console.WriteLine("\nРезультат = {0:#.##}", result);


                        Console.WriteLine("\nПерейти к Примеру №4?\nЕсли да, то введить \"y\"");
                        string Go_2 = Console.ReadLine();
                        int.TryParse(Go_2, out nom);
                        bool example_4 = Go_2 == "y";

                        if (example_4)
                        {
                            Console.WriteLine("Пример №4:\n\ny=(7x+4)/(3x+5)+cosx\n");

                            Console.WriteLine("Укажить целое число для х№1");
                            x1 = Console.ReadLine();
                            double.TryParse(x1, out x_1x);

                            Console.WriteLine("\nУкажить целое число для х№2");
                            x2 = Console.ReadLine();
                            double.TryParse(x2, out x_2x);

                            Console.WriteLine("Укажить целое число для х№3");
                            string x3 = Console.ReadLine();
                            double.TryParse(x3, out double x_3x);

                            result = ((7 * x_1x) + 4) / ((3 * x_2x) + 5) + Math.Cos(x_3x);
                            Console.WriteLine("\nРезультат = " + result);


                            Console.WriteLine("\nПерейти к Примеру №5?\nЕсли да, то введить \"y\"");
                            string Go_3 = Console.ReadLine();
                            int.TryParse(Go_3, out nom);
                            bool example_5 = Go_3 == "y";

                            if (example_5)
                            {
                                Console.WriteLine("Пример №5:\n\ny=x^3+4x^2+x-2\n");

                                Console.WriteLine("Укажить целое число для x№1");
                                x1 = Console.ReadLine();
                                double.TryParse(x1, out x_1x);

                                Console.WriteLine("\nУкажить целое число для х№2");
                                x2 = Console.ReadLine();
                                double.TryParse(x2, out x_2x);

                                Console.WriteLine("Укажить целое число для х№3");
                                x3 = Console.ReadLine();
                                double.TryParse(x3, out x_3x);

                                result = (x_1x * x_1x * x_1x) + (4 * x_2x * x_2x) + x_3x - 2;
                                Console.WriteLine("\nРезультат = " + result);


                                Console.WriteLine("\nПерейти к Примеру №6?\nЕсли да, то введить \"y\"");
                                string Go_4 = Console.ReadLine();
                                int.TryParse(Go_4, out nom);
                                bool example_6 = Go_4 == "y";

                                if (example_6)
                                {
                                    Console.WriteLine("Пример №6:\n\ny=x-sin(3x)\n");

                                    Console.WriteLine("Укажить целое число для х№1");
                                    x1 = Console.ReadLine();
                                    double.TryParse(x1, out x_1x);

                                    Console.WriteLine("\nУкажить целое число для х№2");
                                    x2 = Console.ReadLine();
                                    double.TryParse(x2, out x_2x);


                                    result = x_1x - Math.Sin(3 * x_2x);
                                    Console.WriteLine("\nРезультат = " + result);


                                    Console.WriteLine("\nПерейти к Примеру №7?\nЕсли да, то введить \"y\"");
                                    string Go_5 = Console.ReadLine();
                                    int.TryParse(Go_5, out nom);
                                    bool example_7 = Go_5 == "y";

                                    if (example_7)
                                    {
                                        Console.WriteLine("Пример №7:\n\ny=cos(x)+√x\n");

                                        Console.WriteLine("Укажить целое число для x№1");
                                        x1 = Console.ReadLine();
                                        double.TryParse(x1, out x_1x);

                                        Console.WriteLine("\nУкажить целое число для х№2");
                                        x2 = Console.ReadLine();
                                        double.TryParse(x2, out x_2x);


                                        result = Math.Cos(x_1x) + Math.Sqrt(x_2x);
                                        Console.WriteLine("\nРезультат = " + result);


                                        Console.WriteLine("\nПерейти к Примеру №8?\nЕсли да, то введить \"y\"");
                                        string Go_6 = Console.ReadLine();
                                        int.TryParse(Go_6, out nom);
                                        bool example_8 = Go_6 == "y";

                                        if (example_8)
                                        {
                                            Console.WriteLine("Пример №8:\n\ny=(sin(X)/3)+(tg(x)/6)\n");

                                            Console.WriteLine("Укажить целое число для х№1");
                                            x1 = Console.ReadLine();
                                            double.TryParse(x1, out x_1x);

                                            Console.WriteLine("\nУкажить целое число для х№2");
                                            x2 = Console.ReadLine();
                                            double.TryParse(x2, out x_2x);


                                            result = (Math.Sin(x_1x) / 3) + (Math.Tan(x_2x) / 6);
                                            Console.WriteLine("\nРезультат = " + result);


                                            Console.WriteLine("\nПерейти к Примеру №9?\nЕсли да, то введить \"y\"");
                                            string Go_7 = Console.ReadLine();
                                            int.TryParse(Go_7, out nom);
                                            bool example_9 = Go_7 == "y";

                                            if (example_9)
                                            {
                                                Console.WriteLine("Пример №9:\n\ny=√(x+2)-√(x+3)\n");

                                                Console.WriteLine("Укажить целое число для x№1");
                                                x1 = Console.ReadLine();
                                                double.TryParse(x1, out x_1x);

                                                Console.WriteLine("\nУкажить целое число для х№2");
                                                x2 = Console.ReadLine();
                                                double.TryParse(x2, out x_2x);


                                                result = Math.Sqrt(x_1x + 2) - Math.Sqrt(x_2x + 3);
                                                Console.WriteLine("\nРезультат = " + result);
                                                Console.WriteLine("\nПоздравляю Вы успешно выполнили Домашнее Задание");
                                            }
                                        }
                                    }
                                }
                            }

                        }

                    }
                    Console.ReadKey();
                }
            }

        }
    }
}
