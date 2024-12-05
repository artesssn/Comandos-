/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class QualAnimal
{
    static void Main()
    {
        Console.Write("voce curte animal vertebrado fale (sim ou nao) : ");
        string vertebrado = Console.ReadLine().ToLower();
        Console.Write("Se sim, voce gosta de (ave ou mamifero): ");
        string classe = Console.ReadLine().ToLower();
        Console.Write("Voce e mais (carnivoro, onivoro, herbivoro ou hematofago): ");
        string dieta = Console.ReadLine().ToLower();
        string animal = "";
        if (vertebrado == "sim")
        {
            if (classe == "ave")
            {
                animal = dieta == "carnivoro" ? "aguia" : "pombo";
            }
            else if (classe == "mamifero")
            {
                animal = dieta == "onivoro" ? "homem" : "vaca";
            }
        }
        else
        {
            if (classe == "inseto")
            {
                animal = dieta == "hematofago" ? "pulga" : "lagarta";
            }
            else if (classe == "anelideo")
            {
                animal = dieta == "hematofago" ? "sanguessuga" : "minhoca";
            }
        }
     
    }
}