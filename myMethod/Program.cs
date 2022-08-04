using System;

namespace myMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int numberB = 10;
            int sum = GetSum(10, numberB);
            Console.WriteLine(sum);
            Console.WriteLine(GetSum(-5, 5));
            GetGefualtColor();
            Console.WriteLine(GetSum(-5 + a + numberB - 2, 5));

            //Program program = new Program(); 

            Console.WriteLine(GetManyParametrs(1, 2, 3, 4));
            Console.WriteLine(GetManyParametrs(1, 2, 5));
            GetColor(ConsoleColor.Yellow);
            Console.WriteLine(GetManyParametrs(z: 20, x: 80, c: 70, y: 90));

            //static int Get()
            //{
            //   return 0;
            //}

            //Console.WriteLine(Get());
        }

        static int GetSum(int a, int b)
        {
            a = 20;
            b = 50;
            return a + b;
        }

        static int GetManyParametrs(int x, int y, int z = 6, int c = -5)
        {
            z = 30;
            return x + y + z + c;
        }

        static void GetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        static void GetGefualtColor()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
