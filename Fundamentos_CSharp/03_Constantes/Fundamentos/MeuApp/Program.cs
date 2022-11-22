using System;

namespace MeuApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int IDADE_MINIMA = 25; // Correto - Inicia com 25
            // const int IDADE_MINIMA; // Errado
            // const var IDADE_MINIMA = 25; // Errado
            // const var IDADE_MINIMA; // Errado

            var texto = "Testando";
            Console.WriteLine(texto);
        }
    }
}
