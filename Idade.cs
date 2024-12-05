/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld
{
    static void Main()
    {
        Console.Write("Qual e a sua idade em dias : ");
        int totalDias = int.Parse(Console.ReadLine());
        
        int anos = totalDias / 365;
        int diasRestantes = totalDias % 365;
        int meses = diasRestantes / 30;
        diasRestantes = diasRestantes % 30;
        int dias = diasRestantes;
        
        Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias.");
    }
}