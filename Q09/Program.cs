using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Q09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func09("I couldn't believe that I could actually understand what I was reading : the phenomenal power of the human mind ."));
        }

        static string Func09(string str)
        {
            return string.Join(
                " ",
                Regex.Split(str, @"\s")
                    .Select(w => w.Count() <= 4
                        ? w
                        : string.Format("{0}{1}{2}",
                            w.First(),
                            new string(w.Substring(1, w.Count() - 1).OrderBy(c => Guid.NewGuid()).ToArray()),
                            w.Last())));
        }
    }
}
