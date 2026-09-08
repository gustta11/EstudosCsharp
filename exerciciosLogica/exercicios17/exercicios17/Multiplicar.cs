using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios17
{
    class Multiplicar
    {
        public int CalcularNumeros(int number1, int number2)
        {
            if(number1 == number2)
            {
                return number1 + number2;
            }
            else
            {
                return number1 * number2;
            }
        }

        public int CalcularNumeros2(int number1, int number2)
        {
            int result = number1 == number2 ? number1 + number2 : number1 * number2;

            return result;
        }
    }
}
