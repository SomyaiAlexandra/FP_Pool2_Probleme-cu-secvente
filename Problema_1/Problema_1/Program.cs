﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        // Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

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

                int nr = 0;
                Console.WriteLine("Secventa de numere este: ");
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(501);
                    Console.Write($"{x} ");
                    if (x % 2 == 0)
                        nr++;
                }
                Console.WriteLine();
                Console.WriteLine($"In secventa data sunt {nr} pare.");
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
    

