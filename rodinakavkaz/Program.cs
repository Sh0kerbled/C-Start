using System;

namespace rodinakavkaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());    

            if(Math.Pow(a,2) == b)
            {
                Console.WriteLine("рабетаем дура");
            }
            else
            {
                Console.WriteLine("ахуеть");
            }
        }
    }
}
