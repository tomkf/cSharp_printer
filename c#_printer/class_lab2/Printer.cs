using System;
using System.Collections.Generic;
using System.Text;

namespace class_lab2
{
    class Printer
    {
        public void PrintStudentNames(Section section) {
            // iterate over section studentList. print student.fname
            foreach (Student student in section.studentList)
            {
                Console.WriteLine(student.firstName);
            }
        }

        public void PrintAssignmentGrades(Assignment assignment)
        {
            //iterate over assignment.gradeList. print gradeList.total 
            foreach (Grade grade in assignment.gradeList)
            {
                Console.WriteLine(grade.studentTotal);
            }
        }

        public void PrintAssignmentStudentGrade(Assignment assignment, string studentId)
        {
            //iterate over list, find the student with id passed to function. 
            foreach (Grade grade in assignment.gradeList)
            {
                if(grade.gradeStudent.studentId == studentId)
                {
                    Console.WriteLine(grade.studentTotal);
                }
            }
        }
    }
}
