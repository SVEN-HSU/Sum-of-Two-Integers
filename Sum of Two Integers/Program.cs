//https://leetcode.com/problems/sum-of-two-integers/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.MaxValue;
            int q = 10;

            Console.WriteLine(9>>1);

            Console.WriteLine(GetSum(25,18));
            
            Console.ReadLine();


        }

        static int GetSum(int a, int b)
        {
            Console.WriteLine("a = " + a + ", b = " + b);

            if (b == 0)
                return a;

            if (a == 0)
                return b;

            Console.WriteLine("a ^ b =" + Convert.ToString(a ^ b));
            Console.WriteLine("a & b =" + Convert.ToString(a & b));
            Console.WriteLine("(a & b) << 1=" + Convert.ToString((a & b) << 1)+"\n");

            return GetSum(a ^ b, (a & b) << 1);
        }
    }
}
