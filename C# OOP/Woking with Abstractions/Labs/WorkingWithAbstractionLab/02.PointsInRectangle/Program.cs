using System;
using System.Linq;

namespace _02.PointsInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var topLeft = new Point(input[0], input[1]);

            var bottomRight = new Point(input[2], input[3]);

            var rectangle = new Rectangle(topLeft, bottomRight);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var pointInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Point point = new Point(pointInput[0], pointInput[1]);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
