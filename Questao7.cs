using System;
using System.Globalization;



namespace Questão8
{
    internal class Program
    { 


        static void Main(string[] args)
        {


        Console.WriteLine(EscolheTaxi("2.5", "1.0", "5.0", "0.75"));
        }

        public static string EscolheTaxi(string tf1, string vqr1, string tf2, string vqr2)
        {


            double taxaFixa1 = double.Parse(tf1.Replace(".",","));
            double taxaFixa2 = double.Parse(tf2.Replace(".", ","));
            double taxaKm1 = double.Parse(vqr1.Replace(".", ","));
            double taxaKm2 = double.Parse(vqr2.Replace(".", ","));

            if (taxaFixa1 == taxaFixa2 && taxaKm1 == taxaKm2)
            {
                return "Tanto faz";
            } else 

                if (taxaFixa1 > taxaFixa2 && taxaKm1 > taxaKm2)
                {
                    return "Empresa 2";
                } else
                    if (taxaFixa1 < taxaFixa2 && taxaKm1 < taxaKm2)
                    {
                return "Empresa 1";
                    } else
                         {
                            double dist = (taxaFixa2 - taxaFixa1) / (taxaKm1 - taxaKm2);

                            string distLetra = dist.ToString("N2");

                          string resultadoDist =  AlgSignif(dist);

                

                if (taxaFixa1 + taxaKm1*(dist - 1)  > (taxaFixa2 + taxaKm2 * (dist))){

                    return "Empresa 2 quando a distância < " + resultadoDist + ", Tanto faz quando a distância = " + resultadoDist + ", Empresa 1 quando a distância > " + resultadoDist;
                     
                        } else
                    return "Empresa 1 quando a distância < " + resultadoDist + ", Tanto faz quando a distância = " + resultadoDist + ", Empresa 2 quando a distância > " + resultadoDist;
            }


        }

        public static string AlgSignif(double valor)
        {
            string n1 = valor.ToString("N1");
            string n2 = valor.ToString("N2");

            if (n2[n2.Length - 1] == '0') 
            {
                return n1;

            }else
            {
                return n2;
            }
        }
    }
}
