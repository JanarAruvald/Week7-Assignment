using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                string Login;
                string Password;
                Console.WriteLine("Login: ");
                Login = Console.ReadLine();
                Console.WriteLine("Password: ");
                Password = Console.ReadLine();
                Console.WriteLine("PIN-kood: ");
                string PINcode = Console.ReadLine();


                if (PINcode == "1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                
                else if ((Login == "admin") && (Password == "pass1234") && (PINcode == "1234"))
                {
                    Console.WriteLine("Tere tulemast!");
                }
                else if ((Login != "admin") && (Password == "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else if ((Login == "admin") && (Password != "pass1234"))
                {
                    Console.WriteLine("Midagi läks valesti. Proovi uuesti.");
                }
                else
                {
                    i++; //i = i + 1
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");
                }

            }
            
















        }
    }
}
