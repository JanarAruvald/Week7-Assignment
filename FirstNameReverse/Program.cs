using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string Name = Console.ReadLine();

            if (Name.Length >= 5)
            {
                for (int i = Name.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{Name[i]}");
                    
                }
            }
            else
            {
                Console.WriteLine($"{Name}");
                
            }

        }
    }
}
