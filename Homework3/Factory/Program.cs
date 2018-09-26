using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape MyShape;
            try
            {
                Factory factory = new Factory();
                Console.Write("请选择（输入对应字母）：A.三角形，B.矩形，C.正方形，D.圆形\t");
                char choice = (char)Console.Read();
                switch (choice)
                {
                    case 'A':
                        MyShape = factory.CreateShape('A');
                        MyShape.GetTheShape();
                        break;
                    case 'B':
                        MyShape = factory.CreateShape('B');
                        MyShape.GetTheShape();
                        break;
                    case 'C':
                        MyShape = factory.CreateShape('C');
                        MyShape.GetTheShape();
                        break;
                    case 'D':
                        MyShape = factory.CreateShape('D');
                        MyShape.GetTheShape();
                        break;
                    default:
                        Console.WriteLine("输入有误");
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
   
        }
    }
}
