﻿public class ArrayEListas
{
    public static void Arrays()
    {
        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posição N* {contador} - {arrayInteiros[contador]}");
        }

        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine(valor);
        }
    }
}