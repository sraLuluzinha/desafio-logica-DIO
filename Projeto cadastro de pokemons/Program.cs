using System;

class Program
{
    static void Main()
    {
        // Arrays com os heróis e seus XP
        string[] nomes = 
        { 
            "Poochyena", 
            "Zigzagoon", 
            "Dragonite", 
            "Dragonite", 
            "Dragonite", 
            "Poochyena", 
            "Wurmple" 
        };

        int[] xps = 
        { 
            800, 
            1500, 
            5200, 
            6800, 
            7200, 
            900, 
            300 
        };

        // Laço de repetição
        for (int i = 0; i < nomes.Length; i++)
        {
            string nivel = "";

            // Estrutura de decisão
            if (xps[i] < 1000)
                nivel = "Ferro";
            else if (xps[i] <= 2000)
                nivel = "Bronze";
            else if (xps[i] <= 5000)
                nivel = "Prata";
            else if (xps[i] <= 7000)
                nivel = "Ouro";
            else if (xps[i] <= 8000)
                nivel = "Platina";
            else if (xps[i] <= 9000)
                nivel = "Ascendente";
            else if (xps[i] <= 10000)
                nivel = "Imortal";
            else
                nivel = "Radiante";

            // Saída
            Console.WriteLine($"O Herói de nome {nomes[i]} está no nível de {nivel}");
        }
    }
}
