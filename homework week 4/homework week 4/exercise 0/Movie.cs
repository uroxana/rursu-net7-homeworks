using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4
{
    public class Movie
    {
        public Movie() 
        {
            this.name = name;
            this.year = year;
            this.type = type;
            this.raiting = raiting;
        }
        public string name;
        public int year;
        public string type;
        public int raiting;
        public string GetName()
        { return name; }
        public int GetYear() 
        { return year; }
        public string GetType() 
        { return type; }
        public int GetRaiting(int raiting)
        { this.raiting = raiting;
        return raiting;
        }
        public int IncreaseRaiting()
        {
            raiting = raiting + 10;
                return raiting; 
        }
    }
}
