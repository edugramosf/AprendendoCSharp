using System;

class Programa8
{
    static void Main(string[] args)

    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais.");

        int idadeJoao = 16;
        bool acompanhadoPorAdulto = true;


        if ((idadeJoao >= 18 || (idadeJoao <= 17) && (acompanhadoPorAdulto != false)))
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
             Console.WriteLine("Menor de 18 anos não pode entrar!");
        }


        Console.WriteLine("Tecle qualquer tecla para fechar...");
        Console.ReadLine();

    }

}