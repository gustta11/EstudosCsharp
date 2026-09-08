using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios23
{
    class Nomes
    {
        public string ConsultarNomes(string[] nomes, string name)
        {
            foreach (string nome in nomes)
            {
                if(nome == name)
                {
                    return "Existe";
                }
            }

            return "Não existe";
        }
    }
}
