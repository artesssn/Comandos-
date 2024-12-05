/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Dias
{
    static void Main()
    {
        Console.Write("Coloque uma data dd/MM/yyyy: ");
        
        string dataInicio = Console.ReadLine();
        Console.Write("Agora colque outra data dd/MM/yyyy: ");
        string dataFim = Console.ReadLine();
        DateTime inicio = DateTime.ParseExact
        (dataInicio, "dd/MM/yyyy", null);
        DateTime fim = DateTime.ParseExact(dataFim, "dd/MM/yyyy", null
        );
        TimeSpan intervalo = fim - inicio;
        int quantidadeDias = intervalo.Days;
        Console.WriteLine($"Adistancia de dia das dastas e = {quantidadeDias} dias.");
    }
}