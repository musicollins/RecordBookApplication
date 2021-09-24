using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookApplication.EntryPoint
{
    public class Book
    {
        public List<RecordBook> Records { get; set; }

        public Book()
        {
            Records = new List<RecordBook>();
        }

        public void AddRecord(RecordBook record)
        {
            Records.Add(record);
        }






    }
}
