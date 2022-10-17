using System;

class Programa10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        //investimento = investimento + investimento * 0.005;
        
        //Console.WriteLine(investimento + " reais.");

        int mes = 1;
        
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes++;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento + " reais.");
        }


        Console.WriteLine("Tecle qualquer tecla para fechar.");
        Console.ReadKey();
    }
}

