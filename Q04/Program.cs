using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LogExtension;

namespace Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Hi He Lied Because Boron Could Not Oxidize Fluorine. New Nations Might Also Sign Peace Security Clause. Arthur King Can.";
            var res = Func05(str);
            res.DebugLog("Func04");
        }

        static Dictionary<string, int> Func04(string str)
        {
            var indicesGetFirstLetter = new int[] { 1, 5, 6, 7, 8, 9, 15, 16, 19 };

            var res = Regex.Split(str, @"\s")
                .Select((w, i) => indicesGetFirstLetter.Contains(i + 1)
                    ? new { word = w.Substring(0, 1), index = i + 1 }
                    : new { word = w.Substring(0, 2), index = i + 1 })
                .ToDictionary(o => o.word, o => o.index);

            return res;
        }
    }
}
