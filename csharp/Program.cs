using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // RF-01: List inicial com 4 times
        List<string> times = new List<string> { "Atlético-MG", "Cruzeiro", "América-MG", "Villa Nova" };

        Console.WriteLine("RF-01: Exibir os times");
        for (int i = 0; i < times.Count; i++)
        {
            Console.WriteLine($"Índice {i}: {times[i]}");
        }

        Console.WriteLine("\nRF-02 e RF-03: Confrontos de Ida e Volta");
        int totalIdaVolta = 0;
        for (int i = 0; i < times.Count; i++) 
        {
            for (int j = 0; j < times.Count; j++)
            {
                if (i == j)
                {
                    continue; // RF-03: Evita que o time jogue contra si mesmo
                }
                Console.WriteLine($"{times[i]} x {times[j]}");
                totalIdaVolta++;
            }
        }
        Console.WriteLine($"Total de confrontos (ida e volta): {totalIdaVolta}"); // RF-04

        Console.WriteLine("\nRF-05 e RF-06: Turno Único");
        int totalTurnoUnico = 0;
        for (int i = 0; i < times.Count; i++)
        {
            for (int j = i + 1; j < times.Count; j++)
            {
                Console.WriteLine($"{times[i]} x {times[j]}");
                totalTurnoUnico++;
            }
        }
        Console.WriteLine($"Total de confrontos (turno único): {totalTurnoUnico}"); // RF-06

        Console.WriteLine("\nETAPA 4: Inclusão do 5º time (Tombense) em C#");
        times.Add("Tombense");
        Console.WriteLine($"Times atualizados com sucesso! Nova quantidade: {times.Count}");
    }
}