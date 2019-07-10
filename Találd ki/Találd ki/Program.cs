using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Találd_ki
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int CN = random.Next(1, 11);

            int anscount = 0;

            bool match = false;

            while (!match && (anscount < 10))
            {
                Console.WriteLine("Gonndoltam egy számra, találd ki hogy melyik az. (1-és 10 között van)");
                int x = int.Parse(Console.ReadLine());
                anscount++;
                if (x==CN)
                {
                    Console.WriteLine("Kitaláltad!");
                    match = true;
                }
                else
                {
                    Console.WriteLine("Ez most nem talált, próbáld ujra!");
                    Console.WriteLine("Vigyázz ez volt a " + anscount + ". ötleted.");
                    if(anscount==10)
                    {
                        Console.WriteLine("Ez most nem sikerült. a válasz " + CN + "volt");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
