using System;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace Population
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alpha = 0.1, beta = 0.01, gamma = 0.06, delta = 0.0001, rabbits = 0, wolfs = 0, years = 0;
            WriteLine("РЕШЕНИЕ ЗАДАЧИ:\nПопуляция кроликов и волков\n");
            WriteLine("Введите стартовое количество кроликов (rabbits > 0).");
            while (rabbits <= 0)
            {
                Write("rabbits = ");
                try
                {
                    rabbits = ToDouble(ReadLine());
                }
                catch (FormatException) { }
            }
            WriteLine("Введите стартовое количество волков (wolfs > 0).");
            while (wolfs <= 0)
            {
                Write("wolfs = ");
                try
                {
                    wolfs = ToDouble(ReadLine());
                }
                catch (FormatException) { }
            }
            WriteLine("Введите целое количество отслеживаемых лет (years > 0).");
            while (years <= 0)
            {
                Write("years = ");
                try
                {
                    years = ToInt32(ReadLine());
                }
                catch (FormatException) { }
            }
            WriteLine("\nyear / rabbits / wolfs");
            for (int i = 1; i <= years; i++)
            {
                WriteLine($"{i} / {Round(rabbits)} / {Round(wolfs)}");
                rabbits = rabbits + alpha * rabbits - beta * rabbits * wolfs;
                wolfs = wolfs - gamma * wolfs + delta * rabbits * wolfs;
            }
            ReadKey();
        }
    }
}
