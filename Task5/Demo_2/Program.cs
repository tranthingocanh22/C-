using System;
namespace ImplicitlyTypedAndAnonymous_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Types
            var p1 = new { Name = "A", Price = 3 };
            Console.WriteLine("Name = {0}\nPrice = {1}", p1.Name.ToLower(), p1.Price);

            //Implicitly typed local variables
            var i = 5;
            var s = "helllo";
            Console.WriteLine("type of i: " + i.GetType());
            
            //s is a string
            Console.WriteLine("First letter of s: " + s.Substring(1,1));
            Console.ReadLine();
        }
    }
}