using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios14
{
    class Array
    {
        public int EcontrarMenorNumero(int[] numero)
        {
            int menor = numero[0];

            for(int i = 0; i<numero.Length; i++)
            {
                if (numero[i] < menor)
                {
                    menor = numero[i];
                }
            }

            return menor;
        }
    }
}
