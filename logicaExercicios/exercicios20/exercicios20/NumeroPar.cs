using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios20
{
    class NumeroPar
    {
        public int QuatidadeDeNumerosPar(int[] numeros)
        {
            int quantidadeNumerosPar = 0;

            if (numeros.Length != 0)
            { 
                for(int i = 0; i< numeros.Length; i++)
                {
                    if (numeros[i]%2 == 0)
                    {
                        quantidadeNumerosPar++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Array vazio");
            }

            return quantidadeNumerosPar;
        }
    }
}
