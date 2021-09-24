using System;
using System.Collections.Generic;

namespace RecordBookApplication.EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO SWEDEN!");

            //Todo Implement CalcAverge feature
            List<double> myList = new List<double>() { 23.4, 34.5, 65.6 };
            Console.WriteLine(CalcAverage(myList)); 
            //Hejsan Rafeal
            
            //Todo Implement GetHighest & GetLowest feature

        }
        private static double CalcAverage(List<double> list)
        {
            var total = 0.0;

            foreach (var item in list)
            {
                total = total + item;
            }

            return total / list.Count;
        }

    }
}
