using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string name = Console.ReadLine();

            int counter = 0;

            foreach (char character in name)
            {
                 counter++;
            }

            Console.WriteLine($"Nimi {name} on {counter} sümbolit pikk.");





        }
    }
}
