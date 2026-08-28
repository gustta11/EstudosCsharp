using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios13
{
    class Array
    {
        public int EncontrarMaiorNumero(int[] numeros)
        {
            int maior = numeros[0];

            for(int i =0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            return maior;
        }
    }
}
