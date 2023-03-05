using System;
using System.Linq;

namespace Questao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] result = ShuffleMusicas(new int[] { 2, 10, 5, 3 });

            foreach (int m in result)
            {
                Console.WriteLine(m);
            }
        }

        public static int[] ShuffleMusicas(int[] musicasTocadas)
        {

            int[] musicas = musicasTocadas;

            int[] musicasCrescente = musicas.OrderBy(x => x).ToArray();

            int[] musicasDecrescente = musicas.OrderByDescending(y => y).ToArray();

            int[] listaAleatoria = new int[musicas.Length];

       
            int contador = 0;

           
            for (int i = 0; i < musicas.Length; i++)
            {

                listaAleatoria[contador] = musicasDecrescente[i];
                contador++;

                if (contador == musicas.Length)
                {
                    break;
                }

                listaAleatoria[contador] = musicasCrescente[i];
                contador ++;

                if(contador == musicas.Length){
                    break;
                }
            }

            return listaAleatoria;

        }
    }
}
