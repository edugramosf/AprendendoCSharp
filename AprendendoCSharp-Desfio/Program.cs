using System;

class ProgramaDesafio0
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if(salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142 reais.");

        } else if (salario >= 2800.1 && salario <= 3751.0) {
            Console.WriteLine("O IR é de 15% e pode deduzir R$ 350 reais.");

        } else if (salario >= 3751.1 && salario <= 4664.0)
        {
            Console.WriteLine("O IR é de 22.5% e pode deduzir R$ 636 reais.");
        }

        Console.WriteLine("Tecle qualquer tecla para fechar...");
        Console.ReadKey();
    }
}