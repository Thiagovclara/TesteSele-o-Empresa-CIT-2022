using System;
using System.Collections.Generic;
using System.Linq;



namespace Questao9refeita
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            MenorStringMaior("Qualified");
        }

        public static string MenorStringMaior(string name)
        {
            Dictionary<string, int> lista2 = new Dictionary<string, int>();
            List<string> lista3 = new List<string>();

            lista2 = GeraLista(name);


            Console.WriteLine("Ordem na lista 2:");

            foreach (KeyValuePair<string, int> l in lista2)
            {
                lista3.Add(l.Key);

            }
            lista3.Sort();

            int indice = lista3.IndexOf(name);


            if (indice == (lista3.Count - 1))
            {
                Console.WriteLine("Sem resposta");
                return "sem resposta";
                
            }
            else
                        {
                Console.WriteLine("Saída: " + lista3[indice + 1]);
                return lista3[indice + 1];
                        }
              
        }

            public static Dictionary<string, int> GeraLista(string palavra)
            {
                Dictionary<string, int> lista1 = new Dictionary<string, int>();
                int contador = 0;

                 Permutation(palavra);

                void Permutation(string rest, string prefix = "")
                {

                    if (string.IsNullOrEmpty(rest))
                     {

                    if (lista1.ContainsKey(prefix) == false)

                        lista1.Add(prefix, contador);
                    contador++;
                      }

                    for (int i = 0; i < rest.Length; i++)
                    {
                        Permutation(rest.Remove(i, 1), prefix + rest[i]);
                    }
                }
                return lista1;
            }   
    }
}
