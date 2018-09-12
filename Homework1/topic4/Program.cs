using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int b = 0;
            Console.Write("Please input A(a number):");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please input B(a number):");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            Console.WriteLine("The product of A and B is " + a * b);

        }
    }
}
