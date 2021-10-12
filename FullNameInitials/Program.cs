using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string Lastname = Console.ReadLine();

            Console.WriteLine($"Tere, {Firstname[0]}. {Lastname[0]}.!");

        }
    }
}
