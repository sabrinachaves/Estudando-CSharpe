using System;

class Programa
{
    public static void Main(string[] args)
    {
        double divisaoInteira = 7/5;

        double divisao = 7.0 / 5; //Para aparecer a parte decimal na resposta, um dos números precisa ter casa decimal, mesmo que .0

        Console.WriteLine("O resultado da primeira divisão é: " + divisaoInteira);
        Console.WriteLine("O resultado da segunda divisão é: " + divisao);
    }
}