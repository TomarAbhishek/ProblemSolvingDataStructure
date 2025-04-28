using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    //Wave Array
    //Given an array of intergers, sort it into a wave such that
    //a1 >= a2 <= a3 >= a4 <= a5.....
    //Given[1, 2, 3, 4]

    class WaveFormArray
    {
        //    public static void Main(string[] args)
        //    {
        //        int[] array = { 1, 4, 3, 2, 8, 9, 10, 12, 15, 14, 33, 54, 21, 22, 6 };
        //        Solution1(array);
        //        foreach (int arr in array)
        //        {
        //            Console.Write(arr + " ");
        //        }
        //        Console.ReadLine();
        //    }
        static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void Solution1(int[] array)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                if (i > 0 && array[i - 1] < array[i])
                {
                    swap(array, i - 1, i);
                }
                if (i < array.Length - 1 && array[i + 1] < array[i])
                {
                    swap(array, i + 1, i);
                }
            }
        }

    }
}
