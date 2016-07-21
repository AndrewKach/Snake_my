using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            HorizontalLine line1 = new HorizontalLine(0, Console.BufferWidth - 1, 0, '+');
            HorizontalLine line2 = new HorizontalLine(0, Console.BufferWidth - 1, 28, '+');
            VerticalLine line3 = new VerticalLine(0, 28, 0, '+');
            VerticalLine line4 = new VerticalLine(0, 28, Console.BufferWidth - 1, '+');
            line1.Drow();
            line2.Drow();
            line3.Drow();
            line4.Drow();



            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine();
        }
    }
}
