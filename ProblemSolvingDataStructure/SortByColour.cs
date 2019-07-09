using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    // Problem 1
    // N objects are given which can be of three colours - red,black,green.
    public class SortByColour
    {
       /* public static void Main(string[] args)
        {
            string[] str = { "Red", "Black", "Green", "Black", "Green", "Red", "Black", "Green", "Black", "Green", "Red", "Black", "Green", "Black", "Green" };

            Solution1(str);
            foreach (var com in str)
                Console.WriteLine(com);
            Console.ReadLine();
        }*/
        public static void Solution1(string[] strArray)
        {
            int lo = 0;
            int mi = 0;
            string temp;
            int hi = strArray.Length - 1;
            while (mi <= hi)
            {
                
                if (strArray[hi] == "Red")
                {
                    hi--;
                }
                else if (strArray[mi] == "Black")
                {
                    if (lo != mi)
                    {
                        temp = strArray[lo];
                        strArray[lo] = strArray[mi];
                        strArray[mi] = temp;
                        lo++;
                    }
                    mi++;
                }
                else if (strArray[mi] == "Red")
                {
                    temp = strArray[hi];
                    strArray[hi] = strArray[mi];
                    strArray[mi] = temp;
                    hi--;
                    if (strArray[mi] == "Black")
                    {
                        if (lo != mi)
                        {
                            temp = strArray[lo];
                            strArray[lo] = strArray[mi];
                            strArray[mi] = temp;
                            lo++;
                        }
                        mi++;
                    }
                }
                else if (strArray[mi] == "Green")
                    mi++;
            }
        }
    }
}
