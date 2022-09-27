using System;
using System.Collections.Generic;

/* Užpildyti sąrašą atsitiktiniais skaičiais. Išvesti visus lyginius skaičius.*/

namespace NETLesson04_List_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var listNumber = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                listNumber.Add(rand.Next(100));
            }


            foreach (int number in listNumber)
            {
                Console.Write($"{number} "); //sugeneruotas Listas is 10 skaitmenu
            }

            Console.WriteLine(); //Listu atskyrimas

            foreach (int num in listNumber)
            {
                if (num%2 == 0)
                {
                    Console.Write($"{num} ");  //naujas atfiltruotas sarasas                 
                }

            }
            
        }
    }
}
