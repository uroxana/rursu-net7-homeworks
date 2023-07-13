using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4.exercise_8
{
     /*
     * 
     * Create a class College with the following fields. Use default constructor to assign default values:
- name (Default: "Unknown")
- foundedYear (Default: 0)
- city (Default: "Unknown)*/

    public class College
    {
        public College()
        {
            this.name = "Unknown";
            this.foundedYear = 0;
            this.city = "Unknown";
        }

        public string name;
        public int foundedYear;
        public string city;
    }
}
