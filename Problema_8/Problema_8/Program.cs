using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static int Fibo(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write($"Al {n}-lea numar din sirul lui Fibonacci este: ");
                Console.Write(Fibo(n));

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
