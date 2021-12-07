/*1. (6 bodova) Napišite program koji će zatražiti od korisnika da unese tri
dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 ->
17).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj=0;
            int najveci=0;

            Console.WriteLine("Upisi 3 dvoznamenkasta broja: ");

            for (int brojac = 0; brojac < 3; brojac++) 
            { 
                broj= Convert.ToInt32(Console.ReadLine());
                if (broj > 9 && broj<100)
                {
                    if (broj > najveci)
                    {
                        najveci = broj;
                    }

                }
                else
                {
                    brojac--;
                    Console.WriteLine("Unesite dvoznamenkasti broj!");
                }

            }

            Console.WriteLine("Najveći broj je: " + najveci);



            Console.ReadKey();
        }
    }
}
