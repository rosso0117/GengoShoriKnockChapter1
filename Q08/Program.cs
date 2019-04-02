using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Q08
{
    class Program
    {
        static void Main(string[] args)
        {
            var encrypted = Cipher("my0Test");
            Console.WriteLine(encrypted);
            var decrypted = Cipher(encrypted);
            Console.WriteLine(decrypted);
        }

        static string Cipher(string str)
        {
            if (!Regex.IsMatch(str, @"[a-z]"))
            {
                return str;
            }

            return string.Concat(
                str.Select(c => Char.IsLower(c) && Char.IsLetter(c)
                    ? (char)(219 - (int)c)
                    : c
                ));
        }
    }
}
