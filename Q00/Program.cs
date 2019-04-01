using System;
using System.Linq;

namespace Q00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func00("stressed"));
        }

        private static string Func00(string str)
        {
            return string.Concat(str.Reverse());
        }
    }
}
