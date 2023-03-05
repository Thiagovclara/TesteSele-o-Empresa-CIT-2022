using System;
using System.Collections.Generic;


namespace Questao3
{
    public class Program
    {
        public static int CalculaNumeroDaSenha(string[] senha)
        {
            int posicao = 0;

            string[] vetorInicial = senha;

            List<int> senhaSomada = new List<int>();

            for (int k = 0; k < 10; k++)
            {
                int soma = 0;

                for (int i = 0; i < vetorInicial.Length; i++)
                {
                    string s = vetorInicial[i].Substring(posicao, 1);

                    soma = int.Parse(s) + soma;
                }

                if (soma >= 5)
                {
                    senhaSomada.Add(1);
                }
                else
                    senhaSomada.Add(0);

                posicao++;
            }

            senhaSomada.TrimExcess();

            int resultado = 0;

            for (int j = 0; j < 10; j++)
            {
                resultado += (int)Math.Pow(2, senhaSomada.Count - 1 - j) * senhaSomada[j];

            }

            return resultado;
        }

        static void Main(string[] args)
        {
            CalculaNumeroDaSenha(new string[] { "0110100000", "1001011111", "1110001010",
                "0111010101", "0011100110", "1010011001", "1101100100", "1011010100", "1001100111", "1000011000" });
        }
    }
}
