using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios19
{
    class Bissexto
    {
        public string VerificarAnoBissexto(int ano)
        {
            if(ano % 400 == 0)
            {
                return "Bissexto";
            }
            else if (ano % 4 == 0 && ano % 100 != 0)
            {
                return "Bissexto";
            }
            else
            {
                return "Não é bissexto";
            }
        }
    }
}
