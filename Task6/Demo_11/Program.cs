using System;
namespace BookStore
{
    class Books
    {
        static void Main(string[] args) 
        {
            string[] bookTitle = new string[6];
            for (int i = 0; i < bookTitle.Length; i++)
            {
                Console.Write("Enter the title of book : ");
                bookTitle[i] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("List of Books : ");
            foreach(string title in bookTitle)
            {
                bookTitle[3] = "Planet of the Apes";
                Console.WriteLine("Newly changed title of book 4 : " + bookTitle[3]);
            }
        }
    }
}