using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class Book with one constructor and the following fields:
- title
- author
- year

Add the following methods:
- GetTitle() - returns the book's title.
- GetAuthor() - returns the book's author.
- GetYear() - returns the year the book was published.
- SetTitle(string title) - sets the book's title.
- SetAuthor(string author) - sets the book's author.
- SetYear(int year) - sets the year the book was published.

The following program should work after you implement missing classes:

Book book = new Book("War and Peace", "Leo Tolstoy", 1869);

Console.WriteLine(book.GetTitle()); // Outputs "War and Peace"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1869

book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle()); // Outputs "Anna Karenina"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1877*/

namespace homework_week_4.exercise_3
{
    public class Book
    {
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string title;
        public string author;
        public int year;

        public string GetTitle()
        { return title; }
        public string GetAuthor()
        { return author; }
        public int GetYear()
        { return year; }
        public string SetTitle(string title)
        { 
            this.title = title;
            return title;
        }
        public string SetAuthor(string author)
        {
            this.author = author;
            return author;
        }
        public int SetYear(int year)
        { 
            this.year = year;
            return year;
        }

    }
}
