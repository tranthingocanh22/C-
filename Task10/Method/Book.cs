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

