using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios16
{
    class Array
    {
        public int Maior(int[] numeros)
        {
            int maior = 0;

            for(int i =0; i < numeros.Length; i++)
            {

                if (maior < numeros[i])
                {
                    maior = numeros[i];
                }
            }

            return maior;

        }
    }
}
