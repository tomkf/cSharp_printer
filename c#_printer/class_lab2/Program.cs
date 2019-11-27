using System;

namespace class_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student testStudent = new Student("A01211467", "John", "Doe");
            Student studentB = new Student("A04211467", "Guy", "Simpson");
            Student studentC = new Student("A05313427", "Josh", "Smith");

            Section testSec = new Section(1, "section a");

            Assignment testA = new Assignment("lab", testSec, 80);

            Grade gradeB = new Grade(studentB, 70);
            Grade gradeC = new Grade(studentC, 95);

            Printer testPrint = new Printer();

            testPrint.PrintStudentNames(testSec);
            testPrint.PrintAssignmentGrades(testA);
            testPrint.PrintAssignmentStudentGrade(testA, testStudent.studentId);
        }
    }
}
