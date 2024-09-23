using System;

namespace MyApp // Pergunta 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            int qntd = 0;

            foreach (char c in palavra)
            {
                if (c == 'a' || c == 'A')
                {
                    qntd++;
                }
            }

            if (qntd == 0)
            {
                Console.WriteLine("A letra 'a'/'A' não foi encontrada na palavra");
            }
            else
            {
                Console.WriteLine($"A letra 'a'/'A' aparece {qntd} vezes na palavra");
            }
        }
    }
}
