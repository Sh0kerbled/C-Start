using System;
using System.Linq;

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

            /*string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                //неа не вывез
            }*/



            /*int[] array = { 1, -5, 6, -7, 3, 6 };
            int num = Convert.ToInt32(Console.ReadLine());
            bool isFound = false;


            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == num)
                {
                    isFound = true;
                    break;
                }
                
            }

            string result = isFound == true ? "работаем дура" : "пошгелн аъуй";
            Console.WriteLine(result);*/

            /*int[] array = { 1, 2, 3, 4, 5 };
            int num = Convert.ToInt32(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    isFound = true;
                }
            }
            string result = isFound == true ? "да" : "нет";
            Console.WriteLine($"r=esult is {result}");*/

            /*int[] array = { 1, -5, 6, -7, 3 };
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = -array[i];
                Console.Write(array[i]+ ", ");
            }*/

            /*int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i] + array[i - i];
                Console.Write(array[i] + ", ");
            }*/

            /*int[] array = { 1, 2, 3, 4, 5 };

            for(int i = 0; i < array.Length; i++)
            {
                array[i]++;
                Console.Write(array[i] + ", ");
            }

            int num = Convert.ToInt32(Console.ReadLine());

            foreach (int number in array)
            {
                if(num == number)
                {
                    Console.WriteLine("работаем дура");
                    break;
                }
                else
                {
                    Console.WriteLine("не работаем дура");
                }
            }

            for(int k = 0; k < array.Length; k++)
            {
                array[k] = -array[k];
                Console.Write(array[k] + ", ");
            }

            int[] array1 = { 5, -3, 9, -1, 2, -7, 0 };
            for(int g = 0; g < array1.Length; g++)
            {
                if(array1[g] >= 0)
                {
                    Console.Write(array1[g] + " ");
                }
            }*/

            int[] array = { 1, 2, 3, 4, 5 };

            int total = array.Sum();

            int result = total / 5;

            Console.WriteLine(result);
        }
    }
}
