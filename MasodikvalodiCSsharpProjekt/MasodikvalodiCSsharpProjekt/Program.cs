using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasodikvalodiCSsharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int szam = 0;
              Console.WriteLine("Kérek két számot: ");
              //bool egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
             // Console.WriteLine($"A bekért szám: {szam}");
              do
              {
                  Console.Write("Kérek egy számot: ");
                   egeszSzam = Int32.TryParse(Console.ReadLine(), out szam);
              } while (egeszSzam);
              Console.WriteLine($"A bekért szám: {szam}");*/
            /*  string kimenet = "";
              Console.Write("kérek egy egész számot: ");
              int szam = Convert.ToInt32(Console.ReadLine());
              kimenet += szam;

              while (szam % 2==0)
              {
                  kimenet += 2 + "*";
                  szam = szam / 2;
              }

              kimenet += "=" + szam;
              Console.WriteLine(kimenet);*/

            /*  string kimenet = "";
              Console.Write("Kérek egy pozitiv egész számot: ");
              int szam = Convert.ToInt32(Console.ReadLine());

              kimenet += szam + "=";
              int egesz = 0;
              int tort = szam;

              while (szam -3>0)
              {
                  szam = szam - 3;
                  egesz++;
                  tort = szam - 3;*/


            /*  string alma = "";

              while (alma!="alma")
              {
                  Console.WriteLine("Kérek egy gyümölcsöt: ");
                  alma = Console.ReadLine();

              }
              Console.WriteLine("Az alma gyüm;ölcs: ");*/

            //27.feladat:


            //32.feladat:
            Console.WriteLine("Kérek egy pozitív egész számot: ");
            int szam = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{szam}*{i}={szam * i}");

            }

            //34.feladat:
            

            Console.ReadKey(true);
        }
    }
}
