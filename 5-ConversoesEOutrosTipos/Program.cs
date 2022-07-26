using System;

class Programa
{
    public static void Main(string[] args)
    {
        double salario = 3000.15;

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y;
        y = 15000;
        Console.WriteLine(y);


        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}