using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
     class Program
    {
        static void Main(string[] args)
        {
            // sum of squares
            double sum = 0;
            double count = 0;
            // while loop version
          
            /*do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0} sum: {1}", count, sum);
                count++;
            } while (count != 10); 

            // while loop version
            while (count != 10)
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0} sum: {1}", count, sum);
                count++;
            }
            */

            for (int i=0; i < 100; i++)
            {
                if (i % 2 != 0)
                        Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
