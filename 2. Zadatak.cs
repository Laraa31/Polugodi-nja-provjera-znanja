/* 2. (26 bodova) Definirajte klasu Stablo sa sljedećim članicama:
a. varijabla tipa bool otpadajuListovi
b. varijabla tipa string vrstaStabla
c. svojstvo OtpadajuListovi (get() i set())
d. konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta
varijabli otpadajuListovi
e. override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost
false. Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite
vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je
vrijednost varijable otpadajuListovi true, vrijednost varijable vrstaStabla je
bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, vrijednost
varijable vrstaStabla je crnogorično.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Zadatak
{
    internal class Program
    {
        class Stablo {
            bool otpadajuListovi;

            string vrstaStabla;

            public Stablo()
            {
            }

            public Stablo (bool otpadajuListovi)
            {
                this.otpadajuListovi=otpadajuListovi;
                if (otpadajuListovi == true){
                    vrstaStabla="bijelogoricno";
                }
                else if(otpadajuListovi == false)
                {
                    vrstaStabla = "crnogoricno";
                }
            }

            public void setOtpadajuListovi(bool otpadajuListovi)
            {
                this.otpadajuListovi=otpadajuListovi;
            }

            public void setVrstaStabla(string vrstaStabla)
            {
                this.vrstaStabla = vrstaStabla;
            }
            public bool getOtpadajuListovi()
            {
                return this.otpadajuListovi;
            }

            public string getVrstaStabla()
            {
                return this.vrstaStabla;
            }

            public override string ToString()
            {
                string ispis = "Otpadaju listovi: " + this.getOtpadajuListovi() + ".\n"
                + "Vrsta stabla: " + this.getVrstaStabla() + ".\n";
                return ispis;
            }
        }

        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);

            Stablo stablo2 = new Stablo(false);

            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());

            Console.ReadKey();
        }
    }
}
