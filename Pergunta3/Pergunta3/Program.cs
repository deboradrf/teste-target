using System;

namespace MyApp // Pergunta 3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 12;
            int soma = 0;
            int k = 1;

            do
            {
                k = k + 1;
                soma = soma + k;
            }
            while (k < indice);

            Console.WriteLine("O valor da variável soma é: " + soma);
        }
    }
}