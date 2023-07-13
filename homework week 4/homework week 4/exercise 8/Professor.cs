using homework_week_4.exercise_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using homework_week_4.exercise_7;

namespace homework_week_4.exercise_8
{
    /*
     * 
     * Create a class College with the following fields. Use default constructor to assign default values:
- name (Default: "Unknown")
- foundedYear (Default: 0)
- city (Default: "Unknown)

Create a class Student with one constructor to initialize the following values:
- name
- startDate (Date when the student started College)
- endDate
- college
- birthDate

- IsStillStudent method - return True or False if the person is still a student
- GetAge method that return the current age of the Student
- Print() Method (to show all details)

Create a class Professor with multiple constructors to initiliaze the following values:
- name
- faculity
- specialization
- studentsWhoGiveTheirDegree - List of students who give their degree

We will have two constructors:
    - name, faculity, specialization
    - name, faculity, specialization, studentsWhoGiveTheirDegree
     * */
    public class Professor
    {
        public Professor(string name, string faculity, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
            this.faculty = faculty;
        }

        public Professor(string name, string faculity, string specialization, List<Student> students)
        {
            this.name = name;
            this.specialization = specialization;
            this.faculty = faculty;
            this.StudentsWhoGiveTheirDegree = students;
        }

        public string name;
        public string faculty;
        public string specialization;
        public List<Student> StudentsWhoGiveTheirDegree;
    }
}
