using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework_week_4.exercise_7
{
    /*
     * Create a University class that has the following fields: 
- name
- students
- faculties

The students property should be a list of Student objects, and the faculties property should be a list of Faculty objects.

The University class should have the following methods:

- AddStudent(student): adds the specified Student object to the students list.
- AddFaculty(faculty): adds the specified Faculty object to the faculties list.
- GetStudentCount(): returns the number of students at the university.
- GetFacultyCount(): returns the number of faculties at the university.

     */
    public class University
    {
        public University(string name)
        {
            this.name = name;
        }
        public string name;

        List<Faculty> Faculties = new List<Faculty>();
        List<Student> Students = new List<Student>();
        public string AddStudent(Student newStudent)
        {
            this.Students.Add(newStudent);
            return newStudent.GetFullName();
        }

        public string AddFaculty(Faculty newFaculty)
        {
            this.Faculties.Add(newFaculty);
            return newFaculty.GetFullName();
        }//: adds the specified Faculty object to the faculties list.

        public int GetStudentCount()
        {
            return this.GetStudentCount();
        }// : returns the number of students at the university.

        public int GetFacultyCount()
        {
            return this.GetFacultyCount();

        }//: returns the number of faculties at the university.*/
    }
}
