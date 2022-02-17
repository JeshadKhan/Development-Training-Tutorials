using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace _024__Regular_Expressions
{
    class Program
    {
        private static void ShowMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        static void Main(string[] args)
        {
            /* Finding */
            Console.WriteLine("Finding:\n");
            string str = "A Thousand Splendid Suns";
            Console.WriteLine("Matching words that start with 'S': ");
            ShowMatch(str, @"\bS\S*");
            Console.WriteLine("\n");

            string str2 = "make maze and manage to measure it";
            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            ShowMatch(str2, @"\bm\S*e\b");
            Console.WriteLine("\n\n\n");



            /* Replacement */
            Console.WriteLine("Replacement:\n");
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadKey();
        }
    }
}
