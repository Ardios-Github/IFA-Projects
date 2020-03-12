using System;

namespace PremierExo
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();

			Console.WriteLine("Entrez la taille du tableau : ");
			string choix = "";
			int somme = 0;
			choix = Console.ReadLine();
			int nb = Int16.Parse(choix);	// Transforme le string "choix" en int "nb"
			int[] tab = new int[nb];    // Créé X cases de tableau

			try
			{
				nb = Int16.Parse(choix);
			}
			catch (FormatException)
			{
				Console.WriteLine("Ce n'est pas un entier !");
			}
			finally
			{
				Console.WriteLine("Voilà la liste des chiffres générés aléatoirement.");
			}

			for (int i = 0; i < tab.Length; i++)
			{
				int valeur = rng.Next(0, 50);           // Créé des valeurs aléatoires entre 0 et 50 et les attribue à "valeur"
				tab[i] = valeur;                // Attribue les valeurs de "valeur" dans la case du tableau de l'index
				somme += tab[i];
				Console.Write(" | " + tab[i]);		// Affiche la valeur de l'index du tableau
			}
			Console.WriteLine("\r\n");
			Console.WriteLine("La somme du tableau est : " + somme);
		}
	}
}
