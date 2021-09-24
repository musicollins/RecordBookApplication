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
            CalcAverage(myList);
            
            
            //Todo Implement GetHighest & GetLowest feature

        }
        private static void CalcAverage(List<double> list)
        {
            //no implementation
        }

    }
}
