using System;

class Programa1
{ 
static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 2 - Criando Variáveis");
        int idade;
        idade = 27;

        Console.WriteLine("Minha idade é: " + idade);

        idade = 27 - 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;

        Console.WriteLine(idade);

        idade = (5 - 2) * 3;

        Console.WriteLine(idade);

        Console.WriteLine("Tecle qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

