using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios11
{
    class Fatorial
    {
        public int CalcularFatorial(int number)
        {
            int resultado = 1;

            for(int i = number; i > 0; i--)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
