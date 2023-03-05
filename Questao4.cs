using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace Questao4
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
           CalculaTopOcorrenciasDeQueries("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
               new string[] { "a", "em", "i", "el" }, 2);
        }

        static string[] CalculaTopOcorrenciasDeQueries(string texto, string[] queries, int k)
        {

            string a = texto;
            string[] b = queries;

            var finder = new Dictionary<string , int>();

            Regex regex;

            foreach (string termo in b)
            {
                regex = new Regex(termo);
                int result = regex.Matches(a).Count;

                finder.Add(termo, result);       
            }
            finder.TrimExcess();
            var dict = finder.OrderByDescending(c => c.Value);


            string[] vetor = new string[k];
            int i = 0;

                    foreach (KeyValuePair<string, int> d in dict)
                    {
                         vetor[i] = d.Key;

                        if(i == (k-1))
                {
                    break;

                }
                else
                {
                    i++;
                }

                    }

            return vetor;

        }


    }
}
