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
                Console.WriteLine("Gör ett val \n\t1: Visa alla studenter \n\t2: Skriv in en ny student \n\t3: Sök student \n\t4: Avsluta");
                int val;
                Int32.TryParse(Console.ReadLine(), out val);
                if (val == 1 | val == 2 || val == 3 || val == 4)
                {
                    switch (val)
                    {
                        case 1: //skriv ut alla studenter med namn och statistik

                            foreach (var item in book.Records)
                            {
                                Console.WriteLine(item.Student.Name);
                                for (int i = 0; i < item.Student.Grades.Count; i++)
                                {
                                    Console.WriteLine(item.Student.Grades[i]);
                                }
                                Console.WriteLine();

                            }

                            break;

                        case 2: //skapa student - namn och betyg - spara i textfil
                            bool createStudent = true;
                            while (createStudent)
                            {
                                Console.WriteLine("Skriv namn på studenten:");
                                string name = Console.ReadLine();
                                List<double> doubleLista = new List<double> { 0.0, 0.0, 0.0, 0.0, 0.0 , 0.0};
                                for (int i = 0; i < doubleLista.Count; i++)
                                {
                                    Random minRnd = new Random();
                                    int min = 1;
                                    int max = 100;
                                    doubleLista[i] = Math.Round(minRnd.NextDouble() * (max - min) - min, 2); //måste snickra om detta
                                }
                                book.AddRecord(new RecordBook(){Student = new Student() { Name = name, Grades = doubleLista } });
                                createStudent = false;
                            }

                            break;

                        

                        case 3: // sök på student - skriv ut med betyg

                            Console.WriteLine("vem vill du söka på?:");
                            string searchstud = Console.ReadLine();
                            
                            foreach (var item in book.Records)
                            {
                                if (item.Student.Name.Contains(searchstud))
                                {
                                    Console.WriteLine(item/*.ToString()*/);

                                }
                                
                            }
                            Console.WriteLine("inga fler träffar");
                            Console.ReadKey();

                            break;

                        case 4:
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
            var lines = File.ReadLines("C:\\temp\\grades.txt").ToList();

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
