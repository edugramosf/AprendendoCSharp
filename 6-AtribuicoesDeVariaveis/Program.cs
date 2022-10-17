using System;

class Programa6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Tecle qualquer tecla para fechar.");
        Console.ReadKey();
    }
}