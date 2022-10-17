using System;

class Programa9
{
    static void Main(string[] args)

    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais.");

        int idadeCliente = 47;
        bool acompanhadoPorAdulto = true;

        string textoAdicional;

        if (acompanhadoPorAdulto == true && idadeCliente <= 17)
        {
            textoAdicional = "Menor está acompanhado. Pode entrar!";
        }
        else
        {
            textoAdicional = "Menor não está desacompanhado. Não pode entrar!";
        }


        if (idadeCliente >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else if (acompanhadoPorAdulto == true)
        {
            Console.WriteLine(textoAdicional);
        }
        else
        {
            Console.WriteLine(textoAdicional);
        }



        Console.WriteLine("Tecle qualquer tecla para fechar...");
        Console.ReadLine();

    }

}