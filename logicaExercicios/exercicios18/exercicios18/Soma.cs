using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios18
{
    class Soma
    {
        public int SomaDosNumeros(int[] numeros)
        {
            int soma = 0;

            if(numeros.Length != 0)
            {

                for(int i = 0; i < numeros.Length; i++)
                {
                    soma += numeros[i];
                }

            }
            else
            {
                Console.WriteLine("Array vazio");
            }

            return soma;
        }
    }
}
