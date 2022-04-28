using System;

namespace Primo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int iteracoes = 0;

                bool ehPrimo = true;

                Console.WriteLine("Informe um número inteiro positivo para verificar se ele é primo");
                int numero = int.Parse(Console.ReadLine());

                if (numero <= 1)
                    ehPrimo = false;
                else
                {
                    //Divide pela raiz quadrada de todos os números (menores ou iguais)
                    for (int i = 2; i <= Math.Sqrt(numero); i++)
                    {
                        iteracoes++;

                        if (numero % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }
                }

                Console.WriteLine($"O número {numero} {(ehPrimo ? "é" : "não")} primo. Número de iterações necessárias: {iteracoes}");                
            }
        }
    }
}
