using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //具体产品类：矩形
    public class Rectangle : Shape
    {
        public void GetTheShape()
        {
            int h = 2;
            int d = 3;
            Console.WriteLine("长为"+h+"宽为"+d+"的矩形的面积为：" + d * h);
        }
    }
}
