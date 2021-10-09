using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите координаты точки M");
                Console.WriteLine("введите x");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("введите y");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("введите z");
                double z = double.Parse(Console.ReadLine());
                Console.WriteLine("введите a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("введите b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("введите с");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("введите d");
                double d = double.Parse(Console.ReadLine());
                double p = Math.Abs(a * x - b * y - c - d) / Math.Sqrt(Math.Pow((a), 2) + Math.Pow((b), 2) + Math.Pow((c), 2));
                Console.WriteLine("P={0:F2}", p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
