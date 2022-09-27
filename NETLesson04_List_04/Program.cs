/* Padaryti meniu tipo programą.
 * Parodomas pažymių sąrašas.
 * Galimi veiksmai: 
 * 0 –papildyti, 1 –ištrinti, 2 –įterpti, 3 –parodyti pažymių vidurkį, 4 –išeiti iš programos */

using System;
using System.Collections.Generic;
using System.Linq;

namespace NETLesson04_List_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            for (; ; )
            {
                Console.WriteLine("Meniu pasirinkimai:");
                Console.WriteLine("0 –papildyti");
                Console.WriteLine("1 –ištrinti");
                Console.WriteLine("2 –įterpti");
                Console.WriteLine("3 –parodyti pažymių vidurkį");
                Console.WriteLine("4 –išeiti iš programos");
                var ats = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (ats)
                {
                    case 0:
                        Console.WriteLine("Papildyk sarasa vienu poazymiu:");                   
                        pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 1:
                        Console.WriteLine(" Is kurios pozicijos pasalinti pazymi?");
                        pazymiai.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Kokia pozicija nori iterpti?");
                        int poz = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Koks pazymis?");
                        int paz = Convert.ToInt32(Console.ReadLine());
                        pazymiai.Insert(poz, paz);
                        break;
                            case 3:
                        Console.WriteLine(pazymiai.Average());              
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                
            }
        }
    }
}
