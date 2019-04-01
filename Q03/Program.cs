using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LogExtension;

namespace Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Now I need a drink, alcoholic of course, after the heavy lectures involving quantum mechanics.";
            var res = Func03(str);
            res.DebugLog("res");
        }

        static List<int> Func03(string str)
        {
            var res = Regex.Split(str, @"\s")
                .Select(w => Regex.Replace(w, @"[^a-zA-Z]", "").Count())
                .ToList();
            return res;
        }
    }
}
