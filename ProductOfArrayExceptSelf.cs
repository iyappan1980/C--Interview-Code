using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class ProductOfArrayExceptSelf
    {

        public static void ProductExceptSelf(int[] num)
        {
            var res = new int[num.Length];
            Array.Fill(res, 1);
            int pre = 1;
            int post = 1;
            for (int i = 0; i <= num.Length-1; i++)
            {
                res[i] = pre;
                //Console.WriteLine(res[i]);
                //Console.WriteLine(num[i] + " * " + pre + " = (new pre) " + num[i] * pre);
                pre = num[i] * pre;
                
            }
            // 005, 004, 003,002, 006 - input
            // 001, 005, 020,060, 120 - 
            // 144, 036, 012,006, 001 -
            // 144, 180, 240,360. 120
            for (int j=num.Length - 1; j >= 0; j--)
            {
                //Console.WriteLine(res[j] + " * " + post + " = " + res[j] * post);
                res[j] = res[j]*post;
                //Console.WriteLine(post + " * " + num[j] + " = (New post)" + post * num[j]);
                post = post * num[j];
            }

            foreach(var numVariale in res)
            {
                Console.WriteLine(numVariale);
            }
        }
        public static void ProductExceptSelf_AlternateSolution(int[] num)
        {
            var res = new int[num.Length];
            for(int i=0; i <= num.Length - 1; i++)
            {
                int total = 1;
                for(int j=0; j <= num.Length - 1; j++)
                {
                    if (num[i] != num[j])
                    {
                        total = num[j] * total;
                    }
                }
                res[i] = total;
            }
            foreach(var numVariale in res)
            {
                Console.WriteLine(numVariale);
            }
        }
    }
}
