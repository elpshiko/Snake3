using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(3, 15, 3, '&');
            hline.Draw();
            VerticalLine vline = new VerticalLine(5, 12, 2, '*');
            vline.Draw();

            Console.ReadLine();
        }
    }
}
