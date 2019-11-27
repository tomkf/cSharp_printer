using System;
using System.Collections.Generic;
using System.Text;

namespace class_lab2
{
    class Assignment
    {
        public string assignmentName;
        public Section section;
        public int total;
        public List<Grade> gradeList = new List<Grade>();

        public Assignment(String assignmentName, Section section, int total)
        {
            this.assignmentName = assignmentName;
            this.section = section;
            this.total = total;
        }       
     }   
}
