using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineComparisonProblem
{
    internal class UC2_TwoLines
    {
        public static void TwoLines()
        {
            Console.WriteLine("enter values for line 1");
            Console.WriteLine("enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var Line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("length of line 1: " + Line1);
            Console.WriteLine("------------------------");


            Console.WriteLine("enter values for line 2");
            Console.WriteLine("enter x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            var Line2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            Console.WriteLine("Length of line 2: " + Line2);
            Console.WriteLine("------------------------");

            if (Line1 == Line2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}
