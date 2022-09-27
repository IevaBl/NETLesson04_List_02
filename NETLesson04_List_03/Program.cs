/* Sukurti vardų sąrašą ~5. 
 * Papildyti sąrašą 2 vardais „Napoleonas“, „Asterisas“. 
 * Ištrinti trečią, vietoj „Napoleonas“ įterpti „Kleopatra“ */

using System;
using System.Collections.Generic;
using System.Linq;

namespace NETLesson04_List_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Benediktas", "Marijonas","Elbieta","Ruta","Saule"};
            nameList.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            nameList.Add("Napaleonas");
            nameList.Add("Asteriksas");
            nameList.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            nameList.RemoveAt(3);
            nameList.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            var nr = nameList.IndexOf("Napaleonas");
            nameList.RemoveAt(nr);
            nameList.Insert(nr, "Kleopatra");                
            nameList.ForEach(i => Console.Write("{0}\t", i));

        }
    }
}
