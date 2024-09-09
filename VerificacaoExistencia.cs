using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    internal class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            // Indexa a Palavra digitada utilizando o LINQ;
            var palavra_indexada = palavra.Select(c => c.ToString()).ToList();

            int contagem = 0;

            foreach (var letra in palavra_indexada)
            {
                if (letra == "a" || letra == "A")
                {
                    contagem += 1;
                }
            }

            Console.WriteLine($"O número total de A's na palavra é de {contagem}");
        }
    }
}
