using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    class LongestSubstringWithoutRepeatingCharacters
    {
        //public static void Main(string[] args)
        //{
        //    string code = "abcAbcbb";

        //    LengthOfLongestSubstring(code);

        //    Console.ReadLine();
        //}

        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int result = 0;
            int[] index = new int[128];

            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                result = Math.Max(result, j - i + 1);
                index[s[j]] = j + 1;
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
