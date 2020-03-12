using System;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{

            Console.WriteLine("Entrez un mot ou une phrase...");
            string phrase = Console.ReadLine();
            int longueur = phrase.Length;

            for (int i = 0; i < longueur / 2; i++)
            {
                if (phrase[i] != phrase[longueur - i - 1])
                    Console.WriteLine("Ce n'est pas un palindrome.");
                else {
                    Console.WriteLine("C'est un palindrome !");
                }
                break;
            }
        }
	}
}
