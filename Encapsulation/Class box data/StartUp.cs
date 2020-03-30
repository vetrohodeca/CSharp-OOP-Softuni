using System;

namespace Class_box_data
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, heigth);
                Console.WriteLine($"Surface Area- {box.calculateSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area- { box.calculateLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume- {box.calculateVolume():f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
