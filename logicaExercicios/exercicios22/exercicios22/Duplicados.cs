using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios22
{
    class Duplicados
    {
        public List<int> EcontrarNumerosDuplicados(int[] numeros)
        {
            List<int> duplicados = new List<int>();
            int contador = 0;

            foreach (int numero in numeros)
            {
                for(int i =0; i<numeros.Length; i++)
                {
                    if(numeros[i] == numero)
                    {
                        contador++;
                        
                        if(contador >= 1)
                        {
                            if (contador > 1 && !duplicados.Contains(numero))
                            {
                                duplicados.Add(numero);
                                contador = 0;
                                continue;
                            }else if(contador == 1 && duplicados.Contains(numero))
                            {
                                contador = 0;
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            return duplicados;
        }
    }
}
