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

            Console.SetBufferSize(80, 25);

            VerticalLine LLine = new VerticalLine(1, 24, 1, '|');
            LLine.Draw();

            VerticalLine RLine = new VerticalLine(1, 24, 79, '|');
            RLine.Draw();

            HorizontalLine ULine = new HorizontalLine(1, 79, 0, '—');
            ULine.Draw();

            HorizontalLine DLine = new HorizontalLine(1, 79, 23, '—');
            DLine.Draw();

            Console.ReadLine();
        }
    }
}
