using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 11, 28, 7, 14, 17, 23, 47 };
            for(int n = 0; n < 7; n++)
            {
                if (n != 6)
                {
                    Console.Write(num[n] + ",");
                }
                else
                {
                    Console.Write(num[n]);
                }
                
            }
            Console.Write("中的素数因子有：");
            for(int n = 0;n<7;n++)
            {
                for(int i = 2; num[n] > i; i++)
                {
                    if (num[n] % i == 0)
                        goto outer;
                }
                Console.Write(" " + num[n]);
                outer:;
            }


        }
    }
}
