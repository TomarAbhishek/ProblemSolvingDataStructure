using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public  class ZigzagConversion
    {
        ///The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
        ///P   A   H   N
        ///A P L S I I G
        ///Y   I   R
        ///And then read line by line: "PAHNAPLSIIGYIR"
        ///Write the code that will take a string and make this conversion given a number of rows:
        ///string convert(string s, int numRows);
        ///Example 1:
        ///Input: s = "PAYPALISHIRING", numRows = 3
        ///Output: "PAHNAPLSIIGYIR"

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(Convert("PAYPALISHIRING", 2));
        //    Console.ReadLine();
        //}
        public static string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1 || numRows == 1)
                return s;

            string[] str = new string[numRows];
            int index = 0;
            int strIndex = 0;
            bool posFlag = true;
            bool negFlag = false;

            while(index < s.Length)
            {
                if (posFlag)
                    str[strIndex++] += s[index];
                if (negFlag)
                    str[strIndex--] += s[index];
                if(strIndex >= str.Length)
                {
                    negFlag = true;
                    posFlag = false;
                    strIndex = strIndex - 2;
                }
                if (strIndex < 0)
                {
                    posFlag = true;
                    negFlag = false;
                    strIndex = strIndex + 2;
                }
                index++;
            }
            string result= string.Empty;
            foreach(var x in str)
            {
                result += x;
            }
            
            return result;

        }
    }
}
