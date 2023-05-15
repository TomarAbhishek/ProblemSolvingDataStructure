using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public class UnCrossedLine
    {
        //public static void Main(string[] args)
        //{

        //    int[] nums1 = { 1, 4, 2 };
        //    int[] nums2 = { 1, 2, 4 };

        //    MaxUncrossedLines(nums1, nums2);
        //    Console.ReadLine();
        //}

        static void MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            int[,] value = new int[nums1.Length + 1, nums2.Length + 1];

            for(int i=1; i<= nums1.Length; i++)
            {
                for (int j = 1; j <= nums2.Length; j++)
                {
                    if (nums1[i-1] == nums2[j-1])
                    {
                        value[i, j] = value[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        value[i, j] = Math.Max(value[i - 1, j], value[i, j - 1]);
                    }
                }
            }

            Console.WriteLine(value[nums1.Length, nums2.Length]);
        }
    }
}
