using System;
using System.Runtime.CompilerServices;

class Programa5
{
    static void Main(string[] args)

    {

        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string palavra = "Olá!";
        Console.WriteLine(palavra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java ";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle qualquer tecla para fechar...");
        Console.ReadKey();


    }

}
