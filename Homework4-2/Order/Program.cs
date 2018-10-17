using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class Order
    {
        public struct Info
        {
            public int num;
            public string name;
            public string cust;
        }

        static void Main(string[] args)
        {
            List<Info> infoList = new List<Info>();
            infoList.Add(new Info() { num = 0001, name = "milk", cust = "Kristen" });
            infoList.Add(new Info() { num = 0002, name = "Lemon", cust = "Jackson" });
            infoList.Add(new Info() { num = 0003, name = "Books", cust = "Lucy" });
            infoList.Add(new Info() { num = 0004, name = "cups", cust = "Brandon" });

            ///实现功能
            Console.Write("请选择（输入对应字母）：A.添加订单 B.删除订单 C.修改订单 D.查询订单\t");
            char choice = (char)Console.Read();
            switch (choice)
            {
                case 'A':
                    Console.WriteLine("请输入添加订单的订单号，商品，客户");

                    break;
                case 'B':

                    break;
                case 'C':

                    break;
                case 'D':

                    break;
                default:
                    Console.WriteLine("输入有误");
                    break;
            }
        }

    }

}
