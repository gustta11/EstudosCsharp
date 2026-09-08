using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios20
{
    class Aleatorio
    {
        public string AcertarNumeroAleatorio()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 11);
            int numero;
            do
            {
                Console.WriteLine("Informe um número");
                numero = Convert.ToInt16(Console.ReadLine());
                if(numero != numeroAleatorio)
                {
                    Console.WriteLine("Errou");
                }
            } while (numero != numeroAleatorio);

            return "Acertou";
        }
    }
}
