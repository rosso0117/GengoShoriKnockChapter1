using System;
using System.Linq;

namespace Q02
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "パトカー";
            var str2 = "タクシー";
            Console.WriteLine(Func02(str1, str2));
        }

        static string Func02(string str1, string str2)
        {
            return string.Concat(
                str1.Zip(str2, (c1, c2) => string.Format("{0}{1}", c1, c2)));
        }
    }
}
