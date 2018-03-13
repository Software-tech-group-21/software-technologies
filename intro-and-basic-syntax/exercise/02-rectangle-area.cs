using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            //input
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            //calculation
            float rectangleArea = width * height;

            //output
            Console.WriteLine($"{area:F2}");

        }
    }
}
