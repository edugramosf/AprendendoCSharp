﻿
using System;

class ProgramaDesafioMultiplosDe3
{
    static void Main(String[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}