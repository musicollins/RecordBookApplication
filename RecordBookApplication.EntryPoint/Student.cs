using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookApplication.EntryPoint
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<double> Grades { get; set; }
    }
}
