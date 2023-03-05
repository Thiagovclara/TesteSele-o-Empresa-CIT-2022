using System;
using System.Collections.Generic;


//Enunciado no arquivo readme.md.

public class Challenge
{
    public static void Main(string[] args)
    {

        Console.WriteLine(UltimaParada(2, 8, new int[] { 20, 15, 22, 18 }));
    }

    public static int UltimaParada(int combustivel, int consumo, int[] postosDeGasolina)
    {

        int[] distancias = postosDeGasolina;

        int capacidade = combustivel * consumo;

        List<int> distMaiores = new List<int>();

       foreach(int o in distancias)
        {
            if (o <= capacidade)
            {
                distMaiores.Add(o);
            }
        }

        if (distMaiores.Count > 0)
        {
            distMaiores.Sort();
            return distMaiores[distMaiores.Count - 1];
        }
        else
        {
            return -1;
        }
        
            
            
    }

}
