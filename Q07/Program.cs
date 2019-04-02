using System;

namespace Q07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func07(12, "気温", 22.4));
        }

        static string Func07(dynamic x, dynamic y, dynamic z)
        {
            return string.Format($"{x}時の{y}は{z}", x as string, y as string, z as string);
        }
    }
}
