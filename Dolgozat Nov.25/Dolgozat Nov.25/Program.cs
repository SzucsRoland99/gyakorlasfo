using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Nov._25
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Kérek egy számot:");
            int elso = -1;
            while (elso <= 0)
            {
                Console.WriteLine($"Az első szám: {elso}");
                elso = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Kérek még egy számot:");
            int masodik = 0;
            while (masodik <= 0)
            {
                Console.WriteLine($"A második szám: {masodik}");
                masodik = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Kérek egy műveletet (osztás, szorzás,stb.);");
            string muvelet = Console.ReadLine();

            if (muvelet=="összeadás")
            {
                Console.WriteLine("A két szám összege: " + (elso + masodik));
            }
            else if(muvelet=="kivonás")
            {
                Console.WriteLine("A két szám különbsége: " + (elso - masodik));
            }


            Console.WriteLine($"A két szám: {elso}, {masodik}");

            Console.WriteLine("összeadás: " + (elso + masodik));
            Console.WriteLine("kivonás: " + (elso - masodik));
            Console.WriteLine("osztás: " + (elso % masodik));
            Console.WriteLine("szorzás: " + (elso * masodik));

            if (elso>masodik)
            {
                Console.WriteLine("Az első a  kisebb");
            }
            else
            {
                Console.WriteLine("A második a kisebb");
            }

            Console.ReadKey();
        }
    }
}

