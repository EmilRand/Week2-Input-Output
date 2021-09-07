using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja ees nime.
            //program küsib kasutaja perekonninime
            //programm tervitab kasutajat, kasutades neid andmeid

            Console.WriteLine("Mis su nimi on?");
           string FirstName = Console.ReadLine();

            Console.WriteLine("Mis su perekonnanimi on?");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere, {FirstName} {LastName}");



        }
    }
}
