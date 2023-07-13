using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*Create a Student class that has the following fields: 
- firstName
- lastName
- studentId
- gpa

The Student class should have the following methods:

GetFullName(): returns the student's full name (i.e. first name followed by last name).
HasHonors(): returns a boolean value indicating whether the student has a GPA of 3.5 or higher.


The following program should work after you implement missing classes:

University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, ["Math", "Physics"]);
Faculty bob = new Faculty("Bob", "Smith", 222222, ["English", "History"]);

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2

TO throw an exception use the following code:

throw new Exception(<MESSAGE>: string);*/


namespace homework_week_4.exercise_7
{
    public class Student
    {
        public Student(string firstName, string lastName, int studentId, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }
        public string firstName;
        public string lastName;
        public int studentId;
        public double gpa;
        public string GetFullName()
        { return firstName + "  " + lastName; }

        public bool HasHonors(double gpa)
        {
            return this.gpa >= 3.5;
        }
    }
}
