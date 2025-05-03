using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingDataStructure
{
    public class StringToInteger
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Math.Pow(2, 31));
            int t = StringToInteger.MyAtoi("21474836460");
            //2147483648
            Console.WriteLine(t);
            Console.ReadKey();
        }

        public static int MyAtoi(string s)
        {
            s = s.Trim();
            if (string.IsNullOrEmpty(s) || (s.Length == 1 && (s[0].ToString().Equals("-") || s[0].ToString().Equals("+"))))
                return 0;
            if (int.TryParse(s, out int result))
                return result;

            int number = 0;
            int index = 0;
            while (index < s.Length)
            {
                if (index == 0 && (s[index].ToString().Equals("-") || s[index].ToString().Equals("+")))
                    index++;
                else if (int.TryParse(s[index].ToString(), out int res))
                    index++;
                else
                {
                    break;
                }
            }
            if (index > 0)
            {
                if (index > 1)
                {
                    int negPower = (int)Math.Pow(-2, 31);
                    int posPower = (int)(Math.Pow(2, 31) - 1);
                    double num = double.Parse(s.Substring(0, index));
                    if (num < negPower)
                        number = (int)negPower;
                    else if (num > posPower)
                        number = (int)posPower;
                }
                if (number == 0)
                    number = MyAtoi(s.Substring(0, index));
            }

            return number;
        }
    }
}
