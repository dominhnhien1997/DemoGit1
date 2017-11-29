using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xin chao");
            Console.WriteLine("thuc hien phep cong");
            int a, b;
            Console.WriteLine("nhap a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap b");
            b = Convert.ToInt16(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("tong cua hai so la :"+c);
            Console.ReadKey();
        }
    }
}
