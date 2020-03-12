using System;

namespace Suite_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			int compteur = 0;
			int N = GetEntier("N");
			string choix = "";

			Console.WriteLine("Quelle version ?");
			Console.WriteLine("1. Non-optimisée");
			Console.WriteLine("2. Optimisée");
			choix =  Console.ReadLine();

			if (choix == "1") 
			{
				Console.WriteLine("Vous avez choisi la version non-optimisée... Attention aux gros chiffres !");
				for (int i = 0; i <= N; i++)
				{
					int[] tabFiboOpti = new int[N + 1];
					SuiteFibonacci(N);
					Console.WriteLine("Valeur de F" + (N - N + compteur) + " : " + SuiteFibonacciOpt(N - N + compteur, ref tabFiboOpti));
					compteur++;
				}
			}
			else if (choix == "2")
			{
				Console.WriteLine("Vous avez choisi la version optimisée.");
				for (int i = 0; i <= N; i++)
				{
					int[] tabFiboOpti = new int[N + 1];
					SuiteFibonacci(N);
					Console.WriteLine("Valeur de F" + (N - N + compteur) + " : " + SuiteFibonacci(N - N + compteur));
					compteur++;
				}
			}
			else
			{
				Console.WriteLine("Ce choix n'est pas valide.");
			}
		}

		static int GetEntier(string N)
		{
			bool ok = false;
			int nb = 0;
			int compteur = 0;
			do
			{
				try
				{
					Console.WriteLine("--- Bienvenue dans le logiciel de Suite de Fibonacci ---");
					Console.WriteLine("--- Pour N > 1 = F(N-1) + F(N-2) ---\n");
					Console.WriteLine("Entrer la valeur de N : ");
					nb = Convert.ToInt16(Console.ReadLine());
					ok = true;
				}
				catch (Exception)
				{
					compteur++;
					Console.WriteLine("Veuillez entrer un entier svp");
					if (compteur >= 10) Console.Write("... Boulet");
					Console.Write("\r\n");
				}
			} while (!ok);

			return (nb);
		}

		static int SuiteFibonacci(int N)
		{
			return N <= 1 ? N : SuiteFibonacci(N - 1) + SuiteFibonacci(N - 2);
		}

		static int SuiteFibonacciOpt(int N, ref int[] tab)
		{
			if (tab[N] == 0)
			{
				 tab[N] = N <= 1 ? N : SuiteFibonacciOpt(N - 1, ref tab) + SuiteFibonacciOpt(N - 2, ref tab);
			}
			return tab[N];
		} 
	}
}
/* N = 0	=>	0
 * N = 1	=>	1
 * N > 1	=> F(N-1) + F(N-2) */