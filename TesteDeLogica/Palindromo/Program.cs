using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe uma palavra para verificar se ela é palíndromo");

                string palavra = Console.ReadLine();

                bool ehPalindromo = EhPalindromo(palavra);

                Console.WriteLine($"A palavra {palavra} {(ehPalindromo ? "é" : "não")} um palíndromo");
            }
        }

        public static bool EhPalindromo(string palavra)
        {
            if (palavra.Length <= 1)
                return true;
            else
            {
                if (palavra[0] != palavra[palavra.Length - 1])
                    return false;
                else
                    return EhPalindromo(palavra.Substring(1, palavra.Length - 2));
            }
        }
    }
}
