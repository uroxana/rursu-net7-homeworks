using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4
{
    public class Events
    {
        public Events() 
        {
            this.nameEvent = nameEvent;
            this.location = location;
            this.price = price;
            this.dayOfEvent = dayOfEvent;
            this.monthOfEvent = monthOfEvent;
            this.yearOfEvent = yearOfEvent;
        }

        public string nameEvent;
        public string location;
        public int price;
        public int dayOfEvent;
        public string monthOfEvent;
        public int yearOfEvent;
        public string EventInformation()
        { return nameEvent + "-"+ dayOfEvent+"/" + monthOfEvent + "/" + yearOfEvent + "-" + price + "$"; }
    }
}
