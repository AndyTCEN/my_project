using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNum
{
    class Program
    {
//        Given a 32-bit signed integer, reverse digits of an integer.

//Example 1:

//Input: 123
//Output: 321
//Example 2:

//Input: -123
//Output: -321
//Example 3:

//Input: 120
//Output: 21
//Note:
//Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.Write(a.ReverseNum(1534236469));



        }
        public int ReverseNum(int x)
        {
            string d= "";
            string str = "";
            int a;
            int e = 0;
              if (x < 0)
            {
               str += (x * -1).ToString();
            }
            else
            {
                str += x.ToString();
            }
            
                foreach (char c in str.ToCharArray().Reverse())
                {
                    d += c;
                }
                if (x > Math.Pow(-2, 31) && x < Math.Pow(2, 31) - 1&&int.TryParse(d,out e))
                {

                    if (x < 0)
                    {
                        a = int.Parse(d) * (-1);
                    }
                    else
                    {
                        a = int.Parse(d);
                    }


                }
                else
                {
                    a = 0;
                }

             return a;

            }
        }
    }

