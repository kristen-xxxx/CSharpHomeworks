using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public Shape CreateShape(char shapeNum)
        {
            switch (shapeNum)
            {
                case 'A':
                    return new Triangle();
                case 'B':
                    return new Rectangle();
                case 'C':
                    return new Square();
                case 'D':
                    return new Circle();
                default:
                    throw new Exception("输入错误");
            }
        }
    }
}
