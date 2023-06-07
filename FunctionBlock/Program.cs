using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //func to add two numbers
            int a = 5;
            int b = 4;
            int sum = 0;
            int sumsquare = 0;
            sum = Add(a, b);
            sumsquare = Square(a);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("square = {0}", sumsquare);
            Console.ReadLine();
            
        }
        // func to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Square(int a)
        {
            return a * a;
        }
    }
}
