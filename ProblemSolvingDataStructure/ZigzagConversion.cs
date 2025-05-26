using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public  class ZigzagConversion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Convert("PAYPALISHIRING", 3));
            Console.ReadLine();
        }
        public static string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1 || numRows == 1)
                return s;


            return s;

        }
    }
}
