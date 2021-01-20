using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n numere: ");
            int x = int.Parse(Console.ReadLine());
            bool ok = false; bool ok2 = false;
            int attempts = 0; // doar o singura data se poate intampla asta!

            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x <= y)
                {
                    if (x <= y)
                        ok = true;
                    else
                    {
                        attempts++;
                        if (attempts == 1 && x >= y)
                            ok2 = true;

                        else
                        {
                            ok = false;
                            break;

                        }

                    }
                    x = y;
                }

            }

            if (ok == true && ok2 == true)
                Console.WriteLine("Secventa este bitonica ROTITA!");
            else
                Console.WriteLine("Secventa NU este bitonica rotita!");
        }
    }
}
