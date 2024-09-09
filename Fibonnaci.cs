using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Digite um número para verificar se o mesmo pertence à sequência de Fibonacci:");
        int numero = int.Parse(Console.ReadLine());

   
        if (pertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} está contido na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não está contido na sequência de Fibonacci.");
        }
    }

    static bool pertenceFibonacci(int numero)
    { 
        int a = 0;
        int b = 1;

        
        if (numero == a || numero == b)
        {
            return true;
        }

        int proximo_numero = a + b;

        
        while ( proximo_numero <= numero)
        {
            if (proximo_numero == numero)
            {
                return true;
            }

            
            a = b;
            b = proximo_numero;
            proximo_numero = a + b;
        }

        
        return false;
    }
}
