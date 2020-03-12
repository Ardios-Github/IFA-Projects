using System;

namespace Etoiles
{
	class Program
	{
		static void Main(string[] args)
		{
			int nbEtoiles = 0;
			Console.WriteLine("Nb étoiles max ?");
			nbEtoiles = Convert.ToInt16(Console.ReadLine());

			for (int i = 0; i <= nbEtoiles; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("*");
				}
				Console.Write("\r\n");
			}

			for (int i = 0; i <= nbEtoiles; i++)
			{
				for (int j = nbEtoiles-1-i; j < i; j++)
				{
					Console.Write("*");
				}
				Console.Write("\r\n");
			}
		}
	}
}
