using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{ 
    class Min_Max
{
    // Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
    static Random rnd = new Random();
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar: ");
        int n;

        try
        {
            Console.Write("n: ");
            if (!int.TryParse(Console.ReadLine(), out n))
                throw new Exception("Nu ati introdus un numar !");

            int Min = rnd.Next(101);
            int Max = rnd.Next(101);


            Console.WriteLine("Secventa data este: ");
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(101);
                Console.Write($"{x} ");
                if (x < Min)
                    Min = x;
                if (x > Max)
                    Max = x;

            }
            Console.WriteLine();
            Console.WriteLine($"Valoarea minima din secventa data este: {Min}.");
            Console.WriteLine($"Valoarea maxima din secventa data este: {Max}.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadKey();
    }
}
}



