using System;

class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa 8 - Condicionais");

        int idade = 18;

        if(idade < 18)
        {
            Console.WriteLine("Não pode entrar na festa. A sua idade é " + idade);
        }
        else
        {
            Console.WriteLine("Você pode entrar na festa. Sua idade é " + idade);
        }

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}