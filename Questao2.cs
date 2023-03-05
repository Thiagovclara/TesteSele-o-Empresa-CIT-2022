using System;
using System.Collections.Generic;



public class Challenge
{

    public static void Main(string[] Args)
    {
        RetornaMenorEMaiorValorDeVendas(new int[][] { new int[] { 200, 100 }, new int[] { 300 } });
    }
    public static int[] RetornaMenorEMaiorValorDeVendas(int[][] tickets)
    {

        int[][] listaVendas = new int[2][];
        listaVendas = tickets;
        List<int> listaCompleta = new List<int>();

        for (int i = 0; i < listaVendas.Length; i++)
        {
            for (int j = 0; j < listaVendas[i].Length; j++)
            {
                if (listaVendas[i][j] > 20 && listaVendas[i][j] < 500)
                    listaCompleta.Add(listaVendas[i][j]);

            }
        }
        listaCompleta.Sort();
        listaCompleta.TrimExcess();

        int[] resultadoVendas = new int[2] { listaCompleta[0], listaCompleta[listaCompleta.Count - 1] };

        foreach (int o in resultadoVendas) { 
        Console.WriteLine(o);
    }
         return resultadoVendas;


    }
}

