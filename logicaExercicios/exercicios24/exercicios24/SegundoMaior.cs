using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios24
{
    class SegundoMaior
    {
        public int EcontrarSegundoMaiorNumero(int[] numeros)
        {
            int maior = numeros[0];
            int segundoMaior = 0;

            for(int i =0; i< numeros.Length; i++)
            {
                if(maior < numeros[i])
                {
                    segundoMaior = maior;
                    maior = numeros[i];
                }

                if( maior > numeros[i] && numeros[i] > segundoMaior)
                {
                    segundoMaior = numeros[i];
                }
            }

            return segundoMaior;
        }
    }
}
