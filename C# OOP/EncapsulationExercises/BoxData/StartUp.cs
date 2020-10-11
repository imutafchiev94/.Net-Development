using System;

namespace BoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            var box = new Box(lenght, height, width);

            box.SurfaceArea();

            box.LateralSurfaceArea();

            box.Volume();
        }
    }
}
