using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                double totale = spesa - sconto;
                Console.WriteLine($"il totale è {totale}");
            }
            else
            {
                Console.WriteLine($"lo sconto non puo essere effettuato");
            }
            Console.ReadLine();
        }
    }
}
