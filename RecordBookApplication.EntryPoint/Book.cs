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

        private double GetLowest(List<double> records)
        {
            var min = records[0];

            for (int i = 0; i < records.Count; i++)
            {
                if (records[i] < min)
                {
                    min = records[i];
                }
            }

            return min;
        }

        private double GetHighest(List<double> records)
        {
            var max = records[0];

            for (int i = 0; i < records.Count; i++)
            {
                if (records[i] > max)
                {
                    max = records[i];
                }
            }

            return max;
        }

        private double CalcAverage(List<double> list)
        {
            var total = 0.0;

            foreach (var item in list)
            {
                total = total + item;
            }

            return total / list.Count;
        }

        public void ComputeStatistics()
        {
            Console.WriteLine($"The Average is {CalcAverage(Records)}");
            Console.WriteLine($"The Average is {GetHighest(Records)}");
            Console.WriteLine($"The Average is {GetLowest(Records)}");

        }


    }
}
