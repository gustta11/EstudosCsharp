using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios17
{
    class Array
    {
        public int MenorNumero(int[] numeros)
        {
            int menor = numeros[0];

            for(int i = 0; i< numeros.Length; i++)
            {
                if(menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }

            return menor;
        }
    }
}
