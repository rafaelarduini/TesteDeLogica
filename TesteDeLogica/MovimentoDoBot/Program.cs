using System;

namespace MovimentoDoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe os parâmetros:");
                Console.WriteLine("Coordenada x inicial");
                int xInicial = int.Parse(Console.ReadLine());

                Console.WriteLine("Coordenada y inicial");
                int yInicial = int.Parse(Console.ReadLine());

                Console.WriteLine("Coordenada x final");
                int xFinal = int.Parse(Console.ReadLine());

                Console.WriteLine("Coordenada y final");
                int yFinal = int.Parse(Console.ReadLine());

                bool podeAtingirObjetivo = BotPodeAteingirObjetivo(xInicial, yInicial, xFinal, yFinal);

                Console.WriteLine($"O bot {(podeAtingirObjetivo ? "pode" : "não pode")} atingir seu objetivo.");
            }
        }

        private static bool BotPodeAteingirObjetivo(int xInicial, int yInicial, int xFinal, int yFinal)
        {
            //Chegou na posição
            if (xInicial == xFinal && yInicial == yFinal)
                return true;

            //Passou da posição
            else if (xInicial > xFinal || yInicial > yFinal)
                return false;

            bool retornoAvancoEixoX= false;
            bool retornoAvancoEixoY = false;

            //Da posição (x, y) para a posição (x + y, y)
            if (yInicial > 0)
                retornoAvancoEixoX = BotPodeAteingirObjetivo(xInicial + yInicial, yInicial, xFinal, yFinal);

            //Da posição (x, y) para a posição (x, x + y)
            if (xInicial > 0)
                retornoAvancoEixoY = BotPodeAteingirObjetivo(xInicial, xInicial + yInicial, xFinal, yFinal);

            return retornoAvancoEixoX || retornoAvancoEixoY;
        }
    }
}
