using System;

namespace Oppgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Meny:");
                Console.WriteLine("1. RotateText");
                Console.WriteLine("2. Change word");
                Console.WriteLine("0. Avslutt");
                Console.Write("Velg et alternativ: ");
                string valg = Console.ReadLine();

                if (valg == "0")
                {
                    break;
                }

                Console.Write("Skriv inn et ord: ");
                string input = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Console.WriteLine("Resultat: " + RotateText(input));
                        break;
                    case "2":
                        Console.WriteLine("Resultat: " + ChangeWord(input));
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static string RotateText(string tekst)
        {
            char[] arr = tekst.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string ChangeWord(string tekst)
        {
            return tekst.Replace('e', 'a');
        }
    }
}