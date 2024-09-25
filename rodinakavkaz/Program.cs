using System;

namespace rodinakavkaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 lesson

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());    

            if(Math.Pow(a,2) == b)
            {
                Console.WriteLine("рабетаем дура");
            }
            else
            {
                Console.WriteLine("не работаем");
            }

            int c = int.Parse(Console.ReadLine());
            int d = c - c * 2;

            for (int i = d; i <= c; i++)
            {
                Console.WriteLine(i);
            }*/

            //2 lesson

            /*int a = Convert.ToInt32(Console.ReadLine());

            if(a % 7 == 0 && a % 23 == 0)
            {
                Console.WriteLine("Делится");
            }
            else
            {
                Console.WriteLine("Не делится");
            }*/

            /*int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"1 четверть: [{x},{y}]");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"4 четверть: [{x},{y}]");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"3 четверть: [{x},{y}]");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"2 четверть: [{x},{y}]");
            }*/

            /*int num;

            do
            {
                Console.Write("Введите число от 10 до 99: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 10 || num > 99)
                {
                    Console.WriteLine("куда собрался");
                }

            } while (num < 10 || num > 99);

            int first = num / 10;
            int second = num % 10;

            if(first > second)
            {
                Console.WriteLine($"{first} больше чем {second}");
            }
            else
            {
                Console.WriteLine($"{second} больше чем {first}");
            }*/

            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                //неа не вывез
            }
        }
    }
}
