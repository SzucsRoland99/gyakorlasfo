using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az első számot: ");
            int elso = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második számát: ");
            int masodik = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"A két szám összege: {Osszead( out elso, out masodik)}");
            Console.WriteLine($"A kt szám: {elso},{masodik}");
            Console.WriteLine($"A név: {nev}");

            Console.ReadKey(true);
        }
        /*static int Osszead(int a, int b)
        {
            /*
             //létrehozom a visszatérő értéket és inicializálom
             int osszeg = 0;
             //kiszámolom a visszatérő értéket 
             osszeg = a + b;
             //visszaadom a visszatérő értéket 
             return osszeg;

            int osszeg = 0;
            return osszeg = a + b;
        }*/
        static int Osszead(out int a, out int b, out string nev)
        {
            int osszeg = a + b;

            a=0;
            b=0;
            nev = "Gabor";
            return osszeg;

        }
    
}
