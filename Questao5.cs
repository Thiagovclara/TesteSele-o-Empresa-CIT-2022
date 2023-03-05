using System;
using System.Collections.Generic;
using System.Linq;



namespace Questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] minutosAssistidos = { 6144, 2742, 330, 30, 1500, 4032, 24036, 3288, 2076, 24540, 4716 };
            bool[] assinantes = { true, false, false, false, true, false, true, true, false, false, false };

            int[] horasAssistidas = ConvertParaHoras(minutosAssistidos);

            int[] temposTotais = CalculaHorasTotaisPorUsuario(horasAssistidas, assinantes);

            int somatorioHoras = temposTotais.Sum();

            int[] probabilidades = CalcularChances(temposTotais, somatorioHoras);

        }

        private static int[] ConvertParaHoras(int[] minutosAssistindos)
        {
            var horasAssistidas = new List<int>();

            foreach (double minutos in minutosAssistindos)
            {
                double horas = minutos / 60;
                int hora = ((int)Math.Ceiling(horas));

                horasAssistidas.Add(hora);
            }

            return horasAssistidas.ToArray();
        }

        private static int[] CalculaHorasTotaisPorUsuario(int[] horasAssistidas, bool[] assinantes)
        {
            var horasFinais = new List<int>();

            for(int i=0; i< horasAssistidas.Length; i++)
            {
                int horaCalculada = assinantes[i] ? horasAssistidas[i] * 2 : horasAssistidas[i];
                horasFinais.Add(horaCalculada);
            }

            return horasFinais.ToArray();
        }

        private static int[] CalcularChances(int[] temposTotais, int somatorio)
        {
            var probabilidades = new List<int>();

            foreach (double tempo in temposTotais)
            {
                double chance = tempo / somatorio;

                int porcentagem = (int)(Math.Round(chance * 100));
                probabilidades.Add(porcentagem);
            }

            return probabilidades.ToArray();
        }

    }
}
