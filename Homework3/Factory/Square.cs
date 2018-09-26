using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //具体产品类：正方形
    public class Square : Shape
    {
        public void GetTheShape()
        {
            int n = 2;
            Console.WriteLine("边长为" + n +"的正方形面积为"+n*n);
        }
    }
}
