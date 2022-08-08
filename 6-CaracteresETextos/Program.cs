using System;

class Programa
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Projeto 6 - Caracteres e Textos\n");

        char letra = 'a';
        Console.WriteLine(letra + "\n");

        letra = (char)65;
        Console.WriteLine(letra + "\n");

        letra = (char)(65 + 1);
        Console.WriteLine(letra + "\n");

        letra = (char)72;
        Console.WriteLine(letra + "\n");

        string primeiraFrase = "Olá, meu nome é Sabrina";
        Console.WriteLine(primeiraFrase);

        //É possível criar uma string vazia, mas não é possível criar um char vazio;

        Console.WriteLine(@"Meus hobbys são:
            - Ler;
            -Yoga;
            -Musculação;
            -Jogos de tabuleiros");

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
    
}