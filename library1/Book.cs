using System;
using System.Collections.Generic;
using System.Text;

namespace library1
{
    public class Book
    {
        public string Title;
        public string Author;

        public int ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title} \nAuthor: {Author} \nISBN: {ISBN}");
            Console.WriteLine();
        }


    }
}
