using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num={ 11, 28, 7, 14, 17, 23, 47 };
            int max = num[0];
            int min = num[0];
            for (int i = 1; i < 7; i++)
            {     
                //求最大值
                if (num[i] > max)
                    max = num[i];
                //求最小值
                if (num[i] < min)
                    min = num[i];
            }
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);

            //求和
            int sum = 0;
            foreach(int i in num)
            {
                sum = sum + i;
            }
            //求平均值
            int ave = sum / num.Length;
            Console.WriteLine("数组的和为：" + sum);
            Console.WriteLine("数组的平均值为：" + ave);

        }
    }
}
