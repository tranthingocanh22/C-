using System;
namespace OutputFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency formatting - {0:C} {1:C4}", 88.8, 888.8);
            Console.WriteLine("Integer formatting - {0:D5}", 88);

            DateTime dt = DateTime.Now; //obtain current time
            Console.WriteLine("Today d format: {0:d}", dt);
            Console.WriteLine("Today D format: {0:D}", dt);

            Console.ReadLine();
        }
    }
}