using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    //Find the length of the longest substring in a string without repeating chacraters.

    class LongestSubstring
    {
       /* static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int maxLength = Solution1(str);
            Console.WriteLine(maxLength);
            Console.ReadLine();
        }*/

        public static int Solution1(string str)
        {
            int previous_index = 0;
            string substr = "";
            int maxLength = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!substr.Contains(str[i]))
                {
                    substr = str.Substring(previous_index, (i - previous_index + 1));
                    if (maxLength < substr.Length)
                    {
                        maxLength = substr.Length;
                    }
                }
                else
                {
                    previous_index = i;
                }
            }
            return maxLength;
        }
    }
}
