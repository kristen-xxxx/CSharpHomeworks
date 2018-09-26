using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Triangle : Shape
    {
        //具体产品类：三角形
        public void GetTheShape()
        {
            int d = 2;
            int h = 2;
            Console.WriteLine("底为"+d+"高为"+h+"的三角形的面积为："+d*h/2);
        }
    }
}
