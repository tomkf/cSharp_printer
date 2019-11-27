using System;
using System.Collections.Generic;
using System.Text;

namespace class_lab2
{
    class Grade
    {
        public Student gradeStudent;
        public int studentTotal;

        public Grade(Student student, int total)
        {
            this.gradeStudent = student;
            this.studentTotal = total;
        }

    }
}
