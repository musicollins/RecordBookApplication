using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RecordBookApplication.EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();



            //Todo: Create 3 metoder for Statistics GetHighest, GetLowest & CalcAverage (DONE)

            //Create Compute Statistics Method (DONE)

            //Create method to print any List (DONE)

            //Create Helper class for Sorting & Searching

            //Process Textfile lines and create Student objects (DONE)
            ReadDatabase(book);



            /*
             * Create a simple menu
             *  1. All Students:
             *      a. Student names ex. Ralph
             *          Name
             *          Statistics
             *  2. Enter New Student (CREATE: SaveToTextFile() )
             *          a. Enter a name
             *                &&
             *          b. Enter Grades
             *  3. Quit:
             *          
             * **/
            bool huvudmeny = true;

            while (huvudmeny)
            {
                Console.WriteLine("Gör ett val 1 - 5");
                int val;
                Int32.TryParse(Console.ReadLine(), out val);
                if (val == 1 | val == 2 || val == 3 || val == 4 || val == 5)
                {
                    switch (val)
                    {
                        case 1: //skriv ut alla studenter med namn och statistik

                            break;

                        case 2: //skapa student - namn och betyg

                            break;

                        case 3: // sök på student - skriv ut med betyg

                            break;

                        case 4: //nåt annat?

                            break;

                        case 5:
                            Console.WriteLine("Avslutar");
                            Console.ReadKey();
                            huvudmeny = false;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Gör ett val 1 - 5");
                    Int32.TryParse(Console.ReadLine(), out val);
                }
            }//




        }

        private static void ReadDatabase(Book book)
        {
            var lines = File.ReadLines("C:\\Users\\Demiurgos\\source\\repos\\RecordBookApplication\\RecordBookApplication.EntryPoint\\grades.txt").ToList();

            for (int i = 0; i < lines.Count - 1; i++)
            {
                if (lines[i].Contains("Name: "))
                {
                    var indexOfColon = lines[i].IndexOf(" ");
                    var name = lines[i].Substring(indexOfColon).Trim();
                    var colon = lines[i + 1].IndexOf(" ");
                    var grades = lines[i + 1].Substring(colon).Trim();

                    var listOfDoubles = ToDoubleList(grades);

                    book.AddRecord(new RecordBook() { Student = new Student() { Name = name, Grades = listOfDoubles } });
                }
            }




            


        }

        private static List<double> ToDoubleList(string grades)
        {
            var result = grades.Split(" ").ToList();
            var resultToDouble = result.ConvertAll(grade => Convert.ToDouble(grade.Replace(".", ",")));
            return resultToDouble;

        }

        private static void InsertionSort(List<double> records)
        {

        }

        private static int BinarySearch(List<double> records, double searchItem)
        {
            int min = 0;
            int max = records.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchItem == records[mid])
                {
                    return records.IndexOf(++mid);
                }
                else if (searchItem < records[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        private static void PrintRecordsList(List<double> records)
        {
            foreach (var item in records)
            {
                Console.WriteLine(item);
            }
        }



       

        
    }
}
