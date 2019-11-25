using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyedikgyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //41. es feladat:

            /* for (int i = 65; i < 91; i++)
             {
                 Console.Write((char)i);
             }

             for (int j = 66; j < 91; j++)
             {
                 Console.Write((char)j);
             }
             for (int k = 65; k < 66; k++)
             {
                 Console.Write((char)k);
             }
             Console.WriteLine();*/

            for (int i = 0; i < 27; i++)
            {
                for (int j = 65+i; j < 91; j++)
                {
                    Console.Write((char)j);
                }
                for (int k = 65; k < 65+i; k++)
                {
                    Console.Write((char)k);
                }
                Console.WriteLine();
            }
          

            Console.ReadKey();
        }
    }
}
