using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios21
{
    class Numeros
    {
        public void EcontrarNumeros(int number)
        {
            int impares = 0;
            int pares = 0;
            for(int i = 1; i<= number; i++)
            {
                if(i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine($"{pares} pares e {impares} impares");
        }
    }
}
