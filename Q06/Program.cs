using System;
using System.Collections.Generic;
using System.Linq;
using LogExtension;

namespace Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = letterNGram("paraparaparadise", 2);
            var Y = letterNGram("paragraph", 2);

            // 和集合
            X.Union(Y).DebugLog("Union");
            // 積集合
            X.Intersect(Y).DebugLog("Intersect");
            // 差集合
            X.Except(Y).DebugLog("Except");

            // seが含まれているか
            if (X.FirstOrDefault(w => w == "se") != null)
            {
                Console.WriteLine("X include se");
            }

            if (Y.FirstOrDefault(w => w == "se") != null)
            {
                Console.WriteLine("Y include se");
            }
        }

        static List<string> letterNGram(string str, int n)
        {
            return str
                .Where((c, i) => i + n <= str.Count())
                .Select((c, i) => str.Substring(i, n))
                .ToList();
        }
    }
}
