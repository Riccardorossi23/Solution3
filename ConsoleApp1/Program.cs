using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Totale spesa:");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa > 100)
            {
                double sconto = spesa * 20 / 100;
                Console.WriteLine($"il totale è {sconto}");
            }
            else 
            {
                Console.WriteLine($"lo sconto non puo essere effettuato");
            }
            Console.ReadLine();
        }
    }
}
