using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineComparisonProblem
{
    internal class UC1_LineCalculation
    {
        public static void LineCalculation()
        {
            Console.WriteLine("enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var Line = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(Line);
        }
    }
}
