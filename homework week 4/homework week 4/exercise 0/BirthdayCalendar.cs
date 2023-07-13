using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4
{
    public class BirthdayCalendar
    {
        public BirthdayCalendar(string firstName, string lastName, int dayOfBirth, int monthOfBirth, int yearOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayOfBirth = dayOfBirth;

            if (dayOfBirth < 1 || dayOfBirth > 31)
            {
                Console.WriteLine("invalid dayOfBirth");
            }

            this.monthOfBirth = monthOfBirth;

            if (monthOfBirth < 1 || monthOfBirth > 12)
            {
                Console.WriteLine("invalid monthOfBirth");
            }
            this.yearOfBirth = yearOfBirth;
            if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid");
            }
        }

        public string firstName;
        public string lastName;
        public int dayOfBirth;
        public int monthOfBirth;
        public int yearOfBirth;

        public string GetFirstName()
        { return firstName; }

        public string GetLastName()
        { return lastName; }

        public int GetDayOfBirth(int dayOfBirth)
        {
            this.dayOfBirth = dayOfBirth;
            return dayOfBirth;
        }

        public int MonthOfBirth()
        { return monthOfBirth; }

        public int GetYearOfBirth()
        { return yearOfBirth; }

        public string CompleteName()
        {
            return this.firstName + " " + this.lastName;
        }

        public int BirthDay()
        { return dayOfBirth + monthOfBirth + yearOfBirth; }
    }
}
