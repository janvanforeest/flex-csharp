using System;

namespace CalcExtraopdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, y1, y2;
            float rad1, rad2;
            float testLength = 15;
            x1 = 50;
            y1 = 50;
            x2 = 60;
            y2 = 50;
            rad1 = 5;
            rad2 = 5;
            float dx = x2 - x1;
            float dy = y2 - y1;
            testLength = 15;
            double length = Math.Sqrt((dx * dx) + (dy + dy));
            
            bool collide = length <= testLength;
            Console.WriteLine(collide);
            
        }
    }
}
