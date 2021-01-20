using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 

            Console.WriteLine("Introduceti un numar: ");
            double n;

            try
            {
                Console.Write("n: ");
                if (!double.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                double S = 0;
                double P = 1;

                for (double i = 1; i <= n; i++)
                {
                    S = S + i;
                    P = P * i;
                }

                Console.WriteLine($"Suma numerelor este {S}");
                Console.WriteLine($"Produsul numerelor este {P}");

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
