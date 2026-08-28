using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios23
{
    class Duplicados
    {
        public List<int> RemoverDuplicados(List<int> numeros)
        {
            List<int> naoDuplicados = new List<int>();
            

            foreach(int numero in numeros)
            {
                if (!naoDuplicados.Contains(numero))
                {
                    naoDuplicados.Add(numero);
                }
            }
            return naoDuplicados;
        }

    }
}
