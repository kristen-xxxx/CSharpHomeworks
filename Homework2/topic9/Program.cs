using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic9
{
    class Program
    {
        public static void Main(string[] args)
        {
            //建立数组，储存整数2-100
            int [] num = new int[99];
            for(int i = 0;i<99;i++)
            {
                num[i] = i + 2;
            }
            //“埃氏筛法”依次去掉倍数
            for(int n = 2; n <= 100; n++)
            {
                for(int i=0;i<99;i++)
                {
                    if (num[i] % n == 0 && num[i] != n) num[i] = 0;
                }
            }
            Console.Write("2-100以内的素数有：");
            for(int i = 0; i < 99; i++)
            {
                if (num[i] != 0) Console.Write(num[i] + " ");
            }

        }
    }
}
