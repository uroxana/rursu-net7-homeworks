using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week_4.exercise_7
{
    /*
     * Finally, create a Faculty class that has the following fields:
- firstName
- lastName
- employeeId
- subjectsTaught

The Faculty class should have the following methods:

GetFullName(): returns the faculty member's full name (i.e. first name followed by last name).
GetSubjectsTaught(): returns a list of strings representing the subjects the faculty member teaches.

     * */
    public class Faculty
    {
        public Faculty(string firstName, string lastName, int employeeId, List<string> subjects)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.Subjects = subjects;
        }
        public string firstName;
        public string lastName;
        public int employeeId;
        public string SubjectsTaught;
        List<string> Subjects;

        public string GetFullName()
        {
            return firstName + "  " + lastName;
        }

        public List<string> GetSubjectsTaught()
        {
            return Subjects;
        }
    }
}
