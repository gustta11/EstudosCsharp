using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios24
{
    class Nomes
    {
        public void AdicionarNome()
        {
            string?[] nomes = new string[5];

            for(int i =0; i<5; i++)
            {
                Console.WriteLine("Informe um nome:");
                nomes[i] = Console.ReadLine();
            }

            foreach(string ?n in nomes)
            {
                Console.WriteLine(n);
            }
        }
    }
}
