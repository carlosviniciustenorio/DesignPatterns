using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new("Cliente Fake");
            Facade facade = new();

            var podeEfetuarFinanciamento = facade.PodeEfetuarFinanciamento(cliente);

            Console.WriteLine($"É possível efetuar o financiamento? Resposta: {podeEfetuarFinanciamento}");
        }
    }
}
