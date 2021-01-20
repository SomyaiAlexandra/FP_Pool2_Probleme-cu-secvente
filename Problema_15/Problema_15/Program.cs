using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
{
    class Program
    {
       // O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
       // De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. 
       // Se da o secventa de n numere. 
       // Sa se determine daca este bitonica. 
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere de la tastatura: ");
            int x = int.Parse(Console.ReadLine());
            bool ok = false; bool ok2 = false;
            int attempt = 0; // doar o singura data se poate intampla asta!

            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x <= y)
                    ok = true;
                else
                {
                    if (ok2 == false)//se va intampla doar o data, pt prima descrestere
                        attempt++;
                    if (attempt == 1 && x >= y)
                    {
                        ok2 = true;

                    }
                    else
                    {
                        ok2 = false;

                    }

                }
                x = y;
            }
            if (ok == true && ok2 == true)
                Console.WriteLine("Secventa este bitonica!");
            else
                Console.WriteLine("Secventa NU este bitonica!");
        }
    }
}
