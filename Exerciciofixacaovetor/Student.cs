using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciciofixacaovetor
{
    class Student
    {
        public string NameStudent { get; set; }
        public string EmailStundet { get; set; }

        public Student(string nameStudent, string emailStudent)
        {
            NameStudent = nameStudent;
            EmailStundet = emailStudent;
        }

        public override string ToString()
        {
            return NameStudent + ", " + EmailStundet;
        }
    }
}
