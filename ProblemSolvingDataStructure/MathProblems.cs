using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    class MathProblems
    {
        //public static void Main(string[] args)
        //{
        //    int[] arr = { 5, 6, 2, 0, 0, 4, 6, 2, 4, 9 };

        //    int[] res = MathProblems.PlusOne(arr);
        //    Console.WriteLine("{ 5, 6, 2, 0, 0, 4, 6, 2, 4, 9 }");

        //    foreach(var k in res)
        //    {
        //        Console.WriteLine(k);
        //    }

        //    Console.ReadLine();
        //}

        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            int rem = 0;

            if (digits[len - 1] != 9)
            {
                digits[len - 1] = digits[len - 1] + 1;
                return digits;
            }
            else
            {
                for (int i = len - 1; i >= 0; i--)
                {
                    int num = digits[i];
                    if (i == len - 1)
                    {
                        num = num + 1;
                        digits[i] = 0;
                        rem = 1;
                    }
                    else if (rem == 1)
                    {
                        num++;
                        if (num > 9)
                        {
                            digits[i] = 0;
                            rem = 1;
                        }
                        else {
                            digits[i] = num;
                            rem = 0;
                            return digits;
                        }
                    }
                }

                if (rem == 1)
                {
                    int[] arr = new int[len + 1];

                    arr[0] = 1;
                    for (int i = 0; i < len; i++)
                    {
                        arr[i + 1] = digits[i];
                    }
                }
            }

            return digits;
        }
    }
}