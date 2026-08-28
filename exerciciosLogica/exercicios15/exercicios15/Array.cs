using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios15
{
    class Array
    {
        public int SomaDosNumeros(int[] numeros)
        {
            int soma = 0;

            for(int i = 0; i<numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
