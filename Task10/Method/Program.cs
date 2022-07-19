using System;

namespace Method
{
    class Book
    {
        String bookName;
        public string Print()
        {
            return bookName;
        }
        public void Input(String bkName)
        {
            bookName = bkName;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.Input("C#- The Complete Reference");
            Console.WriteLine(objBook.Print);
            Console.ReadKey();
        }
    }
}