
using System;

class ProgramaDesafioFatorial
{
    static void Main(String[] args)
    {
        int fatorial = 1;
        for (int i = 1; i <= 10; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
        
    }
}
