using System;
using System.Collections.Generic;

namespace RecordBookApplication.EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input
            List<double> grades = new List<double>() { 45.7, 69.0, 56.8, 90.8, 78.9 };

            Book book = new Book();
            book.AddRecord(new RecordBook() { Student = new Student() { Id = 1, Name = "Ralph", Grades = grades } });

            


            //Todo: Create 3 metoder for Statistics GetHighest, GetLowest & CalcAverage

            //Create Compute Statistics Method

            //Create method to print any List

            //Create Helper class for Sorting & Searching
        }

        private static void BubbleSort(List<double> records)
        {
            
        }

        private static void InsertionSort(List<double> records)
        {
        }

        private static int BinarySearch(List<double> records, double searchItem)
        {
            return -1;
        }

        private static void PrintRecordsList(List<double> records)
        {
            
        }



       

        
    }
}
