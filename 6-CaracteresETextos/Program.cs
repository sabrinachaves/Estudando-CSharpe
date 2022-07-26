using System;

class Programa
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Projeto 5 - Caracteres e Textos\n");

        char letra = 'a';
        Console.WriteLine(letra + "\n");

        letra = (char)65;
        Console.WriteLine(letra + "\n");

        letra = (char)(65 + 1);
        Console.WriteLine(letra + "\n");

        letra = (char)72;
        Console.WriteLine(letra + "\n");

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
    
}