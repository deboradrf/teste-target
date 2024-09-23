using System;

namespace MyApp // Pergunta 1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            bool pertence = false;
            string sequencia = "0, 1";

            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                pertence = true;
            }
            else
            {
                while (b <= n)
                {
                    c = a + b;
                    a = b;
                    b = c;

                    sequencia += ", " + b;

                    if (b == n)
                    {
                        pertence = true;
                        break;
                    }
                }
            }

            Console.WriteLine("Sequência de Fibonacci: " + sequencia);

            if (pertence)
            {
                Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número informado NÃO pertence à sequência de Fibonacci.");
            }    
        }
    }
}
