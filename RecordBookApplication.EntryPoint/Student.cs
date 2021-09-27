using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookApplication.EntryPoint
{
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public override string ToString()
        {
            return "Student: " + Name + " " + Grades;
        }
    }
}
