using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LongestPalindromicSubstring
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(LongestPalindrome("cbbd"));
        //    Console.ReadLine();
        //}

        public static bool CheckForPalindrom(string str, int start, int end)
        {
            while(start < end)
            {
                if (str[start] != str[end])
                    return false;
                start++;
                end--;
            }

            return true;
        }
        public static string LongestPalindrome(string s)
        {
            int size = s.Length;
            if (size == 0 || size == 1)
                return s;

            int palLength = 1;
            int start = 0;

            for(int i=0; i<size; i++)
            {
                for(int j=i; j<size; j++)
                {
                    if(CheckForPalindrom(s, i, j) && (j-i+1)>palLength)
                    {
                        start = i;
                        palLength = j - i + 1;
                    }
                }
            }
            return s.Substring(start, palLength);
        }

    }
}
