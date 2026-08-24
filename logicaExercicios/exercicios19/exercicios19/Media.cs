using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios19
{
    class Media
    {
        public double MediaDosValores(int[] numeros)
        {
            double media = 0;
            int soma = 0;

            if(numeros.Length != 0)
            {
                for(int i= 0; i < numeros.Length; i++)
                {
                    soma += numeros[i]
;               }
                media = soma / numeros.Length;
            }
            else
            {
                Console.WriteLine("Array vazio");
            }

            return media;
        }
    }
}
