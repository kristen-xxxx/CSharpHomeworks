using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //具体产品类：圆形
    public class Circle : Shape 
    {
        public void GetTheShape()
        {
            int r = 2;
            Console.WriteLine("半径为" + r + "的圆形面积为" + 3.14 * r * r);
        }
    }
}
