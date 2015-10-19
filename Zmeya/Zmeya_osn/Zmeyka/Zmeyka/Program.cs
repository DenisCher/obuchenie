using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,5,'#');
            p1.Draw();

            Point p2 = new Point(5, 5, '!');
            p2.Draw();

            VerticalLine line = new VerticalLine(6, 10, 1, '|');
            line.Draw();

            Console.ReadLine();
        }
    }
}
