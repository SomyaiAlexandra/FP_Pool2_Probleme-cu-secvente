﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        // Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");


                int nr_consecutive = 1;
                int Lungime_Max_secventa = 0;

                int x = rnd.Next(2);

                Console.WriteLine("Secventa data este: ");
                Console.Write($"{x} ");
                for (int i = 0; i < n - 1; i++)
                {

                    int y = rnd.Next(2);
                    Console.Write($"{y} ");

                    if (x == y) //conditia pt ca numerele sa fie consecutive
                    {
                        nr_consecutive++;
                        if (nr_consecutive > Lungime_Max_secventa)
                            Lungime_Max_secventa = nr_consecutive;
                    }
                    else
                        nr_consecutive = 1;


                    x = y;

                }

                Console.WriteLine();

                Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa data este: {Lungime_Max_secventa}");

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
