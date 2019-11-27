using System;
using System.Collections.Generic;
using System.Text;

namespace class_lab2
{
    class Section
    {
        public int secNum;
        public string secName;
        public List<Student> studentList = new List<Student>();

        public Section(int secNum, String secName)
        {
            this.secNum = secNum;
            this.secName = secName;
        }
    }
}
