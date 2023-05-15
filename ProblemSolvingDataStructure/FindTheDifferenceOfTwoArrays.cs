using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public class FindTheDifferenceOfTwoArrays
    {
        //static void Main(String[] ars)
        //{
        //    int[] nums1 = {1, 2, 3};
        //    int[] nums2 = { 2, 4, 6 };

        //    var data = FindDifference(nums1, nums2);
        //    Console.WriteLine(data);
        //    Console.ReadLine();
        //}

        static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> h1 = new HashSet<int>(nums1), h2 = new HashSet<int>(nums2);

            return new List<IList<int>> {
            h1.Where(x => !h2.Contains(x)).ToList<int>(),
            h2.Where(x => !h1.Contains(x)).ToList<int>()
            };
        }
    }
}
