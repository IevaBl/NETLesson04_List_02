/* Padaryti vieną studentų sąrašą. 
 * Padaryti antrą vėliau atvykusių studentų sąrašą.
 * Sujungti abu sąrašus, surūšiuoti ir išvesti */

using System;
using System.Collections.Generic;
using System.Linq;

namespace NETLesson04_List_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "Benas","Jonas","Saulius" };
            studentList.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();

            List<string> moreStudents = new List<string> { "Maryte","Ona","Kotryna" };
            studentList.AddRange(moreStudents);
            studentList.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();

            List<string> sortedList = studentList.OrderBy(x => x).ToList();
            sortedList.ForEach(i => Console.Write("{0}\t", i));
        }
    }
}
