using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4
{
    public class Books
    {
        public Books(string title, string author, int publicationYear, int pages) 
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.pages = pages;
        }
        public string title;
        public string author;
        public int publicationYear;
        public int pages;
        public string BookDescription()
        { return title+ " - " + author + " - " + pages; }

    }
}
