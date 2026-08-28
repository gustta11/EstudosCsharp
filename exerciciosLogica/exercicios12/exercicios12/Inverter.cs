using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios12
{
    class Inverter
    {
        public void InverterNumeros(int[] numeros)
        {
            for(int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
