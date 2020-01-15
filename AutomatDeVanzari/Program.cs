using System;

namespace AutomatDeVanzari
{
    class Program
    {
        static void Main(string[] args)
        {

            int credit = 0;
            int rest = 0;
            Console.WriteLine("Cafea 1leu");
            while (credit < 100)
            {
                Console.Write("Introduceti o moneda:");
                int n = int.Parse(Console.ReadLine());
                credit += n;
                Console.WriteLine($"Ati introdus:{credit} bani");
            }
            if (credit >= 100)
            {
                Console.WriteLine("Cafeaua se pregateste");
                rest = credit - 100;
                Console.WriteLine($"Rest:{rest}");
            }
           


        }
    }
}
