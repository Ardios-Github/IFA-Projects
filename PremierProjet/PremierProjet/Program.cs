using System;

namespace PremierProjet
{
	class Program
	{
        static void Main(string[] args)
        {
            Random rng = new Random();

            int toto = rng.Next(0, 50);
            string choix = "";
            choix = Console.ReadLine();
            int[] ArrayEntier = new int[10]; // Tableau Vide
            int[] ArrayEntier2 = { 10, 0, 3 };
            int nb = Int16.Parse(choix); // Transforme en entier

            ArrayEntier[0] = 10;

            if (choix == "n")
            {
                for (int index = 0; index < toto; index++)
                {
                    Console.WriteLine(index);
                }

                // for (int index = 0; index < ArrayEntier.Length; index++)
                foreach (int nb in ArrayEntier)
                {
                    Console.WriteLine(nb);
                }
            }
            else
            {
                Console.WriteLine("Faux");
            }

            switch (choix)
            {
                case "a":
                    Console.WriteLine("cas 1");
                    break;
                default:
                    break;

            }
        }
	}
}
