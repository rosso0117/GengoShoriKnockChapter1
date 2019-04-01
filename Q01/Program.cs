using System;
using System.Linq;
using LogExtension;

namespace Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Func01("パタトクカシーー");
            res.DebugLog("res");
        }

        static string Func01(string str)
        {
            return string.Concat(
                str.Where((c, i) => i % 2 == 1));
        }
    }
}
