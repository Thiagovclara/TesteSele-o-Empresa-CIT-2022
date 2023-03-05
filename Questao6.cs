using System;


namespace Questão6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChecaNumeroEscondido(12345, 235));
        }

        public static bool ChecaNumeroEscondido(int numero, int numeroOculto)
        {
            string num = numero.ToString();
            string numOculto = numeroOculto.ToString();

            int j = 0;

            int contador = 0;

            for (int i = 0; i < num.Length; i++)
            {
               
               if (num[i] == numOculto[j])
                {      
                    j++;
                    contador++;
                } 

               if(contador == (numOculto.Length))
                {
                    break;
                } 

            }
            return contador == numOculto.Length ? true : false;
        }
    }
}
