using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios22
{
    class Media
    {
        public void MediaAlunos()
        {
            double media;
            double nota1;
            double nota2;
            int aprovados = 0;
            int reprovados = 0;
            string resposta;

            do
            {
                Console.WriteLine("Insira uma nota:");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insira outra nota:");
                nota2 = Convert.ToDouble(Console.ReadLine());

                media = (nota1 + nota2) / 2;

                if (media >= 7)
                {
                    Console.WriteLine($"Média:{media}, Situação: Aprovado");
                    aprovados++;
                }
                else
                {
                    Console.WriteLine($"Média:{media}, Situação: Reprovado");
                    reprovados++;
                }

                Console.WriteLine("Quer cadastrar outro aluno?");
                resposta = Console.ReadLine();

                if(resposta == "Não")
                {
                    Console.WriteLine($"Aprovados:{aprovados}");
                    Console.WriteLine($"Reprovados:{reprovados}");
                }

            } while (resposta != "Não");
        }
    }
}
