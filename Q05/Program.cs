using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LogExtension;

namespace Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetSequence = "I am an NLPer";

            var wRes = wordNGram(convertSequenceToStringList(targetSequence), 2);
            var lRes = letterNGram(convertSequenceToString(targetSequence), 2);

            wRes.DebugLog("wRes");
            lRes.DebugLog("lRes");
        }

        static List<string> convertSequenceToStringList(dynamic sequence)
        {
            List<string> list = new List<string>();
            if (sequence is string str)
            {
                list = Regex.Split(str, @"\s")
                    .ToList();
            }
            else if (sequence is List<string>)
            {
                list = sequence;
            }
            else if (sequence is string[] arr)
            {
                list = arr.ToList();
            }
            else
            {
                throw new ArgumentException("Invalid Arg Type");
            }

            return list;
        }

        static string convertSequenceToString(dynamic sequence)
        {
            string str = string.Empty;
            if (sequence is string)
            {
                return Regex.Replace(sequence, @"\s", "");
            }

            if (sequence is List<string>)
            {
                str = string.Join("", sequence);
            }
            else if (sequence is string[] arr)
            {
                str = string.Join("", sequence);
            }
            else
            {
                throw new ArgumentException("Invalid Arg Type");
            }

            return str;
        }

        static List<List<string>> wordNGram(List<string> list, int n)
        {
            return list
                .Where((w, i) => i + n <= list.Count())
                .Select((w, i) => list.Skip(i).Take(n).ToList())
                .ToList();
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
