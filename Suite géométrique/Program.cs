using System;

namespace Suite_géométrique
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = GetEntier("N");
			int Q = GetEntier("Q");
			int Z = GetEntier("Z");

			Console.WriteLine("Pour N = " + N + ", la suite Un+1 = " + Q + " * Un + " + Z);
			Console.WriteLine("vaut : " + SuiteGeometrique(Q,N,Z));

		}
		static int GetEntier(string lettre)
		{
			bool ok = false;
			int nb = 0;
			int compteur = 0;
			do
			{
				try
				{
					Console.WriteLine("Entrer la valeur de " + lettre);
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

		static int SuiteGeometrique(int Q, int N, int Z)
		{
			return ((N == 0) ? 0 : Q * SuiteGeometrique(Q, N - 1, Z) + Z);
		}
	}
}

/*  U0 = 0
	Un + Z = Q * Un + Z
*/