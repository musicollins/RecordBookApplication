using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookApplication.EntryPoint
{
    public class RecordBook
    {
        public Student Student { get; set; }

        public RecordBook()
        {

        }
        public void AddStudent(Student std)
        {
            Student = std;
        }
    }
}
