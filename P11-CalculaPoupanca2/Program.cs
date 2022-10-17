using System;

class Programa10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");



        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes++;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento + " reais.");
        }
        */


        double investimento = 1000;
        
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento + " reais.");
        }




        Console.WriteLine("Tecle qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

