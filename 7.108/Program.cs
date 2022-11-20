using System;

namespace _7._108
{
    class Program
    {
        static int Metod(string Name, int Min = int.MinValue, int Max = int.MaxValue)
        {
            Console.WriteLine($"Введите {Name}:");
            int Num;
            while (!(int.TryParse(Console.ReadLine(), out Num) && Num >= Min && Num <= Max)) Console.WriteLine($"Введено неверное значение, введите {Name}");
            return Num;
        }
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int a = Metod("количество членов последовательности");
            int b = Metod("число M");
            int c = Metod("число P");
            int d;
            int e = 0;
            for (int i = 1; i <= a; i++)
            {
                d = rdm.Next(0, 100);
                if (d > b) e++;
                Console.Write(d + " ");
            }
            Console.WriteLine(e % c == 0 ? $"\n{e} кратно {c}" : $"\n{e} НЕ кратно {c}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
