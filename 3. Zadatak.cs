/*3. (12 bodova) Definirajte klasu KlasaX sa sljedećim članicama:
a. niz tipa int veličine 100 elemenata arr
b. indeks koji će vraćati i postavljati vrijednost svakog pojedinog člana niza arr.
Definirajte objekt x tipa KlasaX, te koristeći indekse dodijelite nizu arr prvih 100
brojeva i ispišite 50. član niza.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zadatak
{
    class KlasaX
    {
        int[] arr = new int[100];

        public int[] Arr { get => arr; set => arr = value; }
    }
    internal class Program
    {





        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();

            for (int brojac = 0; brojac < 100; brojac++)
            {
                x.Arr[brojac] = brojac + 1;
            }

            Console.WriteLine(x.Arr[50]);

            Console.ReadKey();





        }
    }
}

