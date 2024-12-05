/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class ContadorPalavras
{
    static void Main()
    {
        Console.Write("Me fala uma frase: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int numeroDePalavras = palavras.Length;
        Console.WriteLine($"A frase possui {numeroDePalavras} palavras.");
    }
}